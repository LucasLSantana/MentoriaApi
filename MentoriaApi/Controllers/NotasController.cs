using MentoriaApi.Entidade;
using MentoriaApi.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace MentoriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController(INotasService service) : Controller
    {
        [HttpGet]
        [Route("ConsultaTodaNotas")]
        public async Task<ActionResult<IEnumerable<Notas>>> GetNotasAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                var notas = await service.GetNotasAsync();
                return Created();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }
    }
}