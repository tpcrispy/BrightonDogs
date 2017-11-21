using BrightonDogs.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightonDogs.Models.Dogs
{
    public class DogSearchResults
    {
        public IEnumerable<DogBasicModel> DogList { get; set; }
    }
}
