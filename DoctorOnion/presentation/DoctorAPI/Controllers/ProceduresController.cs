using Doctor.Application.Dtos.Procedure;
using Doctor.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProceduresController : ControllerBase
    {
        private readonly IProceduresService _service;

        public ProceduresController(IProceduresService service)
        {
            _service = service;
        }

        [HttpGet("[Action]")]
        public async Task<IActionResult> GetProcedures()
        {
            return Ok(await _service.GetAllAsync());
        }
        [HttpGet("[Action]")]
        public async Task<IActionResult> GetItem(int id)
        {
            if (id < 1) throw new Exception("Not Found");
            return Ok(await _service.GetByIdAsync(id));
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> Create([FromForm]CreateProcedureDto prodto)
        {
            await _service.CreateAsync(prodto);
            return Created();
        }
        [HttpPost("[Action]")]
        public async Task<IActionResult> Update(int Id,UpdateProcedureDto prodto)
        {
            if (Id < 1) throw new Exception("Not Found");
            await _service.UpdateAsync(Id,prodto);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            if (Id < 1) throw new Exception("Not Found");
            await _service.DeleteAsync(Id);
            return NoContent();
        }
    }
}
