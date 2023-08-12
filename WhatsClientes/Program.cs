using Microsoft.Extensions.DependencyInjection;
using WhatsClientes.Data;
using WhatsClientes.Repository;

namespace WhatsClientes;

<<<<<<< HEAD
            var service = new ServiceCollection();
            service.AddDbContext<WhatsContext>();
            service.AddScoped<IContatoRepository, ContatoRepository>();
            var serviceSco = service.BuildServiceProvider();
            var Sco = serviceSco.GetService<IContatoRepository>();

=======
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        var service = new ServiceCollection();
        service.AddDbContext<WhatsContext>();
        service.AddScoped<IContatoRepository, ContatoRepository>();
        var serviceSco = service.BuildServiceProvider();
        var sco = serviceSco.GetService<IContatoRepository>();

        if (sco is not null)
        {
>>>>>>> 8545bed98d79c518d6e6ef48cbc1ce80143760dd
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmContato(sco));
        }
    }
}