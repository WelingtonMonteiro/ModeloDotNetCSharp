using AutoMapper;
using Domain.Entities;
using ViewModel.Animal;
using ViewModel.Pessoa;

namespace WebApi.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Pessoa, PessoaViewModelList>();

            CreateMap<Animal, AnimalViewModelList>();
            
        }
    }
}