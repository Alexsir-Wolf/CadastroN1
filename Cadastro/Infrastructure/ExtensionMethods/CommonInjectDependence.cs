using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.ExtensionMethods
{
    public static class CommonInjectDependence
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddTransient<Interfaces.IClientViewModelService, Services.ClientViewModelService>();


            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<Domain.Interfaces.ICategoryRepository, Data.Repositories.CategoryRepository>();
            services.AddTransient<Domain.Interfaces.IClientRepository, Data.Repositories.ClientRepository>();
            services.AddTransient<Domain.Interfaces.IProductRepository, Data.Repositories.ProductRepository>();


            return services;
        }
    }
}
