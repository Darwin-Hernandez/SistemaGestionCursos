using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionCursos.CapaEntidad;

namespace SistemaGestionCursos.CapaDatos
{
    public class CursoDatos
    {
        private readonly ConexionBD conexion = new ConexionBD();

        // Método para obtener todos los cursos
        public List<Curso> ObtenerCursos()
        {
            List<Curso> listaCursos = new List<Curso>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT * FROM Cursos";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Curso curso = new Curso
                        {
                            CursoID = Convert.ToInt32(reader["CursoID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString(),
                            Creditos = Convert.ToInt32(reader["Horas"])
                        };
                        listaCursos.Add(curso);
                    }
                }
            }
            return listaCursos;
        }

        // Método para agregar un nuevo curso
        public bool AgregarCurso(Curso curso)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Cursos (Nombre, Descripcion, Horas) VALUES (@Nombre, @Descripcion, @Horas)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", curso.Descripcion);
                    cmd.Parameters.AddWithValue("@Horas", curso.Creditos);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para actualizar un curso existente
        public bool ActualizarCurso(Curso curso)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Cursos SET Nombre = @Nombre, Descripcion = @Descripcion, Horas = @Horas WHERE CursoID = @CursoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CursoID", curso.CursoID);
                    cmd.Parameters.AddWithValue("@Nombre", curso.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", curso.Descripcion);
                    cmd.Parameters.AddWithValue("@Horas", curso.Creditos);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para eliminar un curso por ID
        public bool EliminarCurso(int cursoID)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "DELETE FROM Cursos WHERE CursoID = @CursoID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CursoID", cursoID);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}

