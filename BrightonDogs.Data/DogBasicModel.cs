using BrightonDogs.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BrightonDogs.Data
{
     public class DogBasicModel
    {
        public int Microchip { get; set; }
        public string Name { get; set; }
        public TagColor Tagcolor { get; set; }
        public string Breed { get; set; }
        public string OwnersName { get; set; }
        public int Id { get; set; }

    }
}
