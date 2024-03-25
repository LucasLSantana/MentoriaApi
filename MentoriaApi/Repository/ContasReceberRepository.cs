using MentoriaApi.Data;
using MentoriaApi.Entidade;
using MentoriaApi.Interface;
using MentoriaApi.Interface.Repository;
using Microsoft.EntityFrameworkCore;

namespace MentoriaApi.Repository;

public class ContasReceberRepository(MentoriaContext context) : IContasReceberRepository
{
    public async Task<IEnumerable<ContasReceber>> GetContasReceberAsync()
    {
        return await context.ContasReceber.ToListAsync();
    }

    public async Task<bool> IntegraContasReceberAsync(ContasReceber entity)
    {
        await context.ContasReceber.AddAsync(entity);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task IntegraListaContasReceberAsync(IEnumerable<ContasReceber> listContaReceber)
    {
        await using var transaction = await context.Database.BeginTransactionAsync();
        await context.AddRangeAsync(listContaReceber);
        await context.SaveChangesAsync();
        await transaction.CommitAsync();
    }

    public async Task DeletaContasReceberAsync(int id)
    {
        var conta = await context.ContasReceber.FirstOrDefaultAsync(s => s.ContasReceberId == id);
        if (conta != null) context.Remove(conta);
    }

    public async Task<int> ContagemContasReceberAsync()
    {
        var listContaReceber = await context.ContasReceber.ToListAsync();
        return listContaReceber.Count;
    }

    public async Task<double> ValorContasReceberAsync()
    {
        var listContaReceber = await context.ContasReceber.ToListAsync();
        return listContaReceber.Sum(s => s.Valor);
    }
}