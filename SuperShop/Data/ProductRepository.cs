using SuperShop.Data.Entities;
using System.Security.Policy;

namespace SuperShop.Data
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {

        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
