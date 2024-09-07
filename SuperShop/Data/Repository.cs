using SuperShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SuperShop.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        // vou buscar todos os produtos
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Name);
        }

        // vou buscar um produto 
        public Product GetProduct(int id)
        {
            return _context.Products.Find(id);
        }

        //adiciona um 
        public void AddProduct(Product product)
        {

            _context.Products.Add(product);
        }

        // faz o update
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }



        // remove 
        public void RemoveProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        // Gravar tudo o que estiver pendente para a base de dados e devemos usar metodo 
        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return _context.Products.Any(p => p.Id == id);// existe algum produto com este id?
        }

        
    }
}
