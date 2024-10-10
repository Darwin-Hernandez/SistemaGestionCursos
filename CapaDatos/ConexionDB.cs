using System.Data.SqlClient;

namespace SistemaGestionCursos.CapaDatos
{
    public class ConexionBD
    {
          //Para la conexion cambiar SQLEXPRESS por que yo lo uso como (SQLEXPRES) con una S
        private readonly string cadenaConexion = @"Server=.\SQLEXPRES;Database=SistemaGestionCursos;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
