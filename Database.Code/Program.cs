using Database.Data;
using Database.Data.Models;
using Database.Data.Repository;
using Database.Data.Service.Contact;
using Database.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Database.Code
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            // calls the Run method in App, which is replacing Main
            serviceProvider.GetService<App>().Run();
            
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            var config = LoadConfiguration();

            var connection = config.GetConnectionString("Default");

            // Configure services
            services.AddDbContext<FundMatixTestDatabaseContext>(options => options.UseSqlServer(connection));
            services.AddScoped<DbContext, FundMatixTestDatabaseContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Contract
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IRepository<Contacts>, Repository<Contacts>>();

            services.AddSingleton(config);

            // required to run the application
            services.AddTransient<App>();

            return services;
        }

        public static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
