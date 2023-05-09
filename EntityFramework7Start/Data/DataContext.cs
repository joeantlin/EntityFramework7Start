global using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork7Start.Data
{
	public class DataContext : DbContext
	{
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<SuperHero> SuperHero => Set<SuperHero>();
        public DbSet<Character> Character => Set<Character>();
        public DbSet<User> User => Set<User>();

    }
}

