using Azure.Cosmos;
using Wimm.Core.Entities;
using Wimm.Infrastructure.Configuration.Interfaces;

namespace Wimm.Infrastructure.Data
{
    public class AccountRepository : CosmosDbDataRepository<Account>
    {
        public AccountRepository(ICosmosDbConfiguration cosmosDbConfiguration,
            CosmosClient client) : base(cosmosDbConfiguration, client)
        {
        }

        public override string ContainerName => _cosmosDbConfiguration.AccountContainerName;
    }
}
