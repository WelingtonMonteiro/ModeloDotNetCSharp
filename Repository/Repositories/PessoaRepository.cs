using Domain.Entities;
using Persistence.Entity.Context;
using Repository.Base.Repositories;

namespace Repository.Repositories
{
    public class PessoaRepository : CrudRepository<Pessoa, int>
    {
        public PessoaRepository(ProjetoBaseDbContext context)
            :base(context)
        {

        }
    }
}
