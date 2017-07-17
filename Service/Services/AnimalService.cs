using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Base;
using Service.Interfaces;

namespace Service.Services
{
    public class AnimalService : CrudService<Animal, int>, IAnimalService
    {
        IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
            : base(animalRepository)
        {
            _animalRepository = animalRepository;
                
        }
    }
}
