using MySample.Business;
using MySample.Data.Infrastructure;

namespace MySample.Data.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company GetCompanyByName(string companyName);
    }
}
