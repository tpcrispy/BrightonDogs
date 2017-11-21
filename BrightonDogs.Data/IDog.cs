using BrightonDogs.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightonDogs.Data
{
    public interface IDog
    {
        Dog GetById(int id);
        IEnumerable<Dog> GetAllDogInfo();
        IEnumerable<DogBasicModel> GetBasicDogInfo();
        IEnumerable<DogBasicModel> GetFilteredDog(DogSearchModel searchModel);

        //CUD's
        Task Create(Dog dog);
        Task Delete(int dogId);

        //Will have to think about this one
        Task UpdateDog(int dogId, Dog updatedDogModel);


    }   
}
