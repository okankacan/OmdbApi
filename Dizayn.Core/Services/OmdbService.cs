using Omdbapi.Core.Interface.Client;
using Omdbapi.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Omdbapi.Core.Services
{
    public class OmdbService
    {
        private readonly IOmdbRequestClient _omdbRequestClient;

        public OmdbService(IOmdbRequestClient omdbRequestClient)
        {
            _omdbRequestClient = omdbRequestClient;
        }

        public async Task<OmdbApiModel> FilmSearch(string filmName)
        {
            var response = await _omdbRequestClient.OmdbFilmSearch(filmName);

            return response;


        }

    }
}
