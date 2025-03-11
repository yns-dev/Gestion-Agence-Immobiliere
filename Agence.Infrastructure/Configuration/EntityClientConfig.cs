using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agence.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agence.Infrastructure.Configuration
{
    public class EntityClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nom)
                .IsRequired().HasMaxLength(50).HasColumnType("VARCHAR");
            builder.Property(c => c.Email)
                .IsRequired().HasMaxLength(50);
            builder.Property(c => c.Tel).HasColumnName("PhoneNumber");
            builder.HasMany(c=>c.Visites)
                .WithOne(v => v.Client)
                .HasForeignKey(v => v.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
