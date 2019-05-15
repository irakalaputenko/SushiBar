using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace NipponBar.DB
{
    public class SushiContext : DbContext
    {
        public SushiContext() : base("SushisDB")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Sushi1> Sushi1s { get; set; }
    }
}
