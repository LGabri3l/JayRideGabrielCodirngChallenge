using GabrielCodingChallenge.Core.Entities;
using GabrielCodingChallenge.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Services
{
    public class LocationService: ILocation
    {
        private readonly HttpClient _httpClient;
        public LocationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        Location location = new Location();

        public async Task<object> GetLocation()
        {
            var result = await _httpClient.GetFromJsonAsync<Location>("http://ip-api.com/json/");            
            if (result != null)
                location = result;
            return location;
        }

        public async Task<object> GetLocation(string ip)
        {
            var result = await _httpClient.GetFromJsonAsync<Location>("http://ip-api.com/json/"+ip);            
            if (result != null)
                location = result;
            return location;
        }
    }
}
