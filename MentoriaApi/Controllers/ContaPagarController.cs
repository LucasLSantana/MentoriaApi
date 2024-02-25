using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagarController : ControllerBase
    {
        private readonly IContaPagarService _service;

        public ContaPagarController(IContaPagarService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContaPagar>>> GetContaPagar()
        {
            var conta = await _service.GetContaPagar();
            return Ok(conta);
        }
    }
}