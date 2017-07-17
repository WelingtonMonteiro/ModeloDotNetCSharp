using Domain.Entities;
using Persistence.Entity.Context;
using Repository.Base.Repositories;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class AnimalRepository : CrudRepository<Animal, int>, IAnimalRepository
    {
        
        public AnimalRepository(ProjetoBaseDbContext context)
            :base(context)
        {

        }
    }
}
