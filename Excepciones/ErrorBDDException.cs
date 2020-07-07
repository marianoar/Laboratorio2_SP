using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorBDDException : Exception 
    {
        public ErrorBDDException(string message, Exception innerException) :base(message, innerException)
        {
          
        }
        public ErrorBDDException(string message):base(message)
        {
           
        }
        public ErrorBDDException() : base()
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
