using Omdbapi.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Omdbapi.Core.Interface.Client
{
   public interface IOmdbRequestClient
    {
        Task<OmdbApiModel> OmdbFilmSearch(string filmName);

    }
}
