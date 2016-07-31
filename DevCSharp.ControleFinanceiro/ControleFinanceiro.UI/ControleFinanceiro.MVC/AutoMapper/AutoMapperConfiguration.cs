using AutoMapper;

namespace ControleFinanceiro.MVC.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(_ =>
            {
                _.AddProfile<DomainToViewModelMappingProfile>();
                _.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}