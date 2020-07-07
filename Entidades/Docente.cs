using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente: Persona
    {
        private string sexo;
        private string email;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /*
        public Docente (string nombre, string apellido, int edad,  int dni, string direccion, int id, string sexo, string email) : base(id: id, apellido: apellido, nombre: nombre, edad: edad, dni: dni, direccion: direccion)
        {
            this.sexo = sexo;
            this.email = email;
        }
        */

        public Docente(int id, string nombre, string apellido, int edad, string sexo, int dni, string direccion,  string email) : base(id: id, apellido: apellido, nombre: nombre, edad: edad, dni: dni, direccion: direccion)
        {
            this.sexo = sexo;
            this.email = email;
        }
        public Docente():base()
        {

        }
    }
}
