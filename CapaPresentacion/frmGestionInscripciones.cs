using System;
using System.Linq;
using System.Windows.Forms;
using FluentValidation;
using SistemaGestionCursos.CapaDatos;
using SistemaGestionCursos.CapaEntidad;
using SistemaGestionCursos.CapaPresentacion.Validaciones;

namespace SistemaGestionCursos.CapaPresentacion
{
    public partial class frmGestionInscripciones : Form
    {
        private readonly InscripcionDatos inscripcionDatos = new InscripcionDatos();
        private readonly EstudianteDatos estudianteDatos = new EstudianteDatos();
        private readonly CursoDatos cursoDatos = new CursoDatos();

        public frmGestionInscripciones()
        {
            InitializeComponent();
            CargarEstudiantes();
            CargarCursos();
            CargarInscripciones();
            dtpFechaInscripcion.Value = DateTime.Now;
        }

        private void CargarEstudiantes()
        {
            cmbEstudiantes.DataSource = estudianteDatos.ObtenerEstudiantes();
            cmbEstudiantes.DisplayMember = "NombreCompleto";
            cmbEstudiantes.ValueMember = "EstudianteID";
        }

        private void CargarCursos()
        {
            cmbCursos.DataSource = cursoDatos.ObtenerCursos();
            cmbCursos.DisplayMember = "Nombre";
            cmbCursos.ValueMember = "CursoID";
        }

        private void CargarInscripciones()
        {
            dgvInscripciones.DataSource = inscripcionDatos.ObtenerInscripciones();
        }

        private void btnAgregarInscripcion_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion
            {
                EstudianteID = (int)cmbEstudiantes.SelectedValue,
                CursoID = (int)cmbCursos.SelectedValue,
                FechaInscripcion = dtpFechaInscripcion.Value
            };

            var validator = new InscripcionValidator();
            var result = validator.Validate(inscripcion);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => error.ErrorMessage)));
                return; 
            }

            if (inscripcionDatos.AgregarInscripcion(inscripcion))
            {
                MessageBox.Show("Inscripción agregada exitosamente.");
                CargarInscripciones();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar la inscripción.");
            }
        }

        private void btnEliminarInscripcion_Click(object sender, EventArgs e)
        {
            if (dgvInscripciones.CurrentRow != null)
            {
                int inscripcionID = Convert.ToInt32(dgvInscripciones.CurrentRow.Cells[0].Value);
                if (inscripcionDatos.EliminarInscripcion(inscripcionID))
                {
                    MessageBox.Show("Inscripción eliminada exitosamente.");
                    CargarInscripciones();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la inscripción.");
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbEstudiantes.SelectedIndex = -1; 
            cmbCursos.SelectedIndex = -1;       
            dtpFechaInscripcion.Value = DateTime.Now; 
        }

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbEstudiantes.SelectedValue = dgvInscripciones.CurrentRow.Cells[1].Value; 
                cmbCursos.SelectedValue = dgvInscripciones.CurrentRow.Cells[2].Value; 
                dtpFechaInscripcion.Value = Convert.ToDateTime(dgvInscripciones.CurrentRow.Cells[3].Value); 
            }
        }
    }
}


