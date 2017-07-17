using Domain.Entities;
using Service.Base;

namespace Service.Interfaces
{
    public interface IAnimalService : ICrudService<Animal, int>
    {
    }
}
