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
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Company, CompanyViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            var company = new Company();
            var companyViewModel = mapper.Map<Company, CompanyViewModel>(company);
        }        
    }
}