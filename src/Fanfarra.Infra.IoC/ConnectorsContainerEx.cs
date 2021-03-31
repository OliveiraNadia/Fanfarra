using Fanfarra.Domain.Connectors;
using Fanfarra.Infra.Data.Connectors;
using Microsoft.Extensions.DependencyInjection;

namespace Fanfarra.Infra.IoC
{
    public static class ConnectorsContainerEx
    {        
        public static IServiceCollection AddConnectors(this IServiceCollection services)
        {
            services
                .AddTransient<IFundosConnector, FundosConnector>()
                .AddTransient<IRendaFixaConnector, RendaFixaConnector>()
                .AddTransient<ITesouroDiretoConnector, TesouroDiretoConnector>();
            return services;
        }
    }
}
