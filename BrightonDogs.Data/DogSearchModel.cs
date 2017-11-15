using BrightonDogs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightonDogs.Models.Dogs
{
    public class DogSearchModel
    {
        public int? Id { get; set; }
        public int? Micrhochip { get; set; }
        public string Name { get; set; }
        public TagColor? Tagcolor { get; set; }
        public string Breed { get; set; }

    }
}
