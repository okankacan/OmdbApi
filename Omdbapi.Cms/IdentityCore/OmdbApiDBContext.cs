using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Omdbapi.InfraStructure;

namespace Omdbapi.Cms.IdentityCore
{


    public class OmdbApiDBContext : IdentityDbContext<ApplicationUser>
    {
        public OmdbApiDBContext(DbContextOptions<OmdbApiDBContext> options)
            : base(options)
        {

        }

    }
     
     
}
