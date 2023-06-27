using WhatsClientes.Model;

namespace WhatsClientes.Repository;

public interface IContatoRepository
{
    Task<IEnumerable<Contato>> ListarContatos(string pesquisa);
    Task<Contato> ListarContatoId(int id);
    Task Inserir(Contato contato);
    Task Alterar(Contato contato);
    Task Excluir(int id);
}
