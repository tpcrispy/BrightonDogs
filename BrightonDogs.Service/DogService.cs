using BrightonDogs.Data;
using System;
using BrightonDogs.Data.Models;
using BrightonDogs.Models.Dogs;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Dog> GetAll()
        {
            return _context.Dogs.Include(dog => dog.Owner);
        }

        public Dog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dog> GetFilteredDog(DogSearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDog(int dogId, Dog updatedDogModel)
        {
            throw new NotImplementedException();
        }
    }
}
