using AutoMapper;
using Domain.Entities;
using ViewModel.Animal;
using ViewModel.Pessoa;

namespace WebApi.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<PessoaViewModelList, Pessoa>();

            CreateMap<AnimalViewModelList, Animal>();
        }

    }
}