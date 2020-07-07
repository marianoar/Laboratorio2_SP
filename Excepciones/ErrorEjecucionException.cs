using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorEjecucionException : Exception
    {
        public ErrorEjecucionException(string message, Exception innerException) : base(message, innerException)
        {
            string txt = Txt;
            CrearArchivoLogs.Grabar(true, txt);
        }
        public ErrorEjecucionException(string message) :base(message)
        {
            string txt = Txt;
            CrearArchivoLogs.Grabar(true, txt);
        }
        public ErrorEjecucionException() : base( )
        {
            string txt = "Se produjo una excepcion:";
            CrearArchivoLogs.Grabar(true, txt);
        }

        public string Txt
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.Message);
                sb.Append(" el ");
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
