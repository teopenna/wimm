using Microsoft.AspNetCore.Authorization;

namespace Wimm.API.AuthorizationPolicies
{
    public class ScopesRequirement : IAuthorizationRequirement
    {
        public readonly string ScopeName;

        public ScopesRequirement(string scopeName)
        {
            ScopeName = scopeName;
        }
    }
}
