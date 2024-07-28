using ProsysExam.API.Dtos;

namespace ProsysExam.API.Services
{
    public interface IExamService
    {
        Task<IEnumerable<ExamDto>> GetAll();
        Task<ExamDto> GetById(int id);
        Task Add(ExamDto examDto);
        Task Update(ExamDto examDto);
        Task Delete(int id);
    }
}
