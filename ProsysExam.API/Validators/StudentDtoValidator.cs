using FluentValidation;
using ProsysExam.API.Dtos;

namespace ProsysExam.API.Validators
{
    public class StudentDtoValidator : AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(x => x.Number)
                .NotEmpty().WithMessage("Student number is required.")
                .Length(5).WithMessage("Student number must be exactly 5 characters.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MaximumLength(30).WithMessage("Surname must not exceed 30 characters.");

            RuleFor(x => x.Class)
                .InclusiveBetween(1, 99).WithMessage("Class must be between 1 and 99.");
        }
    }
}
