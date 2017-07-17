using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Base;
using Service.Interfaces;

namespace Service.Services
{
    public class PessoaService : CrudService<Pessoa, int> , IPessoaService
    {
        IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository pessoaRepository)
            :base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
