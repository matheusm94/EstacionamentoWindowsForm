using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaEstacionamento.Data;
using SistemaEstacionamento.Repository;
using SistemaEstacionamento.Service;

namespace EstacionamentoWindowsForms
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Host.CreateDefaultBuilder()
             .ConfigureServices((context, services) =>
             {
                 services.AddSingleton<IDatabaseConfig, DatabaseConfig>();
                 services.AddTransient<IEstacionamentoRepository, EstacionamentoRepository>();
                 services.AddTransient<IEstacionamentoService, EstacionamentoService>();
             })
             .Build();
            var estacionamentoService = host.Services.GetRequiredService<IEstacionamentoService>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormPrincipal(estacionamentoService));
            //using IHost host = CreateHostBuilder().Build();

        }
    }
}