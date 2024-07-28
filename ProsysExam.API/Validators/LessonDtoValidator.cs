using FluentValidation;
using ProsysExam.API.Dtos;

namespace ProsysExam.API.Validators
{
    public class LessonDtoValidator : AbstractValidator<LessonDto>
    {
        public LessonDtoValidator()
        {
            RuleFor(x => x.LessonCode).NotEmpty().Length(3);
            RuleFor(x => x.LessonName).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Class).InclusiveBetween(1, 99);
            RuleFor(x => x.TeacherFirstName).NotEmpty().MaximumLength(20);
            RuleFor(x => x.TeacherLastName).NotEmpty().MaximumLength(20);
        }
    }
}
