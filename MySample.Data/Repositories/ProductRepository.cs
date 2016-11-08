using MySample.Business;
using MySample.Data.Infrastructure;

namespace MySample.Data.Repositories
{
    public class ProductRepository:  RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory){ }
        
    }
}
