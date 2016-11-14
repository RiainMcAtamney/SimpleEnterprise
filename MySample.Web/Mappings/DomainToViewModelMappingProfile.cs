using AutoMapper;
using MySample.Business;
using MySample.Web.ViewModels;

namespace MySample.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {

            ConfigureMappings();


            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Company, CompanyViewModel>();
            //});

            //IMapper mapper = config.CreateMapper();
            //var company = new Company();
            //var companyViewModel = mapper.Map<Company, CompanyViewModel>(company);
        }


        /// <summary>
        /// Creates a mapping between source (Domain) and destination (ViewModel)
        /// </summary>
        private void ConfigureMappings()
        {
            CreateMap<Company, CompanyViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}