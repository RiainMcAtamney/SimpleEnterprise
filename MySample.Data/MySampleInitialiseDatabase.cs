using MySample.Business;
using System.Collections.Generic;
using System.Data.Entity;

namespace MySample.Data
{
    public class MySampleInitialiseDatabase : DropCreateDatabaseIfModelChanges<MySampleContext>
    {
        protected override void Seed(MySampleContext context)
        {
            GetCompanies().ForEach(c => context.Companies.Add(c));

            GetProducts().ForEach(p => context.Products.Add(p));       

            context.SaveChanges();
        }

        private static List<Company> GetCompanies()
        {
            return new List<Company>
            {
                new Company {
                    Name = "Neueda",
                    Location = "Belfast"
                },
                new Company {
                    Name = "BT",
                    Location = "London"
                }
            };
        }

        private static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {
                    Name = "Software Development",
                    Description = "Resources for software development.",
                    Price = 300
                },
                new Product {
                    Name = "Business Analysis",
                    Description = "Resources for business analysis.",
                    Price = 350
                },
                new Product {
                    Name = "System Architecture",
                    Description = "Resources for system architecture.",
                    Price = 400
                },
            };
        }

    }

}
