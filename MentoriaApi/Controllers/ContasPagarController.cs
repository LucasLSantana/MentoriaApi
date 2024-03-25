using MentoriaApi.Entidade;
using MentoriaApi.Interface.Service;
using MentoriaApi.Resource;
using Microsoft.AspNetCore.Mvc;

namespace MentoriaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasPagarController(IContasPagarService service) : ControllerBase
    {
        [HttpGet]
        [Route("ConsultaTodaContasPagar")]
        public async Task<ActionResult<IEnumerable<ContasPagar>>> GetContasPagarAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                var conta = await service.GetContasPagarAsync();
                return Ok(conta);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPost]
        [Route("IntegraContasPagar")]
        public async Task<ActionResult> IntegraContasPagarAsync(CancellationToken ct, ContasPagar entity)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.IntegraContasPagarAsync(entity);
                return Ok(Messages.OperacaoRealizadaComSucesso);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpDelete]
        [Route("DeletaContasPagar")]
        public async Task<ActionResult> DeletaContasPagarAsync(CancellationToken ct, int id)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.DeletaContaPagarAsync(id);
                return Ok(Messages.OperacaoRealizadaComSucesso);
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
        public async Task<ActionResult> IntegraListaContasPagarAsync(CancellationToken ct, List<ContasPagar> listContasPagar)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.IntegraListaContasPagarAsync(listContasPagar);
                return Ok(Messages.OperacaoRealizadaComSucesso);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpPut]
        [Route("AtualizaListaContasPagarValor")]
        public async Task<ActionResult> AtualizaValorContasPagarAsync(CancellationToken ct, List<int> listId, double valorAtualizar)
        {
            try
            {
                await Task.Delay(5000, ct);
                await service.AtualizaValorContasPagarAsync(listId, valorAtualizar);
                return Ok(Messages.OperacaoRealizadaComSucesso);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }

        [HttpGet]
        [Route("SomaContasPagar")]
        public async Task<ActionResult> ValorContasPagarAsync(CancellationToken ct)
        {
            try
            {
                await Task.Delay(5000, ct);
                var valor = await service.ValorContasPagarAsync();
                return Ok(valor);
            }
            catch (TaskCanceledException cte)
            {
                return BadRequest(cte.Message);
            }
        }
    }
}