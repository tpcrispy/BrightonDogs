using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BrightonDogs.Data;
using BrightonDogs.Models.Dogs;
using BrightonDogs.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace BrightonDogs.Controllers
{
    public class DogController : Controller
    {
        private readonly IDog _dogService;
        public DogController(IDog dogService)
        {
            _dogService = dogService;
        }

        public IActionResult Index()
        {
            var dogs = _dogService.GetBasicDogInfo()
                .Select(dog => new DogBasicModelView
                {
                    Name = dog.Name,
                    Breed = dog.Breed,
                    Microchip = dog.Microchip,
                    OwnerName = dog.OwnersName,
                    Id = dog.Id,
                    TagColor = dog.Tagcolor
                });

            var model = new DogBasicModelViewList
            {
                DogList = dogs
            };
            return View(model);
        }

        public IActionResult Info(int id)
        {

            return View();
        }

        

        


    }
}

    