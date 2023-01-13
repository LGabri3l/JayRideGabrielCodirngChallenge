using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Entities
{
    public class Candidates
    {
        
        public string name { get; set; }
        public string phone { get; set; }
    }
}
