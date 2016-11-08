using System.Collections.Generic;
using System.Linq;
using MySample.Business;
using MySample.Data.Repositories;

namespace MySample.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICompanyRepository companyRepository;
        public ProductService(IProductRepository productRepository, ICompanyRepository companyRepository)
        {
            this.productRepository = productRepository;
            this.companyRepository = companyRepository;
        }
        public void CreateProduct(Product product)
        {
            productRepository.Add(product);           
        }

        public IEnumerable<Product> GetCompanyProducts(string companyName, string productName = null)
        {
            var company = companyRepository.GetCompanyByName(companyName);
            return company.Products.Where(g => g.Name.ToLower().Contains(productName.ToLower().Trim()));
        }

        public Product GetProduct(int id)
        {
            var product = productRepository.GetById(id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = productRepository.GetAll();
            return products;
        }

        public void SaveProduct()
        {
            productRepository.Save();
        }
    }
}
