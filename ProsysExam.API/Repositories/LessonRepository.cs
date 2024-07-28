using Microsoft.EntityFrameworkCore;
using ProsysExam.API.Data;
using ProsysExam.API.Models;

namespace ProsysExam.API.Repositories
{
    public class LessonRepository : IRepository<Lesson>
    {
        private readonly ExamDbContext _context;

        public LessonRepository(ExamDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lesson>> GetAll()
        {
            return await _context.Lessons.ToListAsync();
        }

        public async Task<Lesson> GetById(int id)
        {
            return await _context.Lessons.FindAsync(id);
        }

        public async Task Add(Lesson entity)
        {
            await _context.Lessons.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Lesson entity)
        {
            _context.Lessons.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var lesson = await _context.Lessons.FindAsync(id);
            if (lesson != null)
            {
                _context.Lessons.Remove(lesson);
                await _context.SaveChangesAsync();
            }
        }
    }
}
