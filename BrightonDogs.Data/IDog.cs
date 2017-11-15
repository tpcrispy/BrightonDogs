using BrightonDogs.Data.Models;
using System.Collections.Generic;
using BrightonDogs.Models.Dogs;
using System.Threading.Tasks;

namespace BrightonDogs.Data
{
    public interface IDog
    {
        Dog GetById(int id);
        IEnumerable<Dog> GetAll();
        IEnumerable<Dog> GetFilteredDog(DogSearchModel searchModel);

        //CUD's
        Task Create(Dog dog);
        Task Delete(int dogId);

        //Will have to think about this one
        Task UpdateDog(int dogId, Dog updatedDogModel);


    }   
}
