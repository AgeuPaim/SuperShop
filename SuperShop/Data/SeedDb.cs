using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using SuperShop.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;     
        private Random _randon;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _randon = new Random();
        }

        public async Task SeedAsync()
        {

            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmail("ageupaim@gmail.com");

            if (user == null) 
                      
            {
                user = new User
                {

                    FirstName = "Ageu",
                    LastName = "Paim",
                    Email = "ageupaim@gmail.com",
                    UserName = "ageupaim@gmail.com",
                    PhoneNumber = "1234567890",
                };
                
                var result = await _userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success) 
                {
                    throw new Exception("Could not create the user in seeder");
                }
            
            }


            if (!_context.Products.Any())
            {
                AddProduct("iPhone X", user);
                AddProduct("Magic Mouse", user);
                AddProduct("iWatch", user);
                AddProduct("iPad Mini X", user);
                await _context.SaveChangesAsync();
            }

        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Product
            {
                Name = name,
                Price = _randon.Next(1000),
                IsAvalible = true,
                Stock = _randon.Next(100),
                User = user

            });

        }
    }
}
