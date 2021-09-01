using Microsoft.EntityFrameworkCore;

namespace ASPExample.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOOBMANBR-DESKT\\SQLEXPRESS;Database=CursoMVC;Integrated Security=True;");
        }
    }
}
