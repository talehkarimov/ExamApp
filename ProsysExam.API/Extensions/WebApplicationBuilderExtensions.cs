using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ProsysExam.API.Data;
using ProsysExam.API.Mappings;
using ProsysExam.API.Models;
using ProsysExam.API.Repositories;
using ProsysExam.API.Services;
using ProsysExam.API.Validators;

namespace ProsysExam.API.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            // Add DbContext
            builder.Services.AddDbContext<ExamDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Register Repositories
            builder.Services.AddScoped<IRepository<Lesson>, LessonRepository>();
            builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
            builder.Services.AddScoped<IRepository<Exam>, ExamRepository>();

            // Register Services
            builder.Services.AddScoped<ILessonService, LessonService>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<IExamService, ExamService>();

            // Configure AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            // Configure FluentValidation
            builder.Services.AddValidatorsFromAssemblyContaining<StudentDtoValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<ExamDtoValidator>();
        }
    }
}
