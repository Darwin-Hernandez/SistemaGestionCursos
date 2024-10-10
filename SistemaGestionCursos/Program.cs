using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionCursos.CapaPresentacion;

namespace SistemaGestionCursos
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmGestionInscripciones());  //Para Inscribir Estudiantes un Curso
            //Application.Run(new frmGestionCursos());       //Para Agregar Cursos 
            Application.Run(new frmGestionEstudiantes());  // Para Agregar Estudiantes 
        }
    }
}

