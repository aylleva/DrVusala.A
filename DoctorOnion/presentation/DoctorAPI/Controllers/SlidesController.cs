using Doctor.Application.Dtos.Slide;
using Doctor.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidesController : ControllerBase
    {
        private readonly ISlidesService _service;

        public SlidesController(ISlidesService service)
        {
         _service = service;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetSlides()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetById(int Id)
        {
            if (Id < 0) throw new Exception("Not Found");
            return Ok(await _service.GetByIdAsync(Id));
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Create([FromForm]CreateSlideDto slideDto)
        {
           await _service.CreateAsync(slideDto);
            return Created();
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Update(int Id,[FromForm] UpdateSlideDto slideDto)
        {
             await _service.UpdateAsync(Id,slideDto);
            return NoContent();
        }
        [HttpDelete("[Action]")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _service.DeleteAsync(Id);
            return NoContent();
        }
    }
}
