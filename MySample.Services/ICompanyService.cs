using MySample.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample.Services
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetCompanies(string name = null);
        Company GetCompany(int id);
        Company GetCompany(string name);
        void CreateCompany(Company company);
    }
}
