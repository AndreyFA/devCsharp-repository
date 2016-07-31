using AutoMapper;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.MVC.ViewModels;

namespace ControleFinanceiro.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}