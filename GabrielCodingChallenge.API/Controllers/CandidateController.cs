using GabrielCodingChallenge.Core.Entities;
using JayRideGabrielCodingChallenge.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GabrielCodingChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {

        private AppDbContext _dbContext;

        public CandidateController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public List<Candidates> candidate = new List<Candidates>();
        //{
        //    new Candidates
        //    {
        //        name = "test",
        //        phone = "test"
        //    }
        //};        

        [HttpGet]
        public async Task<IActionResult> GetCandidate()
        {
            var candidate = await _dbContext.Candidate.ToListAsync();
            return Ok(candidate);
        }

        
    }
}
