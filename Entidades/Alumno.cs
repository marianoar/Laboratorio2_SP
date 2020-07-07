using AriasMariano_2D_SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public sealed class Alumno: Persona
    {
        private string responsable;
        // int nota1, nota2;
        private int notaFinal;
        private bool aprueba;

        #region Propiedades
        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        /*
        public int Nota1 { get { return nota1; } set { nota1 = value; } }
        public int Nota2 { get { return nota2; } set { nota2 = value; } }
        */
        public int NotaFinal { get { return notaFinal; } set { notaFinal = value; } }
        public bool Aprueba { get { return aprueba; } set { aprueba = value; } }

        #endregion

        #region Constructores
        public Alumno(int id,  string nombre, string apellido, int edad, int dni, string direccion, string responsable) : base(id:id, apellido:apellido, nombre:nombre, edad:edad, dni:dni, direccion:direccion)
        {
            this.responsable = responsable;

        }
        public Alumno() : base()
        {

        }
        #endregion
    }
}
