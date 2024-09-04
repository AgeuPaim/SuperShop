using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class DataContext : DbContext

    {   
        
        public DbSet<Product> Products { get; set; } // entidade responsavel pela criaçao da tabela Products atraves da EntityFrameworkCore

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
