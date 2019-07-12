using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Data.Context;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository,AccountRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
