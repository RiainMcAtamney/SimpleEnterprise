using System;
using System.Collections.Generic;
using MySample.Business;
using MySample.Data.Repositories;
using System.Linq;

namespace MySample.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;       

        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        #region ICompanyService Members

        public IEnumerable<Company> GetCompanies(string name = null)
        {
            if (string.IsNullOrEmpty(name))
                return companyRepository.GetAll();
            else
                return companyRepository.GetAll().Where(c => c.Name == name);
        }

        public Company GetCompany(int id)
        {
            var company = companyRepository.GetById(id);
            return company;
        }

        public Company GetCompany(string name)
        {
            var company = companyRepository.GetCompanyByName(name);
            return company;
        }

        public void CreateCompany(Company company)
        {
            companyRepository.Add(company);
        }

        #endregion
    }
}
