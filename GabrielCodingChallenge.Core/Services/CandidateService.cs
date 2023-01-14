using GabrielCodingChallenge.Core.Entities;
using GabrielCodingChallenge.Core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Services
{
    public class CandidateService :ICandidate   
    {

        private readonly HttpClient _httpClient;
        public CandidateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Candidates> candidate = new List<Candidates>();

        
        public async Task GetCandidate()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Candidates>>("GabrielAPIChallenge/Candidate");
            if (result != null)
                candidate = result;
        }


    }
}
