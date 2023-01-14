using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Interfaces
{
    public interface ILocation
    {
        Task<object> GetLocation();
        Task<object> GetLocationByIP(string ip);
    }
}
