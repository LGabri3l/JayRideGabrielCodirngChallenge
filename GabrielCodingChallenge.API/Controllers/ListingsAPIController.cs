using GabrielCodingChallenge.Core.Entities;
using GabrielCodingChallenge.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielCodingChallenge.API.Controllers
{
    [Route("GabrielAPIChallenge/[controller]")]
    [ApiController]
    public class ListingsAPIController : ControllerBase
    {

        private readonly IListingsAPI _listingsAPI;

        public ListingsAPIController(IListingsAPI listingsAPI)
        {
            _listingsAPI = listingsAPI;
        }

        [HttpGet("{numPassenger}")]
        public async Task<ActionResult> GetTotalPrice(int numPassenger)
        {
            var result = await _listingsAPI.GetList(numPassenger);
            return Ok(result);
        }


        //[Route("Listings")]
        //public async Task<ActionResult> GetListings()
        //{
        //    var result = await _listingsAPI.TotalPrice();

        //    foreach (var item in result)
        //    {

        //    }



        //    return Ok(result);
        //}
    }
}
