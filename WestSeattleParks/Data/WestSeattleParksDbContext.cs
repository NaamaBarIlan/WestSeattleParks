using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WestSeattleParks.Data
{
    public class WestSeattleParksDbContext : IdentityDbContext<ApplicationUser>
    {
    }


}
