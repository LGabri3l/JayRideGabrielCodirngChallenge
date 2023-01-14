using GabrielCodingChallenge.Core.Entities;
using GabrielCodingChallenge.Core.Interfaces;
using System.Net.Http.Json;

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
            var url = "http://ip-api.com/json/";
            var result = await _httpClient.GetFromJsonAsync<Location>(url);            
            if (result != null)
                location = result;
            return location;
        }

        public async Task<object> GetLocationByIP(string ip)
        {
            var url = "http://ip-api.com/json/";
            var result = await _httpClient.GetFromJsonAsync<Location>(url+ip);            
            if (result != null)
                location = result;
            return location;
        }
    }
}
