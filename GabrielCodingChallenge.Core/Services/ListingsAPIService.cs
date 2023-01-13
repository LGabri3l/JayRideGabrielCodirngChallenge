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
    public class ListingsAPIService : IListingsAPI
    {
        private readonly HttpClient _httpClient;
        public ListingsAPIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        ListingsAPI listings = new ListingsAPI();

        public async Task<object> TotalPrice()
        {
            var result = await _httpClient.GetFromJsonAsync<ListingsAPI>("https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest/");
            if (result != null)
                listings = result;
            return listings;
        }

        public async Task<object> GetList(int numPassenger)
        {
            var result = await _httpClient.GetFromJsonAsync<ListingsAPI>("https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest/");
            if (result != null)
                listings = result;

            List<Listings> listingsList = new List<Listings>();

            foreach (var item in listings.listings)
            {
                if (item.vehicleType.maxPassengers > numPassenger)
                {

                    Listings listing = new Listings();

                    listing.pricePerPassenger = (item.pricePerPassenger * item.vehicleType.maxPassengers);
                    listing.name = item.name;
                    listing.vehicleType = item.vehicleType;
                    //listing.pricePerPassenger = item.pricePerPassenger;
                    //listing.vehicleType = item.vehicleType;

                    //vehicle.maxPassengers = item.vehicleType.maxPassengers;
                    //listing.vehicleType.maxPassengers = vehicle.maxPassengers;

                    listingsList.Add(listing);
                }
            }


            return listingsList;
        }


    }
}
