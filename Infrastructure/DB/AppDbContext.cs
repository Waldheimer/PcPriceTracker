using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PcPriceTracker.Domain.Entities;
using PcPriceTracker.Infrastructure.DB.Configurations;

namespace PcPriceTracker.DB
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration configuration;
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CpuConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("postgres"));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Board> Mainboards { get; set; }
        public DbSet<PSU> PSUs { get; set; }
        public DbSet<RAM> RAM { get; set; }
        public DbSet<Storage> Storages { get; set; }
    }
}
