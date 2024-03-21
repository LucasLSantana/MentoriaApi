using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MentoriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagarController(IContaPagarService service) : ControllerBase
    {
        [HttpGet]
        [Route("ConsultaTodaContasPagar")]
        public async Task<ActionResult<IEnumerable<ContaPagar>>> GetContaPagar()
        {
            var conta = await service.GetContaPagar();
            return Ok(conta);
        }

        [HttpPost]
        [Route("IntegraContaPagar")]
        public async Task<ActionResult<bool>> IntegraContasPagar(ContaPagar entity)
        {
            return await service.IntegraContasPagar(entity);
        }

        [HttpDelete]
        [Route("DeletaContaPagar")]
        public void DeletaContasPagar(int id)
        {
            service.DeletaContaPagar(id);
        }


        [HttpGet]
        [Route("ContagemContasPagar")]
        public Task<IAsyncEnumerable<int>> ContagemContasPagar()
        {
            return Task.FromResult(service.ContagemContasPagar());
        }
    }
}