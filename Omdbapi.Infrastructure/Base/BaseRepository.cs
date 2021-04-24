
using Microsoft.EntityFrameworkCore;
using Omdbapi.Core.Interface.Base;
using Omdbapi.Core.Model.DbModels.Interface;

namespace Omdbapi.Infrastructure.Base
{
    public class BaseRepository<TModel, CustomDbContext> : BaseGenericRepository<TModel, int, CustomDbContext>, IBaseRepository<TModel, CustomDbContext>
     where TModel : class, IPersistentEntity
     where CustomDbContext : DbContext
    {
    }
}
