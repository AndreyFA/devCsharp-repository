using AutoMapper;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.MVC.ViewModels;

namespace ControleFinanceiro.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}