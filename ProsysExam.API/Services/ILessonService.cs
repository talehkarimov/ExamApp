using ProsysExam.API.Dtos;

namespace ProsysExam.API.Services
{
    public interface ILessonService
    {
        Task<IEnumerable<LessonDto>> GetAll();
        Task<LessonDto> GetById(int id);
        Task Add(LessonDto lessonDto);
        Task Update(LessonDto lessonDto);
        Task Delete(int id);
    }
}
