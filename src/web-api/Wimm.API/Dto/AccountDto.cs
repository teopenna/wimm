using System.ComponentModel.DataAnnotations;

namespace Wimm.API.Dto
{
    public class AccountDto
    {
        [Required]
        public string AccountId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal InitialAmount { get; set; }
        [Required]
        public string Currency { get; set; }
    }
}
