using Microsoft.Extensions.DependencyInjection;
using WhatsClientes.Data;
using WhatsClientes.Repository;

namespace WhatsClientes
{
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
            var Sco = serviceSco.GetService<IContatoRepository>();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmContato(Sco));
        }
    }
}