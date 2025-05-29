using Microsoft.EntityFrameworkCore;

namespace behlul.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-IG9108U\\SQLEXPRESS;database=behlul;Trusted_Connection=True;trust server certificate=true");
        }
        public DbSet<Etkinlikler> etkinliklers { get; set; }
    }
}
