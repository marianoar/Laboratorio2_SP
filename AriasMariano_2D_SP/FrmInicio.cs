using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.Diagnostics;

namespace AriasMariano_2D_SP
{
    delegate void LlamarClasesRecreo();

    public partial class FrmInicio : Form
    {
        private Queue<Alumno> alumnos;
        private Queue<Alumno> alumnosAprobados;
        private Queue<Alumno> alumnosDesaprobados;
        private List<Docente> docentes;

        private List<string> mensajes;

        List<Thread> hilos;
       // Thread t;

        bool flagEvaluados = false;

        // event LlamarClasesRecreo iniciarRecreo;

        // contador para el timer
        int t = 0;
        public FrmInicio()
        {
            InitializeComponent();
            lblRecreo.Text = " Mensaje inicio";
            lblTiempo.Text = "Tiempo evaluando : ";

         //   iniciarRecreo += LlamarARecreo;

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            alumnos = new Queue<Alumno>();
            docentes = new List<Docente>();
            alumnosAprobados = new Queue<Alumno>();
            alumnosDesaprobados = new Queue<Alumno>();
            hilos = new List<Thread>();

            //evaluar = new Thread(Evaluar);

            mensajes = new List<string>();

            groupBox2.Visible = false;

            //traigo alumnos y docentes desde la base de datos
            Alumnos = ConectorBDD.GetAlumnos();
            Docentes = ConectorBDD.GetDocentes();

            if (Docentes.Count == 0)
            {
                //traigo los docentes desde el archivo XML
                Docentes= Serializacion.Deserealizer();

                //cargo los docentes en la BDD
                ConectorBDD.SetDocentes(Docentes);

                Docentes = ConectorBDD.GetDocentes();
            }

            RefreshListBox();

            CargarListaMensajes();
        }

        #region Propiedades
        public Queue<Alumno> Alumnos{ get { return alumnos; } set { alumnos = value; } }
        public List<Docente> Docentes { get { return docentes; } set { docentes = value; } }
        public Queue<Alumno> AlumnosAprobados { get { return alumnosAprobados; } set { alumnosAprobados = value; } }
        public Queue<Alumno> AlumnosDesaprobados { get { return alumnosDesaprobados; } set { alumnosDesaprobados = value; } }
        #endregion

        /// <summary>
        /// Actualiza los listbox simultaneamente
        /// </summary>
        private void RefreshListBox()
        {
            listBoxDocentes.Items.Clear();
            for (int i = 0; i < docentes.Count; i++)
            {
                listBoxDocentes.Items.Add(docentes[i].ToString());
            }

            if (flagEvaluados)
            {
                listBoxAlumnos.Items.Clear();
                listBoxAlumnos.Items.Add("todos los alumnos han sido evaluados");
                foreach (Alumno item in alumnosAprobados)
                {
                    listBoxAprobados.Items.Add(item.ToString());
                }
                foreach (Alumno item in alumnosDesaprobados)
                {
                        listBoxDesaprobados.Items.Add(item.ToString());
                }
            }
            else
            {
                foreach (Alumno item in Alumnos)
                {
                    listBoxAlumnos.Items.Add(item.ToString());
                }
            }
        }

        /// <summary>
        /// Inicio evaluaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            IniciarTiempoEvaluacion();

            //iniciarClases.Invoke();

            timerRecreo.Start();
            DialogResult result;
            FrmAulaExamen frmAulaExamen = new FrmAulaExamen(docentes,alumnos);

            frmAulaExamen.enviaQueue += new FrmAulaExamen.sendLista(Mostrar);

            result=frmAulaExamen.ShowDialog();

            if (result == DialogResult.OK)
            {
                lblRecreo.Text = mensajes[2];
                timerRecreo.Stop();
                foreach (Thread item in hilos)
                {
                    if (item.IsAlive)
                    {
                        item.Abort();
                    }
                }
            }
        }

        /// <summary>
        /// Recibe dos listas de alumnos con los resultados desde el Form2 y actualizo listBox
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Mostrar(Queue<Alumno> a, Queue<Alumno> b )
        {
            AlumnosAprobados = a;
            AlumnosDesaprobados = b;
            flagEvaluados = true;
            RefreshListBox();
        }


        /// <summary>
        /// inicio el hilo que cuenta tiempo de duracion evaluaciones via metodo ContarTiempo
        /// </summary>
        public void IniciarTiempoEvaluacion()
        {
            Thread thread = new Thread(ContarTiempo);
            hilos.Add(thread);
            thread.Start();
        }

        /// <summary>
        /// Mide el tiempo transcurrido desde q se presiona el boton de Iniciar evaluacion
        /// </summary>
        private void ContarTiempo()
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            while (true)
            {
                if (this.lblTiempo.InvokeRequired)
                {
                    this.lblTiempo.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblTiempo.Text = "Tiempo evaluando: " + st.Elapsed.ToString("hh\\:mm\\:ss");
                    });
                }
                else
                {
                    this.lblTiempo.Text = "Tiempo evaluando: " + st.Elapsed.ToString("hh\\:mm\\:ss");
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Aborto todos los hilos al cerrar form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread item in hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        /// <summary>
        /// Metodo desactivado
        /// </summary>
       /* public void LlamarAClase()
        {
                if (this.lblRecreo.InvokeRequired)
                {
                    this.lblRecreo.BeginInvoke((MethodInvoker)delegate
                    {
                        this.lblRecreo.Text = " ";
                    });
                }
                else
                {
                    lblRecreo.Text = "Estamos en clase";
                    lblRecreo.ForeColor = Color.Red;
                Thread.Sleep(1000);
                }
        }
        public void LlamarARecreo()
        {
            if (this.lblRecreo.InvokeRequired)
            {
                this.lblRecreo.BeginInvoke((MethodInvoker)delegate
                {
                    this.lblRecreo.Text = " ";
                });
            }
            else
            {
                lblRecreo.Text = "Estamos en recreo";
                lblRecreo.ForeColor = Color.Green;
                Thread.Sleep(1000);
            }
        }*/

        private void CargarListaMensajes()
        {
            mensajes.Add("Estamos en clase.");
            mensajes.Add("Estamos en recreo.");
            mensajes.Add("Las evaluaciones han terminado");
        }

        /// <summary>
        /// Timer alterna anuncio Clase/Recreo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRecreo_Tick(object sender, EventArgs e)
        {
            //los tiempos son menores para probarlo
            lblRecreo.ForeColor = Color.Red;
            lblRecreo.Text = mensajes[0];
            t++;
            if (t >= 10)
            {
                lblRecreo.Text = mensajes[1];
                lblRecreo.ForeColor = Color.Green;
                
                t++;
                if (t == 15)
                {
                    t = 0;
                }
            }
        }
    }
}
