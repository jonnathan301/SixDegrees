using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SystemDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LENOVO-PC;Database=PruebaSD;User Id=sa;Password=sa2;");
        }        
    }
}
