using SuperShop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class MockRepository : IRepository
    {
        void IRepository.AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        Product IRepository.GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Product> IRepository.GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Um", Price = 10 });
            products.Add(new Product { Id = 2, Name = "Dois", Price = 10 });
            products.Add(new Product { Id = 3, Name = "Três", Price = 10 });
            products.Add(new Product { Id = 4, Name = "Quatro", Price = 10 });
            products.Add(new Product { Id = 5, Name = "Cinco", Price = 10 });

            return products;
        }

        bool IRepository.ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        void IRepository.RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IRepository.SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        void IRepository.UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
