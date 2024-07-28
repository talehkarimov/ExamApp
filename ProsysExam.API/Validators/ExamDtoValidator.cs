using FluentValidation;
using ProsysExam.API.Dtos;

namespace ProsysExam.API.Validators
{
    public class ExamDtoValidator : AbstractValidator<ExamDto>
    {
        public ExamDtoValidator()
        {
            RuleFor(x => x.LessonCode)
                .NotEmpty().WithMessage("Lesson code is required.")
                .Length(3).WithMessage("Lesson code must be exactly 3 characters.");

            RuleFor(x => x.StudentNumber)
                .NotEmpty().WithMessage("Student number is required.")
                .InclusiveBetween(10000, 99999).WithMessage("Student number must be exactly 5 digits.");

            RuleFor(x => x.ExamDate)
                .NotEmpty().WithMessage("Exam date is required.")
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Exam date cannot be in the future.");

            RuleFor(x => x.Price)
                .InclusiveBetween(0, 9).WithMessage("Price must be between 0 and 9.");
        }
    }
}
