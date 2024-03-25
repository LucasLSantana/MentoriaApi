using MentoriaApi.Entidade;
using MentoriaApi.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace MentoriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasReceberController(IContasReceberService service) : ControllerBase
    {
        [HttpGet]
        [Route("ConsultaTodaContasReceber")]
        public async Task<ActionResult<IEnumerable<ContasReceber>>> GetContasReceberAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                var conta = await service.GetContasReceberAsync();
                return Ok(conta);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPost]
        [Route("IntegraContasReceber")]
        public async Task<ActionResult<bool>> IntegraContasReceberAsync(ContasReceber entity, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                return await service.IntegraContasReceberAsync(entity);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpDelete]
        [Route("DeletaContasReceber")]
        public async Task<ActionResult> DeletaContasReceberAsync(int id, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.DeletaContaReceberAsync(id);
                return Ok();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }


        [HttpGet]
        [Route("ContagemContasReceber")]
        public async Task<ActionResult<int>> ContagemContasReceberAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                return await service.ContagemContasReceberAsync();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPost]
        [Route("IntegraListaContasReceber")]
        public async Task<ActionResult> IntegraListaContasReceberAsync(List<ContasReceber> listContasPagar, CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.IntegraListaContasReceberAsync(listContasPagar);
                return Ok();
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }
    }
}