using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private int idAula;
        private string salita;

        public int IdAula { get { return idAula; } set { idAula = value; } }
        public string Salita { get { return salita; } set { salita = value; } }

        public Aula(int idAula, string salita):this()
        {
            this.idAula = idAula;
            this.salita = salita;
        }
        public Aula()
        {

        }
    }
}
