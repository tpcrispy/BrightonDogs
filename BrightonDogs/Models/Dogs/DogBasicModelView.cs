using BrightonDogs.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightonDogs.Models.Dogs
{
    public class DogBasicModelView
    {
        public int Microchip { get; set; }
        public string Name { get; set; }
        public TagColor TagColor { get; set; }
        public string OwnerName { get; set; }
        public string Breed { get; set; }
        public int Id { get; set; }
    }
}
