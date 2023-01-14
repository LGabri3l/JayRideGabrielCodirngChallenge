using GabrielCodingChallenge.Core.Entities;
using GabrielCodingChallenge.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace GabrielCodingChallenge.API.Controllers
{
    [Route("GabrielAPIChallenge/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private readonly ILocation _location;

        public LocationController(ILocation location)
        {
            _location = location;
        }

        //
        [HttpGet]
        public async Task<IActionResult> GetLocation()
        {
            var result = await _location.GetLocation();
            return Ok(result);
        }

        [HttpGet("{ip}")]
        public async Task<IActionResult> GetSpecificLocation(string ip)
        {           
            var result = await _location.GetLocationByIP(ip);
            return Ok(result); 
        }

    }
}
