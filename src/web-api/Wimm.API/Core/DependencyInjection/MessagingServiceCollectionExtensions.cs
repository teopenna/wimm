using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wimm.Infrastructure.Configuration.Interfaces;

namespace Wimm.API.Core.DependencyInjection
{
    public static class MessagingServiceCollectionExtensions
    {
        public static IServiceCollection AddMessagingServices(this IServiceCollection services)
        {
            //services.TryAddSingleton(implementationFactory =>
            //{
            //    var serviceBusConfiguration = implementationFactory.GetRequiredService<IMessagingServiceConfiguration>();
            //    var serviceBusClient = new ServiceBusClient(serviceBusConfiguration.ListenAndSendConnectionString);
            //    var serviceBusSender = serviceBusClient.CreateSender(serviceBusConfiguration.QueueName);
            //    return serviceBusSender;
            //});

            //services.AddSingleton<ICarReservationMessagingService, CarReservationMessagingService>();

            return services;
        }
    }
}
