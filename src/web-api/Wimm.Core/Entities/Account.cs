namespace Wimm.Core.Entities
{
    public class Account : BaseEntity
    {
        public string Name { get; set; }
        public decimal InitialAmount { get; set; }
        public string Owner { get; set; }
        public string Currency { get; set; }
    }
}
