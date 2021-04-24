using System;

namespace Omdbapi.Core.Interface.Data
{
    public interface IServiceProviderAccessor
    {
        IServiceProvider ServiceProvider { get; set; }
    }
}
