using MySample.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetCompanyProducts(string companyName, string productName = null);
        Product GetProduct(int id);
        void CreateProduct(Product product);

        void SaveProduct();
    }
}
