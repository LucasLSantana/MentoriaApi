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
        public async Task<ActionResult<IEnumerable<ContaPagar>>> GetContaPagarAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                var conta = await service.GetContaPagarAsync();
                return Ok(conta);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPost]
        [Route("IntegraContaPagar")]
        public async Task<ActionResult<bool>> IntegraContasPagarAsync(ContaPagar entity, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                return await service.IntegraContasPagarAsync(entity);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpDelete]
        [Route("DeletaContaPagar")]
        public async Task<ActionResult> DeletaContasPagarAsync(int id, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.DeletaContaPagarAsync(id);
                return Ok();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }


        [HttpGet]
        [Route("ContagemContasPagar")]
        public async Task<ActionResult<int>> ContagemContasPagarAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                return await service.ContagemContasPagarAsync();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPost]
        [Route("IntegraListaContasPagar")]
        public async Task<ActionResult> IntegraListaContasPagarAsync(List<ContaPagar> listContasPagar, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.IntegraListaContasPagarAsync(listContasPagar);
                return Ok();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }
    }
}