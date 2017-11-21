using BrightonDogs.Data;
using System;
using BrightonDogs.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BrightonDogs.Service
{
    public class DogService : IDog
    {
        private readonly ApplicationDbContext _context; 

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int dogId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dog> GetAllDogInfo()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<DogBasicModel> GetBasicDogInfo()
        {
            var dogSummary = _context.Dogs.Include(dog => dog.Owner).Select(dog => new DogBasicModel
            {
                Name = dog.Name,
                Microchip = dog.MicroChip,
                Breed = dog.Breed,
                OwnersName = dog.Owner.FirstName,
                Tagcolor = dog.TagColor,
                Id = dog.Id
                

                
            });

            return dogSummary;
        }

        public Dog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DogBasicModel> GetFilteredDog(DogSearchModel searchModel)
        {
            var dogs = _context.Dogs.AsQueryable();
            if (searchModel != null)
            {
                if(searchModel.Micrhochip.HasValue)
                {
                    dogs = dogs.Where(dog => dog.MicroChip.ToString().Contains(searchModel.Micrhochip.ToString()));
                }
                if (!string.IsNullOrEmpty(searchModel.Name))
                {
                    dogs = dogs.Where(dog => dog.Name.Contains((searchModel.Name)));
                }
                if (!string.IsNullOrEmpty(searchModel.Breed))
                {
                    dogs = dogs.Where(dog => dog.Name.Contains((searchModel.Breed)));
                }
                if (searchModel.Tagcolor.HasValue)
                {
                    dogs = dogs.Where(dog => dog.TagColor == searchModel.Tagcolor);
                }
            }
            var dogreturn = dogs.Select(dog => new DogBasicModel
            {
                Name = dog.Name,
                Microchip = dog.MicroChip,
                Breed = dog.Breed,
                OwnersName = dog.Owner.FirstName,
                Tagcolor = dog.TagColor,
                Id = dog.Id
            });

            return dogreturn;
        }

        public Task UpdateDog(int dogId, Dog updatedDogModel)
        {
            throw new NotImplementedException();
        }
    }
}
