using Microsoft.EntityFrameworkCore;

namespace TknkService.Models
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LEGEN;database=tknkService;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Musteri> musteris { get; set; }
        public DbSet<Cihaz> cihazs { get; set; }
        public DbSet<Personel> personels { get; set; }
    }
}
