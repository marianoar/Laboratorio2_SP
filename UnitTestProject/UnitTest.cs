using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;



namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SerializarAlumnoXML()
        {
            Alumno alumno = new Alumno(1, "mariano", "arias", 55, 12332155, "sarasa 123", "algo");
            Assert.IsTrue(Serializacion.GuardarXML(alumno));
        }

        [TestMethod]
        public void DeserealizarDocenteXML()
        {
            List<Docente> docentes = Serializacion.Deserealizer();

            Assert.IsNotNull(docentes);
        }

        [TestMethod]
        public void VerificarDeserealizacion()
        {
            List<Docente> docentes = Serializacion.Deserealizer();

            Assert.IsTrue(docentes.Count == 10);
        }

        [TestMethod]
        public void SerializarAlumnoBinario()
        {
            Alumno alumno = new Alumno(1, "mariano", "arias", 55, 12332155, "sarasa 123", "algo");
            Serializacion ser = new Serializacion();
            Assert.IsTrue( ser.SerealizacionBinaria(alumno));
        }


        [ExpectedException(typeof(FileNotFoundException))]
        [TestMethod]
        public void DeserealizarAlumnoBinario()
        {
            Serializacion ser = new Serializacion();
            Alumno alumno = ser.LeerBinario("nada");
        }

        /// <summary>
        /// solamente verifico que al lanzar la excepcion se grabe la informacion en el archivo
        /// </summary>
        [ExpectedException(typeof(ErrorSerializationException))]
        [TestMethod]
        public void VerificarGrabarExcepcionSerialization()
        {
            throw new ErrorSerializationException();
        }
    }
}
