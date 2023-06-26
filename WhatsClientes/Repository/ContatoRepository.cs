using Microsoft.EntityFrameworkCore;
using WhatsClientes.Data;
using WhatsClientes.Model;

namespace WhatsClientes.Repository;

public class ContatoRepository : IContatoRepository
{
    private readonly WhatsContext _whatsContext;

    public ContatoRepository(WhatsContext whatsContext)
    {
        _whatsContext = whatsContext;
    }

    public async Task<IEnumerable<Contato>> ListarContatos()
    {
        return await _whatsContext.Contatos
            .OrderBy(o => o.Nome.ToLower())
            .ToListAsync();
    }

    public async Task<Contato> ListarContatoId(int id)
    {
        var contato = await _whatsContext.Contatos
               .Where(w => w.Id == id)
               .FirstOrDefaultAsync();

        if (contato is not null)
        {
            return contato;
        }
        else
        {
            return new Contato();
        }
    }

    public async Task Inserir(Contato contato)
    {
        try
        {
            if (contato is null)
            {
                throw new Exception("Contato vazio");
            }

            _whatsContext.Contatos.Add(contato);
            await _whatsContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Alterar(Contato contato)
    {
        try
        {
            if (contato is null)
            {
                throw new Exception("Contato vazio");
            }

            _whatsContext.Contatos.Entry(contato).State = EntityState.Modified;
            await _whatsContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task Excluir(int id)
    {
        Contato contato = await ListarContatoId(id);
        try
        {
            _whatsContext.Remove(contato);
            await _whatsContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
