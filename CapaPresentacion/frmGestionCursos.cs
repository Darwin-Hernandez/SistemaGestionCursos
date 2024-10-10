using System;
using System.Linq;
using System.Windows.Forms;
using SistemaGestionCursos.CapaDatos;
using SistemaGestionCursos.CapaEntidad;
using SistemaGestionCursos.CapaPresentacion.Validaciones;
using FluentValidation.Results;

namespace SistemaGestionCursos.CapaPresentacion
{
    public partial class frmGestionCursos : Form
    {
        private CursoDatos cursoDatos = new CursoDatos();

        public frmGestionCursos()
        {
            InitializeComponent();
            CargarCursos();
            dgvCursos.CellClick += dgvCursos_CellClick; 
        }

        private void CargarCursos()
        {
            dgvCursos.DataSource = cursoDatos.ObtenerCursos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso
            {
                Nombre = txtNombreCurso.Text,
                Descripcion = txtDescripcionCurso.Text,
                Creditos = int.TryParse(txtCreditosCurso.Text, out int creditos) ? creditos : 0
            };

            var validator = new CursoValidator();
            ValidationResult result = validator.Validate(curso);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => error.ErrorMessage)));
                return; 
            }

            if (cursoDatos.AgregarCurso(curso))
            {
                MessageBox.Show("Curso agregado exitosamente.");
                CargarCursos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el curso.");
            }
        }

        private void btnActualizarCurso_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                Curso curso = new Curso
                {
                    CursoID = Convert.ToInt32(dgvCursos.CurrentRow.Cells[0].Value), 
                    Nombre = txtNombreCurso.Text,
                    Descripcion = txtDescripcionCurso.Text,
                    Creditos = int.TryParse(txtCreditosCurso.Text, out int creditos) ? creditos : 0
                };

                var validator = new CursoValidator();
                ValidationResult result = validator.Validate(curso);

                if (!result.IsValid)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => error.ErrorMessage)));
                    return; 
                }

                if (cursoDatos.ActualizarCurso(curso))
                {
                    MessageBox.Show("Curso actualizado exitosamente.");
                    CargarCursos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el curso.");
                }
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            if (dgvCursos.CurrentRow != null)
            {
                var result = MessageBox.Show("¿Está seguro que desea eliminar este curso?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int cursoID = Convert.ToInt32(dgvCursos.CurrentRow.Cells[0].Value);
                    if (cursoDatos.EliminarCurso(cursoID))
                    {
                        MessageBox.Show("Curso eliminado exitosamente.");
                        CargarCursos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el curso.");
                    }
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreCurso.Text = string.Empty;
            txtDescripcionCurso.Text = string.Empty;
            txtCreditosCurso.Text = string.Empty;
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                txtNombreCurso.Text = dgvCursos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionCurso.Text = dgvCursos.CurrentRow.Cells[2].Value.ToString();
                txtCreditosCurso.Text = dgvCursos.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}

