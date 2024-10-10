using System;
using System.Linq;
using System.Windows.Forms;
using FluentValidation.Results;
using SistemaGestionCursos.CapaDatos;
using SistemaGestionCursos.CapaEntidad;
using SistemaGestionCursos.CapaPresentacion.Validaciones;

namespace SistemaGestionCursos.CapaPresentacion
{
    public partial class frmGestionEstudiantes : Form
    {
        private readonly EstudianteDatos estudianteDatos = new EstudianteDatos();

        public frmGestionEstudiantes()
        {
            InitializeComponent();
            CargarEstudiantes();
            dgvEstudiantes.CellClick += dgvEstudiantes_CellClick;
        }

        private void CargarEstudiantes()
        {
            dgvEstudiantes.DataSource = estudianteDatos.ObtenerEstudiantes();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiante
            {
                Nombre = txtNombreEstudiante.Text,
                Apellido = txtApellidoEstudiante.Text,
                Correo = txtCorreoEstudiante.Text
            };

            var validator = new EstudianteValidator();
            var result = validator.Validate(estudiante);

            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => error.ErrorMessage)));
                return; 
            }

            if (estudianteDatos.AgregarEstudiante(estudiante))
            {
                MessageBox.Show("Estudiante agregado exitosamente.");
                CargarEstudiantes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el estudiante.");
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                var estudiante = new Estudiante
                {
                    EstudianteID = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[0].Value),
                    Nombre = txtNombreEstudiante.Text,
                    Apellido = txtApellidoEstudiante.Text,
                    Correo = txtCorreoEstudiante.Text
                };

                var validator = new EstudianteValidator();
                var result = validator.Validate(estudiante);

                if (!result.IsValid)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result.Errors.Select(error => error.ErrorMessage)));
                    return; 
                }

                if (estudianteDatos.ActualizarEstudiante(estudiante))
                {
                    MessageBox.Show("Estudiante actualizado exitosamente.");
                    CargarEstudiantes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el estudiante.");
                }
            }
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.CurrentRow != null)
            {
                var estudianteID = Convert.ToInt32(dgvEstudiantes.CurrentRow.Cells[0].Value);
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este estudiante?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (estudianteDatos.EliminarEstudiante(estudianteID))
                    {
                        MessageBox.Show("Estudiante eliminado exitosamente.");
                        CargarEstudiantes();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el estudiante.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estudiante para eliminar.");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreEstudiante.Text = string.Empty;
            txtApellidoEstudiante.Text = string.Empty;
            txtCorreoEstudiante.Text = string.Empty;
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[1].Value.ToString();
                txtApellidoEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[2].Value.ToString();
                txtCorreoEstudiante.Text = dgvEstudiantes.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}

