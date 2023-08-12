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

    public async Task<IEnumerable<Contato>> ListarContatos(string pesquisa)
    {
        return await _whatsContext.Contatos
            .Where(w => w.Nome.ToUpper().Contains(pesquisa.ToUpper()))
            .OrderBy(o => o.Nome.ToUpper())
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
            ValidacaoContato(contato);

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
            Contato contato1 = await ListarContatoId(contato.Id);
            ValidacaoContato(contato1);

            if (contato1 is not null)
            {
                _whatsContext.Contatos.Entry(contato1).CurrentValues.SetValues(contato);
                await _whatsContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static void ValidacaoContato(Contato contato)
    {
        if (contato is null)
        {
            throw new Exception("Contato vazio");
        }
        if (contato.Nome.Length <= 0)
        {
            throw new Exception("Nome vazio");
        }
        if (contato.Telefone == "(  )     -" || contato.Telefone == "(  )       -")
        {
            throw new Exception("Numero de Telefone Vazio");
        }
        if (contato.DDI == string.Empty)
        {
            throw new Exception("DDI Vazio");
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
