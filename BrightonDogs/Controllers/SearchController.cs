using Microsoft.AspNetCore.Mvc;
using BrightonDogs.Data;
using BrightonDogs.Models.Dogs;
using Microsoft.AspNetCore.Authorization;

namespace BrightonDogs.Controllers
{
    public class SearchController : Controller
    {
        private readonly IDog _dogService;
        public SearchController(IDog dogService)
        {
            _dogService = dogService;
        }
        [Authorize(Roles = "User") ]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(DogSearchModel dogsearchModel)
        {
            var dog = _dogService.GetFilteredDog(dogsearchModel);

            var model = new DogSearchResults
            {
                 DogList = dog

            };
            


            return View(model);
        }


    }
}