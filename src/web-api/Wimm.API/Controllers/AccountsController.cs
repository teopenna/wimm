using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wimm.Core.Entities;
using Wimm.Core.Interfaces;

namespace Wimm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IDataRepository<Account> _accountRepository;

        public AccountsController(IDataRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository ??
                throw new ArgumentNullException(nameof(accountRepository));
        }

        /// <summary>
        /// Gets list with current user's accounts
        /// </summary>
        /// <returns>
        /// List with user's accounts
        /// </returns> 
        /// <response code="200">List with accounts</response>
        /// <response code="401">Access denied</response>
        /// <response code="404">Account list not found</response>
        /// <response code="500">Oops! something went wrong</response>
        [ProducesResponseType(typeof(IReadOnlyList<Account>), 200)]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllCarsAsync()
        {
            var allAccounts = await _accountRepository.GetAllAsync();
            return Ok(allAccounts);
        }
    }
}
