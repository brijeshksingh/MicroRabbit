using MicroRabbit.Domain.Core.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Data.Context;
using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.CommandHandlers;

namespace MicroRabbit.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
            //domain banking command
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();


            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository,AccountRepository>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
