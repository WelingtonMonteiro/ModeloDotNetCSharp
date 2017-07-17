using Domain.Entities;
using Repository.Base;

namespace Repository.Repositories.Interfaces
{
    public interface IPessoaRepository : ICrudRepository<Pessoa, int>
    {
    }
}
