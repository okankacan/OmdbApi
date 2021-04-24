

using System;

namespace Omdbapi.Core.Model.DbModels.Interface
{
    public interface IDbEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime CreateDate { get; set; }
    }
}