using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;
        private string direccion;

        #region Propiedades
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public int Dni
        {
            get { return dni; }
            set
            {
                ValidarDNI(value);

                dni = value;
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion

        #region Constructores
        protected Persona(int id,  string nombre, string apellido, int edad, int dni, string direccion)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.Dni = dni;
            this.direccion = direccion;
        }

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Persona()
        {

        }

        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Id N°" + Id);
            sb.AppendLine(Apellido);
            sb.AppendLine(", " + Nombre);
            return sb.ToString();
        }

        public void ValidarDNI(int value)
        {
            if (value < 1000000)
            {
             //   throw new PersonaSinDniException("Dni incorrecto");
            }
        }
        #endregion
    }
}
