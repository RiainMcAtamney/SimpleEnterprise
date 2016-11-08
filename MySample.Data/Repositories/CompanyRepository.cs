
using MySample.Business;
using MySample.Data.Infrastructure;
using System;
using System.Linq;

namespace MySample.Data.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Company GetCompanyByName(string companyName)
        {
            var company = this.DbContext.Companies.Where(c => c.Name == companyName).FirstOrDefault();

            return company;
        }

        public override void Update(Company entity)
        {
            entity.DateUpdated = DateTime.Now;
            base.Update(entity);
        }
    }
}
