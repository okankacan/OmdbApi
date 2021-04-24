using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Omdbapi.Core.Helpers.httpClient;
using Omdbapi.Core.Interface.Client;
using Omdbapi.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Omdbapi.Infrastructure.Client
{
    public class OmdbRequestClient : IOmdbRequestClient
    {
        private readonly IConfiguration _configuration;

        public OmdbRequestClient(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<OmdbApiModel> OmdbFilmSearch(string filmName)
        {
            try
            {
                var apiUrl = _configuration.GetSection("ApiUrl:BaseAdress").Value + "&s=" + filmName;
                var request = await HttpRequestFactory.Get(apiUrl);
                var responseContent = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<BaseResponseModel>(responseContent);
                if (!string.IsNullOrWhiteSpace(responseContent))
                    return JsonConvert.DeserializeObject<OmdbApiModel>(responseContent);
                

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }
    }
}
