using ProsysExam.API.Dtos;

namespace ProsysExam.API.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetAll();
        Task<StudentDto> GetById(int id);
        Task Add(StudentDto studentDto);
        Task Update(StudentDto studentDto);
        Task Delete(int id);
    }
}
