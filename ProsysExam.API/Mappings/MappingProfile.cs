using AutoMapper;
using ProsysExam.API.Dtos;
using ProsysExam.API.Models;

namespace ProsysExam.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lesson, LessonDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Exam, ExamDto>().ReverseMap();
        }
    }
}
