using System.ComponentModel.DataAnnotations;

namespace WhatsClientes.Model;

public class Contato
{
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; } = string.Empty;
    [Required]
    public string DDI { get; set; } = string.Empty;
    [Required]
    public string Telefone { get; set; } = string.Empty;


}
