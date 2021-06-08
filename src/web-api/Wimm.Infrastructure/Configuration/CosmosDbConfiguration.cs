using Wimm.Infrastructure.Configuration.Interfaces;

namespace Wimm.Infrastructure.Configuration
{
    public class CosmosDbConfiguration : ICosmosDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CarContainerName { get; set; }
        public string CarContainerPartitionKeyPath { get; set; }
        public string EnquiryContainerName { get; set; }
        public string EnquiryContainerPartitionKeyPath { get; set; }
        public string CarReservationContainerName { get; set; }
        public string CarReservationPartitionKeyPath { get; set; }
    }
}
