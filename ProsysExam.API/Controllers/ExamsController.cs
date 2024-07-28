using Microsoft.AspNetCore.Mvc;
using ProsysExam.API.Dtos;
using ProsysExam.API.Services;

namespace ProsysExam.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExamsController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var exams = await _examService.GetAll();
            return Ok(exams);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var exam = await _examService.GetById(id);
            if (exam == null)
            {
                return NotFound();
            }
            return Ok(exam);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ExamDto examDto)
        {
            await _examService.Add(examDto);
            return CreatedAtAction(nameof(GetById), new { id = examDto.Id }, examDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ExamDto examDto)
        {
            if (id != examDto.Id)
            {
                return BadRequest();
            }
            await _examService.Update(examDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _examService.Delete(id);
            return NoContent();
        }
    }

}
