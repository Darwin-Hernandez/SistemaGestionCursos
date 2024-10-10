using FluentValidation;
using SistemaGestionCursos.CapaEntidad;
using System;

namespace SistemaGestionCursos.CapaPresentacion.Validaciones
{
    public class InscripcionValidator : AbstractValidator<Inscripcion>
    {
        public InscripcionValidator()
        {
            RuleFor(x => x.EstudianteID)
                .NotEmpty().WithMessage("El ID del estudiante es obligatorio.");

            RuleFor(x => x.CursoID)
                .NotEmpty().WithMessage("El ID del curso es obligatorio.");

            RuleFor(x => x.FechaInscripcion)
                .NotEmpty().WithMessage("La fecha de inscripción es obligatoria.")
                .Must(date => date >= new DateTime(1753, 1, 1) && date <= new DateTime(9999, 12, 31))
                .WithMessage("La fecha debe estar entre el 1/1/1753 y el 31/12/9999.");
        }
    }

}
