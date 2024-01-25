using DAW.Models;
using Microsoft.EntityFrameworkCore;

namespace DAW.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Eveniment> Eveniment { get; set; }

        public DbSet<Participanti> Participanti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }

}
