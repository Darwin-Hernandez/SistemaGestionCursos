using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionCursos.CapaEntidad;

namespace SistemaGestionCursos.CapaDatos
{
    public class InscripcionDatos
    {
        private readonly ConexionBD conexion = new ConexionBD();

        // Método para obtener todas las inscripciones
        public List<Inscripcion> ObtenerInscripciones()
        {
            List<Inscripcion> listaInscripciones = new List<Inscripcion>();
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT * FROM Inscripciones";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Inscripcion inscripcion = new Inscripcion
                        {
                            InscripcionID = Convert.ToInt32(reader["InscripcionID"]),
                            EstudianteID = Convert.ToInt32(reader["EstudianteID"]),
                            CursoID = Convert.ToInt32(reader["CursoID"]),
                            FechaInscripcion = Convert.ToDateTime(reader["FechaInscripcion"])
                        };
                        listaInscripciones.Add(inscripcion);
                    }
                }
            }
            return listaInscripciones;
        }

        // Método para agregar una nueva inscripción
        public bool AgregarInscripcion(Inscripcion inscripcion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Inscripciones (EstudianteID, CursoID, FechaInscripcion) VALUES (@EstudianteID, @CursoID, @FechaInscripcion)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EstudianteID", inscripcion.EstudianteID);
                    cmd.Parameters.AddWithValue("@CursoID", inscripcion.CursoID);
                    cmd.Parameters.AddWithValue("@FechaInscripcion", inscripcion.FechaInscripcion);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para actualizar una inscripción existente
        public bool ActualizarInscripcion(Inscripcion inscripcion)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Inscripciones SET EstudianteID = @EstudianteID, CursoID = @CursoID, FechaInscripcion = @FechaInscripcion WHERE InscripcionID = @InscripcionID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@InscripcionID", inscripcion.InscripcionID);
                    cmd.Parameters.AddWithValue("@EstudianteID", inscripcion.EstudianteID);
                    cmd.Parameters.AddWithValue("@CursoID", inscripcion.CursoID);
                    cmd.Parameters.AddWithValue("@FechaInscripcion", inscripcion.FechaInscripcion);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // Método para eliminar una inscripción por ID
        public bool EliminarInscripcion(int inscripcionID)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            {
                con.Open();
                string query = "DELETE FROM Inscripciones WHERE InscripcionID = @InscripcionID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@InscripcionID", inscripcionID);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}
