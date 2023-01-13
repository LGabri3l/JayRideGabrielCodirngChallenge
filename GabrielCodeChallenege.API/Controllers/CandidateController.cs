using GabrielCodingChallenge.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrielCodeChallenege.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        public static List<Candidates> candidate = new List<Candidates>
        {
            new Candidates { name = "test", phone = "test"}
        };

        [HttpGet("(Candidate)")]
        public async Task<IActionResult> GetCandidate()
        {
            return Ok(candidate);
        }





    }
}
