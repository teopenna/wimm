using System;
using Azure.Cosmos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Wimm.Core.Entities;
using Wimm.Core.Interfaces;
using Wimm.Infrastructure.Configuration.Interfaces;
using Wimm.Infrastructure.Data;

namespace Wimm.API.Core.DependencyInjection
{
    public static class DataServiceCollectionExtensions
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.TryAddSingleton(implementationFactory =>
            {
                var cosmoDbConfiguration = implementationFactory.GetRequiredService<ICosmosDbConfiguration>();
                CosmosClient cosmosClient = new(cosmoDbConfiguration.ConnectionString);
                CosmosDatabase database = cosmosClient.CreateDatabaseIfNotExistsAsync(cosmoDbConfiguration.DatabaseName)
                                                       .GetAwaiter()
                                                       .GetResult();
                database.CreateContainerIfNotExistsAsync(
                    cosmoDbConfiguration.AccountContainerName,
                    cosmoDbConfiguration.AccountContainerPartitionKeyPath,
                    400)
                    .GetAwaiter()
                    .GetResult();

                //database.CreateContainerIfNotExistsAsync(
                //    cosmoDbConfiguration.EnquiryContainerName,
                //         cosmoDbConfiguration.EnquiryContainerPartitionKeyPath,
                //    400)
                //    .GetAwaiter()
                //    .GetResult();

                //database.CreateContainerIfNotExistsAsync(
                //    cosmoDbConfiguration.CarReservationContainerName,
                //         cosmoDbConfiguration.CarReservationPartitionKeyPath,
                //    400)
                //    .GetAwaiter()
                //    .GetResult();

                return cosmosClient;
            });

            services.AddSingleton<IDataRepository<Account>, AccountRepository>();
            //services.AddSingleton<IDataRepository<Enquiry>, EnquiryRepository>();
            //services.AddSingleton<ICarReservationRepository, CarReservationRepository>();

            //services.AddSingleton<ICarReservationService, CarReservationService>();

            return services;
        }
    }
}
