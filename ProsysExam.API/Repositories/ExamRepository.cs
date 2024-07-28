using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Data;
using ProsysExam.API.Models;

namespace ProsysExam.API.Repositories
{
    public class ExamRepository : IRepository<Exam>
    {
        private readonly ExamDbContext _context;

        public ExamRepository(ExamDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Exam>> GetAll()
        {
            return await _context.Exams.ToListAsync();
        }

        public async Task<Exam> GetById(int id)
        {
            return await _context.Exams.FindAsync(id);
        }

        public async Task Add(Exam entity)
        {
            await _context.Exams.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Exam entity)
        {
            _context.Exams.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            if (exam != null)
            {
                _context.Exams.Remove(exam);
                await _context.SaveChangesAsync();
            }
        }
    }
}
