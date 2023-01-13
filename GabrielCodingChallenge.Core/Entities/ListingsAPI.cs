using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCodingChallenge.Core.Entities
{
    public class ListingsAPI
    {        
        public string from { get; set; }
                
        public string to { get; set; }
               
        public List<Listings> listings { get; set; }
    }      

}


