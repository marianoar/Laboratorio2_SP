using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Excepciones
{
    public class ErrorSerializationException : Exception
    {
        public ErrorSerializationException(string message, Exception innerException) : base(message, innerException) {
            string txt = Txt;
            CrearArchivoLogs.Grabar(true, txt);
        }

        public ErrorSerializationException(string message):base(message)
        {
            string txt = Txt;
            CrearArchivoLogs.Grabar(true, txt);
        }

        public ErrorSerializationException(): base()
        {
            string txt = Txt;
            CrearArchivoLogs.Grabar(true, txt);
        }


        public string Txt
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.Message);
                sb.Append(" - Fecha: ");
                sb.AppendLine(DateTime.Now.ToString() + ":");
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                return sb.ToString();
            }
        }
    }
}
