using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Excepciones;
using System.Security.Policy;

namespace AriasMariano_2D_SP
{
    delegate bool GrabarAprobados(Alumno a);

    delegate void Evaluar(object obj);

    public partial class FrmAulaExamen : Form
    {
        public delegate void sendLista(Queue<Alumno> alumnosA, Queue<Alumno> alumnosB);

        private Queue<Alumno> alumnos;
        private Queue<Alumno> alumnosAprobados;
        private Queue<Alumno> alumnosDesaprobados;
        private List<Docente> docentes;
        private List<Aula> aulas;

        event Evaluar EvaluarNext;

        public event sendLista enviaQueue;

        event GrabarAprobados serializarAp;

        Random random = new Random();

        List<Thread> hilos;

        Thread ejecutarEvaluacion;

        public FrmAulaExamen(List<Docente> docentes, Queue<Alumno> alumnos)
        {
            InitializeComponent();
            this.alumnos = alumnos;
            this.docentes = docentes;
            aulas = new List<Aula>();
            hilos = new List<Thread>();

            ejecutarEvaluacion = new Thread(new ParameterizedThreadStart(Llamar));

            alumnosAprobados = new Queue<Alumno>();
            alumnosDesaprobados = new Queue<Alumno>();

            aulas = ConectorBDD.GetAulas();

            EvaluarNext += Llamar;
            serializarAp += Serializacion.GuardarXML;

        }

        private void FrmAulaExamen_Load(object sender, EventArgs e)
        {
            lblAlumno.Text = "El alumno :";
            lblTxt.Text = "está siendo evaluado por";
            lblDocente.Text = "el Docente: ";
            lblNota1.Text = "Nota 1: ";
            lblNota2.Text = "Nota 2: ";
        }

        /// <summary>
        /// Muestra proximo alumno a ser evaluado
        /// </summary>
        /// <returns></returns>
        public Alumno PrepararProximo()
        {
            textBoxProximo.Clear();
            try
            {
                if (alumnos.Count > 0)
                {
                    Alumno alumno = alumnos.Peek();
                    textBoxProximo.Text = alumno.ToString();
                    return alumno;
                }
                else
                {
                    return null;
                }
            }catch(Exception ex)
            {
                throw new ErrorEjecucionException(ex.Message);
            }
        }
        public void Llamar(object txtBox)
        {
            try
            {
                if (alumnos.Count > 0)
                {
                    if (textBoxAlumno.InvokeRequired)
                    {
                        textBoxAlumno.BeginInvoke((MethodInvoker)delegate () {
                            HacerEvaluacion(alumnos.Dequeue(), docentes[random.Next(0, docentes.Count)], (TextBox)txtBox);
                        });
                    }
                    else
                    {
                        //Thread.Sleep(1000);
                        HacerEvaluacion(alumnos.Dequeue(), docentes[random.Next(0, docentes.Count)], (TextBox)txtBox);
                    }
                }
                else
                {
                    MessageBox.Show("No hay alumnos a evaluar");
                }
            }
            catch (Exception ex)
            {
                throw new ErrorEjecucionException(ex.Message);
            }
        }

        public void HacerEvaluacion (Alumno a, Docente d, TextBox text)
        {
            try
            {
                PrepararProximo();
                int nota1 = random.Next(1, 10);
                int nota2 = random.Next(1, 10);

                // llamo a metodos de extension
                a.SetNotaFinal(nota1, nota2);
                a.SetAprobacion(a.NotaFinal);

                Mostrar(a.ToString(), d.ToString(), text);

                textBoxNota1.Text = nota1.ToString();
                textBoxNota2.Text = nota2.ToString();
                if (a.NotaFinal < 4)
                {
                    alumnosDesaprobados.Enqueue(a);
                    Serializacion.GuardarXML(a, "DESAPROBADOS");
                    ConectorBDD.SetEvaluacionBDD(a.Id, d.Id, random.Next(1, 6), nota1, nota2, a.NotaFinal, "Alumno desaprobado");
                    //MessageBox.Show("alumno desaprobado ");
                }
                else
                {
                    //MessageBox.Show("alumno aprobado");
                    alumnosAprobados.Enqueue(a);
                    serializarAp(a);
                    if (a.NotaFinal == 4 || a.NotaFinal == 5)
                    {
                        ConectorBDD.SetEvaluacionBDD(a.Id, d.Id, random.Next(1, 6), nota1, nota2, a.NotaFinal, "Alumno aprobado. Profesor descepcionado");
                    }
                    else
                    {
                        ConectorBDD.SetEvaluacionBDD(a.Id, d.Id, random.Next(1, 6), nota1, nota2, a.NotaFinal, "Alumno aprobado");
                    }
                }
                //MessageBox.Show("alumno evaluado");

                LimpiarTxtBox();
                if (alumnos.Count > 0)
                {
                    EvaluarNext(text);
                }
                else
                {
                   enviaQueue(alumnosAprobados, alumnosDesaprobados);
                   MessageBox.Show("Se han evaluado a todos los alumnos/as");
                   //this.Close();
                }
            }
            catch (Exception)
            {
                //throw new ErrorEjecucionException("error");
            }
        }

        void Mostrar(string strAlumno, string strDocente, TextBox txt)
        {
            if (textBoxAlumno.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
                {
                    textBoxAlumno.Text = strAlumno;
                    textBoxDocente.Text = strDocente;
                });
            }
            else
            {
                textBoxAlumno.Text = strAlumno;
                textBoxDocente.Text = strDocente;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (alumnos != null)
            {
               ejecutarEvaluacion.Start(textBoxAlumno);
                // Llamar(textBoxAlumno);
                btnIniciar.Enabled = false;
            }
        }

        /// <summary>
        /// Limpia textbox
        /// </summary>
        private void LimpiarTxtBox()
        {
            textBoxNota1.Clear();
            textBoxNota2.Clear();
            textBoxAlumno.Clear();
            textBoxDocente.Clear();
            textBoxProximo.Clear();
        }


        private void FrmAulaExamen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ejecutarEvaluacion.IsAlive)
            {
                ejecutarEvaluacion.Abort();
            }
            if (hilos != null)
            {
                foreach (Thread item in hilos)
                {
                    if (item.IsAlive)
                    {
                        item.Abort();
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ejecutarEvaluacion.IsAlive)
            {
                ejecutarEvaluacion.Abort();
            }
            DialogResult = DialogResult.OK;
        }

        private void FrmAulaExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ejecutarEvaluacion.IsAlive)
                ejecutarEvaluacion.Abort();
        }
    }
}
