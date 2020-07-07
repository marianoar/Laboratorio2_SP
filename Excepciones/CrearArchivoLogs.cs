using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excepciones
{
    public static class CrearArchivoLogs 
    {
        static string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
          "\\SegundoParcialUtn\\JardinUtn\\Logs\\logs.txt");
        public static void Grabar(bool append, string mensaje)
        {
            StreamWriter sw = null;
            try
            {
                if (File.Exists(ruta)){
                    sw = new StreamWriter(ruta, append, Encoding.UTF8);
                    sw.Write(mensaje);
                }
                else
                {
                    File.Create(ruta);
                    sw = new StreamWriter(ruta, append, Encoding.UTF8);
                    sw.Write(mensaje);
                }
            }
            catch(Exception ex)
            {
                throw new ErrorEjecucionException("se ha producido un error al grabar archivo", ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static void Grabar(Exception ex, bool append)
        {
            StreamWriter sw = null;
            try
            {
                if (File.Exists(ruta))
                {
                    sw = new StreamWriter(ruta, append, Encoding.UTF8);
                    sw.Write(ex.Message);
                }
                else
                {
                    File.Create(ruta);
                    sw = new StreamWriter(ruta, append, Encoding.UTF8);
                    sw.Write(ex.Message);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }
}
