using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wimm.Infrastructure.Configuration.Interfaces;

namespace Wimm.API.Core.DependencyInjection
{
    public static class DataServiceCollectionExtensions
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            //services.TryAddSingleton(implementationFactory =>
            //{
            //    var cosmoDbConfiguration = implementationFactory.GetRequiredService<ICosmosDbConfiguration>();
            //    CosmosClient cosmosClient = new CosmosClient(cosmoDbConfiguration.ConnectionString);
            //    CosmosDatabase database = cosmosClient.CreateDatabaseIfNotExistsAsync(cosmoDbConfiguration.DatabaseName)
            //                                           .GetAwaiter()
            //                                           .GetResult();
            //    database.CreateContainerIfNotExistsAsync(
            //        cosmoDbConfiguration.CarContainerName,
            //        cosmoDbConfiguration.CarContainerPartitionKeyPath,
            //        400)
            //        .GetAwaiter()
            //        .GetResult();

            //    database.CreateContainerIfNotExistsAsync(
            //        cosmoDbConfiguration.EnquiryContainerName,
            //             cosmoDbConfiguration.EnquiryContainerPartitionKeyPath,
            //        400)
            //        .GetAwaiter()
            //        .GetResult();

            //    database.CreateContainerIfNotExistsAsync(
            //        cosmoDbConfiguration.CarReservationContainerName,
            //             cosmoDbConfiguration.CarReservationPartitionKeyPath,
            //        400)
            //        .GetAwaiter()
            //        .GetResult();

            //    return cosmosClient;
            //});

            //services.AddSingleton<IDataRepository<Car>, CarRepository>();
            //services.AddSingleton<IDataRepository<Enquiry>, EnquiryRepository>();
            //services.AddSingleton<ICarReservationRepository, CarReservationRepository>();

            //services.AddSingleton<ICarReservationService, CarReservationService>();

            return services;
        }
    }
}
