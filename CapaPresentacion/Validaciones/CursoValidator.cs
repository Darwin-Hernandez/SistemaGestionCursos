using FluentValidation;
using SistemaGestionCursos.CapaEntidad;

namespace SistemaGestionCursos.CapaPresentacion.Validaciones
{
    public class CursoValidator : AbstractValidator<Curso>
    {
        public CursoValidator()
        {
            RuleFor(c => c.Nombre)
                .NotEmpty().WithMessage("El nombre del curso es obligatorio.")
                .Length(1, 100).WithMessage("El nombre del curso debe tener entre 1 y 100 caracteres.");

            RuleFor(c => c.Descripcion)
                .NotEmpty().WithMessage("La descripción del curso es obligatoria.")
                .Length(1, 500).WithMessage("La descripción del curso debe tener entre 1 y 500 caracteres.");
        }
    }
}
