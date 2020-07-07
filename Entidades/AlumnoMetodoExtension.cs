using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AlumnoMetodoExtension
    {
        public static int SetNotaFinal(this Alumno al, int datoA, int datoB)
        {
            return al.NotaFinal = (datoA + datoB) / 2;
        }

        public static void SetAprobacion(this Alumno al, int dato)
        {
            al.Aprueba = true;
            if (dato < 4)
            {
                al.Aprueba = false;
            }
        }
    }
}
