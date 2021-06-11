using Wimm.API.Dto;
using Wimm.Core.Entities;

namespace Wimm.API.Mappers
{
    public static class AccountMapper
    {
        public static AccountDto MapToDto(Account account)
        {
            return new AccountDto
            {
                AccountId = account.Id,
                Name = account.Name,
                InitialAmount = account.InitialAmount,
                Currency = account.Currency
            };
        }

        public static Account MapFromDto(AccountDto accountDto)
        {
            return new Account
            {
                Id = accountDto.AccountId,
                Name = accountDto.Name,
                InitialAmount = accountDto.InitialAmount,
                Currency = accountDto.Currency
            };
        }
    }
}
