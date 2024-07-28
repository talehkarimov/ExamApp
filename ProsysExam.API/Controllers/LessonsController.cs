using Microsoft.AspNetCore.Mvc;
using ProsysExam.API.Dtos;
using ProsysExam.API.Services;

namespace ProsysExam.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonsController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonsController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var lessons = await _lessonService.GetAll();
            return Ok(lessons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var lesson = await _lessonService.GetById(id);
            if (lesson == null)
            {
                return NotFound();
            }
            return Ok(lesson);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LessonDto lessonDto)
        {
            await _lessonService.Add(lessonDto);
            return CreatedAtAction(nameof(GetById), new { id = lessonDto.Id }, lessonDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] LessonDto lessonDto)
        {
            if (id != lessonDto.Id)
            {
                return BadRequest();
            }
            await _lessonService.Update(lessonDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _lessonService.Delete(id);
            return NoContent();
        }
    }

}
