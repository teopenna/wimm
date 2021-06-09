namespace Wimm.Infrastructure.Configuration.Interfaces
{
    public interface ICosmosDbConfiguration
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string AccountContainerName { get; set; }
        string AccountContainerPartitionKeyPath { get; set; }
        //string EnquiryContainerName { get; set; }
        //string EnquiryContainerPartitionKeyPath { get; set; }
        //string CarReservationContainerName { get; set; }
        //string CarReservationPartitionKeyPath { get; set; }
    }
}
