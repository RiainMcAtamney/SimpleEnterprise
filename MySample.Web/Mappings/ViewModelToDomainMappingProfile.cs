using AutoMapper;
using MySample.Business;
using MySample.Web.ViewModels;

namespace MySample.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductFormViewModel, Product>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.ProductTitle))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.ProductDescription))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.ProductPrice))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.CompanyId, map => map.MapFrom(vm => vm.ProductCompany)); ;
            });

            IMapper mapper = config.CreateMapper();
            var productFormViewModel = new ProductFormViewModel();
            var productViewModel = mapper.Map<ProductFormViewModel, Product>(productFormViewModel);
        }
        
    }

}