using Microsoft.EntityFrameworkCore;

namespace Omdbapi.Core.Contexts
{
    public class BaseDbContext : DbContext
    {

 

        public BaseDbContext(DbContextOptions<BaseDbContext> options)
          : base(options)
        {
        }

      



    }
}
