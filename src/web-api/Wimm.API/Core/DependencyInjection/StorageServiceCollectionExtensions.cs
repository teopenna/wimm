using System;
using Microsoft.Extensions.DependencyInjection;
using Wimm.Infrastructure.Configuration.Interfaces;

namespace Wimm.API.Core.DependencyInjection
{
    public static class StorageServiceCollectionExtensions
    {
        public static IServiceCollection AddStorageServices(this IServiceCollection services)
        {
            //var serviceProvider = services.BuildServiceProvider();

            //var storageConfiguration = serviceProvider.GetRequiredService<IBlobStorageServiceConfiguration>();

            //services.AddSingleton(factory => new BlobServiceClient(storageConfiguration.ConnectionString));
            //services.AddSingleton<IBlobStorageService, BlobStorageService>();
            return services;
        }
    }
}
