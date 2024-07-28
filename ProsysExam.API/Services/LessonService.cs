using AutoMapper;
using ProsysExam.API.Dtos;
using ProsysExam.API.Models;
using ProsysExam.API.Repositories;

namespace ProsysExam.API.Services
{
    public class LessonService : ILessonService
    {
        private readonly IRepository<Lesson> _repository;
        private readonly IMapper _mapper;

        public LessonService(IRepository<Lesson> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LessonDto>> GetAll()
        {
            var lessons = await _repository.GetAll();
            return _mapper.Map<IEnumerable<LessonDto>>(lessons);
        }

        public async Task<LessonDto> GetById(int id)
        {
            var lesson = await _repository.GetById(id);
            return _mapper.Map<LessonDto>(lesson);
        }

        public async Task Add(LessonDto lessonDto)
        {
            var lesson = _mapper.Map<Lesson>(lessonDto);
            await _repository.Add(lesson);
        }

        public async Task Update(LessonDto lessonDto)
        {
            var lesson = _mapper.Map<Lesson>(lessonDto);
            await _repository.Update(lesson);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
