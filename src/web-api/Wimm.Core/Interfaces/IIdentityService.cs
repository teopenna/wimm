using System;

namespace Wimm.Core.Interfaces
{
    public interface IIdentityService
    {
        Guid GetUserIdentity();
        string GetUserEmail();
    }
}
