using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agence.Domain.Models;
using Agence.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Agence.Infrastructure.Data
{
    public class AgenceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Visite> Visites { get; set; }
        public DbSet<BienImmobilier> Biens { get; set; }
        public AgenceDbContext(DbContextOptions<AgenceDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EntityClientConfig());
            modelBuilder.ApplyConfiguration(new EntityBienConfig());
            modelBuilder.ApplyConfiguration(new EntityVisiteConfig());
        }
    }
}
