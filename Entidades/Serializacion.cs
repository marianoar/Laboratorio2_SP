using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class Serializacion : IBinario<Alumno>
    {
        /// <summary>
        /// Deserealiza una archivo XML en una ruta determinada: 
        /// La aplicación deberá poder levantar siempre los archivos del siguiente path...
        /// “MisDocumentos/SegundoParcialUtn/JardinUtn/Docentes/”
        /// </summary>
        /// <returns> List<Docente> </returns>
        public static List<Docente> Deserealizer()
        {
            List<Docente> docentes = new List<Docente>();
            string ruta = "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta;

            if (File.Exists(path))
            {
                try
                {
                    XmlTextReader reader = new XmlTextReader(path);
                    XmlSerializer ser = new XmlSerializer(typeof(List<Docente>));

                    docentes = (List<Docente>)ser.Deserialize(reader);
                    reader.Close();
                    return docentes;
                }
                catch (Exception ex)
                {
                    throw new ErrorSerializationException("Error al deserealizar", ex);
                }
            }
            else
            {
                return docentes;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool GuardarXML(Alumno a)
        {
            string archivo = a.Apellido + "_" + a.Nombre + "_" + DateTime.Now.ToString("dd_MM_yy") + ".xml";
            string ruta = "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\Aprobados\\";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta);
            string rutaCompleta = Path.Combine(path + archivo);

            if (Directory.Exists(path))
            {
                WriterXML(a, rutaCompleta);
                return true;
            }
            else
            {
                Directory.CreateDirectory(path);
                WriterXML(a, path);
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="aux"></param>
        /// <returns></returns>
        public static bool GuardarXML(Alumno a, string aux)
        {
            string archivo = a.Apellido+"_"+a.Nombre+"_"+DateTime.Now.ToString("dd_MM_yy")+".xml";
            string ruta = "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\"+aux+"\\";
            string path =Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta);
            string rutaCompleta = Path.Combine(path + archivo);
            if (Directory.Exists(path))
            {
                WriterXML(a, rutaCompleta);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="path"></param>
        private static void WriterXML(Alumno a, string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Alumno));
                serializer.Serialize(writer, a);
            }
            catch(Exception ex)
            {
                throw new ErrorSerializationException("Error al escribir el xml", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        public bool SerealizacionBinaria(Alumno a)
        {
            string ruta = "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\datos.dat";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta);

            FileStream stream = new FileStream(path, FileMode.Create);
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(stream, a);

                return true;
            }
            catch(Exception ex)
            {
                throw new ErrorSerializationException("Error en serealizacion binaria",ex);
            }
            finally
            {
                stream.Close();
            }
        }
        /// <summary>
        /// Deserealiza un archivo binario
        /// </summary>
        /// <param name="archivo">archivo a abrir</param>
        /// <returns></returns>
        public Alumno LeerBinario(string archivo)
        {
            string ruta = "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ruta+archivo);

                if (File.Exists(path))
                {
                    FileStream stream = new FileStream(path, FileMode.Open);
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    Alumno alumno = binaryFormatter.Deserialize(stream) as Alumno;

                    stream.Close();
                    return alumno;
                }
                else
                {
                    throw new FileNotFoundException("no se encontro el archivo");
                }
         

        }
    }
}