using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionCursos.CapaEntidad
{

    public class Curso
{
    public int CursoID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Creditos { get; set; }
}
}
