using Domain.Entities;
using Persistence.Entity.Context;
using Repository.Base.Repositories;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class PessoaRepository : CrudRepository<Pessoa, int>, IPessoaRepository
    {
        public PessoaRepository(ProjetoBaseDbContext context)
            :base(context)
        {

        }
    }
}
