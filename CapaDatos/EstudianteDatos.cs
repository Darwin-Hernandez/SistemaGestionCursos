using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionCursos.CapaEntidad;

namespace SistemaGestionCursos.CapaDatos
{
    public class EstudianteDatos
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Estudiante> ObtenerEstudiantes()
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT * FROM Estudiantes";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Estudiante estudiante = new Estudiante
                        {
                            EstudianteID = Convert.ToInt32(reader["EstudianteID"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Correo = reader["Email"].ToString()
                        };
                        listaEstudiantes.Add(estudiante);
                    }
                }
            }
            return listaEstudiantes;
        }

        public bool AgregarEstudiante(Estudiante estudiante)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Estudiantes (Nombre, Apellido, Email) VALUES (@Nombre, @Apellido, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                    cmd.Parameters.AddWithValue("@Email", estudiante.Correo);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Estudiantes SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email WHERE EstudianteID = @EstudianteID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", estudiante.EstudianteID);
                    cmd.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                    cmd.Parameters.AddWithValue("@Email", estudiante.Correo);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool EliminarEstudiante(int estudianteID)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "DELETE FROM Estudiantes WHERE EstudianteID = @EstudianteID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", estudianteID);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
