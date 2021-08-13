using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gigster.Models
{
    public class ApplicationUser: IdentityUser
    {
        //public async Task<ClaimsIdentity> GenerateUserIdentity(UserManager<ApplicationUser> manager)
        //{
        //    var userIdentity = await manager.CreateSecurityTokenAsync(this);
        //    return userIdentity;
        //}
    }
}
