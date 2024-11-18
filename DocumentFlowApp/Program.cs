using DataAccess;
using DocumentFlowApp.DataAccess.Repositories;
using DocumentFlowApp.UI.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DocumentFlowApp.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace DocumentFlowApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceProvider = CreateHostBuilder().Build().Services;

            var context = ServiceProvider.GetService<AppDbContext>();
            context.Database.Migrate();
            Application.Run(ServiceProvider.GetService<Main>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(c => c.AddJsonFile("appsettings.json"))
            .ConfigureServices((context, services) => {
                services.AddSingleton<IFormFactory, FormFactory>();
                var forms = typeof(Program).Assembly
                    .GetTypes()
                    .Where(t => t.BaseType == typeof(Form))
                    .ToList();

                forms.ForEach(form =>
                {
                    services.AddTransient(form);
                });

                services.AddSingleton<MinioService>();

                services.AddDbContext<AppDbContext>(ServiceLifetime.Scoped);

                services.AddScoped<UserRepository>();
                services.AddScoped<NotificationRepository>();
                services.AddScoped<FilesRepository>();
                services.AddScoped<RequestRepository>();
            });
        }
    }
}