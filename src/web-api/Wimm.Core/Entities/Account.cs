namespace Wimm.Core.Entities
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }
        public decimal InitialAmount { get; set; }
    }
}
