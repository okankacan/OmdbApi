using Omdbapi.Core.Model.DbModels.Interface;
using Microsoft.EntityFrameworkCore;

namespace Omdbapi.Core.Interface.Base
{
    public interface IBaseRepository<TModel, CustomDbContext> : IBaseGenericRepository<TModel, int, CustomDbContext>
            where TModel : class, IDbEntity<int>
            where CustomDbContext : DbContext
    {

    }
}
