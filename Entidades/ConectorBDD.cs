using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Excepciones;

namespace AriasMariano_2D_SP
{
    public static class ConectorBDD
    {

        static SqlCommand command;
        static SqlConnection connection;

        static ConectorBDD()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-NT5B90I\SQLEXPRESS; Initial Catalog=JardinUtn;Integrated Security=True";
        }
        /// <summary>
        /// Obtengo la lista de Alumnos desde la base de datos
        /// </summary>
        /// <returns></returns>
        public static Queue<Alumno> GetAlumnos()
        {
            Queue<Alumno> alumnos = new Queue<Alumno>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from Alumnos";

                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    alumnos.Enqueue(new Alumno(int.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), int.Parse(sqlDataReader[3].ToString()), int.Parse(sqlDataReader[4].ToString()), sqlDataReader[5].ToString(), sqlDataReader[6].ToString()));
                }
            }
            catch
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return alumnos;
        }
        /// <summary>
        /// Obtengo la lista de Docentes desde la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Docente> GetDocentes()
        {
            List<Docente> docentes = new List<Docente>();
            int aux;
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from Docentes";

                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    // docentes.Add(new Docente(sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), int.Parse(sqlDataReader[2].ToString()), int.Parse(sqlDataReader[3].ToString()), sqlDataReader[4].ToString(), int.Parse(sqlDataReader[5].ToString()), sqlDataReader[6].ToString(), sqlDataReader[7].ToString()));
                    docentes.Add(new Docente(int.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), int.Parse(sqlDataReader[3].ToString()), sqlDataReader[4].ToString(), int.Parse(sqlDataReader[5].ToString()), sqlDataReader[6].ToString(), sqlDataReader[7].ToString()));
                }
            }
            catch(ErrorBDDException ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return docentes;
        }
        public static void SetDocentes(List<Docente> docentes)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand();
                command.Connection = connection;
                
                for (int i = 0; i < docentes.Count; i++)
                {
                    command.Parameters.Clear();
                    //string nombre, string apellido, int edad,  int dni, string direccion, int id, string sexo, string email
                    command.CommandText = "insert into Docentes ( Nombre, Apellido, Edad, Sexo, Dni, Direccion, Email) values( @nombre, @apellido,@edad,@sexo,@dni,@direccion,@email)";
                    //command.Parameters.Add(new SqlParameter("id", docentes[i].Id));
                    command.Parameters.Add(new SqlParameter("nombre", docentes[i].Nombre));
                    command.Parameters.Add(new SqlParameter("apellido", docentes[i].Apellido));
                    command.Parameters.Add(new SqlParameter("edad", docentes[i].Edad));
                    command.Parameters.Add(new SqlParameter("sexo", docentes[i].Sexo));
                    command.Parameters.Add(new SqlParameter("dni", docentes[i].Dni));
                    command.Parameters.Add(new SqlParameter("direccion", docentes[i].Direccion));
                    command.Parameters.Add(new SqlParameter("email", docentes[i].Email));

                    command.ExecuteNonQuery();
                }
            }
            catch(ErrorBDDException)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public static void SetEvaluacionBDD(int idAlumno, int idDocente, int idAula, int nota1, int nota2, float notaF, string obs)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand();
                command.Connection = connection;

                 command.Parameters.Clear();

                 command.CommandText = "insert into evaluaciones (idAlumno, iddocente, idaula,nota_1, nota_2, notaFinal, observaciones)" +
                 " values( @idA, @idD, @idAula, @n1, @n2, @nF, @obs)";

                 command.Parameters.Add(new SqlParameter("idA", idAlumno));
                 command.Parameters.Add(new SqlParameter("idD",idDocente));
                 command.Parameters.Add(new SqlParameter("idAula", idAula));
                 command.Parameters.Add(new SqlParameter("n1", nota1));
                 command.Parameters.Add(new SqlParameter("n2", nota2));
                 command.Parameters.Add(new SqlParameter("nF", notaF));
                 command.Parameters.Add(new SqlParameter("obs", obs));

                 command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static List<Aula> GetAulas()
        {
            List<Aula> aulas = new List<Aula>();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from aulas";

                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    aulas.Add(new Aula(int.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString()));
                }
            }
            catch
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return aulas;
        }
    }
}
