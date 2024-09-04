using SuperShop.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private Random _randon;

        public SeedDb(DataContext context)
        {
            _context = context;
            _randon = new Random();
        }

        public async Task SeedAsync()
        {

            await _context.Database.EnsureCreatedAsync();
            if (!_context.Products.Any())
            {
                AddProduct("iPhone X");
                AddProduct("Magic Mouse");
                AddProduct("iWatch");
                AddProduct("iPad Mini X");
                await _context.SaveChangesAsync();
            }

        }

        private void AddProduct(string name)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _randon.Next(1000),
                IsAvalible = true,
                stock = _randon.Next(100)   


            });

        }
    }
}
