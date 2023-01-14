using GabrielCodingChallenge.Core.Interfaces;
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

        [HttpGet]
        public async Task<ActionResult> GetAll(int numPassenger)
        {
            var result = await _listingsAPI.GetList();
            return Ok(result);
        }

        [HttpGet("{numPassenger}")]
        public async Task<ActionResult> GetTotalPrice(int numPassenger)
        {
            var result = await _listingsAPI.GetListByTotalPrice(numPassenger);
            return Ok(result);
        }

    }
}
