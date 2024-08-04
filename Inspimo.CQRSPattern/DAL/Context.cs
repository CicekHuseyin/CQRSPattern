using Microsoft.EntityFrameworkCore;

namespace Inspimo.CQRSPattern.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KR485FT\\SQLEXPRESS; initial Catalog=CQRSDb; integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
