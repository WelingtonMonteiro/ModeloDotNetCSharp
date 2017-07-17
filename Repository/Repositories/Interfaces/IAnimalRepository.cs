using Domain.Entities;
using Repository.Base;

namespace Repository.Repositories.Interfaces
{
    public interface IAnimalRepository: ICrudRepository<Animal, int>
    {
    }
}
