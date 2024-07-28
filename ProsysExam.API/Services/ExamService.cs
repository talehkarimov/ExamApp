using AutoMapper;
using ProsysExam.API.Dtos;
using ProsysExam.API.Models;
using ProsysExam.API.Repositories;

namespace ProsysExam.API.Services
{
    public class ExamService : IExamService
    {
        private readonly IRepository<Exam> _examRepository;
        private readonly IMapper _mapper;

        public ExamService(IRepository<Exam> examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ExamDto>> GetAll()
        {
            var exams = await _examRepository.GetAll();
            return _mapper.Map<IEnumerable<ExamDto>>(exams);
        }

        public async Task<ExamDto> GetById(int id)
        {
            var exam = await _examRepository.GetById(id);
            return _mapper.Map<ExamDto>(exam);
        }

        public async Task Add(ExamDto examDto)
        {
            var exam = _mapper.Map<Exam>(examDto);
            await _examRepository.Add(exam);
        }

        public async Task Update(ExamDto examDto)
        {
            var exam = _mapper.Map<Exam>(examDto);
            await _examRepository.Update(exam);
        }

        public async Task Delete(int id)
        {
            await _examRepository.Delete(id);
        }
    }
}
