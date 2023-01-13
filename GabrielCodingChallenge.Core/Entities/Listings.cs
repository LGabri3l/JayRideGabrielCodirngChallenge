using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Entities
{
    public class Listings
    {
        public string name { get; set; }

        public double pricePerPassenger { get; set; }

        public vehicleType vehicleType { get; set; }
    }
}
