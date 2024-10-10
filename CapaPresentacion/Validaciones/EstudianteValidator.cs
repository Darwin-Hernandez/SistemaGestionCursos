using FluentValidation;
using SistemaGestionCursos.CapaEntidad;

namespace SistemaGestionCursos.CapaPresentacion.Validaciones
{
    public class EstudianteValidator : AbstractValidator<Estudiante>
    {
        public EstudianteValidator()
        {
            RuleFor(e => e.Nombre)
                .NotEmpty().WithMessage("El nombre del estudiante es obligatorio.")
                .Length(1, 50).WithMessage("El nombre del estudiante debe tener entre 1 y 50 caracteres.");

            RuleFor(e => e.Apellido)
                .NotEmpty().WithMessage("El apellido del estudiante es obligatorio.")
                .Length(1, 50).WithMessage("El apellido del estudiante debe tener entre 1 y 50 caracteres.");

            RuleFor(e => e.Correo)
                .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
                .EmailAddress().WithMessage("El correo electrónico no es válido.");
        }
    }
}
