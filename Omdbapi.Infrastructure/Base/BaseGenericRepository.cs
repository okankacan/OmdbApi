using Omdbapi.Core.Helpers;
using Omdbapi.Core.Model.DbModels.Interface;
using Microsoft.EntityFrameworkCore;

namespace Omdbapi.Infrastructure.Base
{

    public class BaseGenericRepository<TModel, TKey, CustomDbContext> : BaseGenericBaseRepository<TModel, TKey, CustomDbContext>
   where TModel : class, IDbEntity<TKey>
   where CustomDbContext : DbContext
    {
        public BaseGenericRepository() : base(
                 ServiceGetter.GetService<CustomDbContext>(), null)
        { }
    }
}
