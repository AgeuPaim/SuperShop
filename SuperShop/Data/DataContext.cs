using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class DataContext : IdentityDbContext<User>

    {   
        
        public DbSet<Product> Products { get; set; } // entidade responsavel pela criaçao da tabela Products atraves da EntityFrameworkCore

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
