using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Data;
using ProsysExam.API.Models;

namespace ProsysExam.API.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly ExamDbContext _context;

        public StudentRepository(ExamDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task Add(Student entity)
        {
            await _context.Students.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Student entity)
        {
            _context.Students.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
        }
    }
}
