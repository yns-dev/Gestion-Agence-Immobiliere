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
    public class EntityBienConfig : IEntityTypeConfiguration<BienImmobilier>
    {
        public void Configure(EntityTypeBuilder<BienImmobilier> builder)
        {
            builder.ToTable("Biens");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Surface)
                .IsRequired()
                .HasColumnType("DECIMAL(10,2)");
            builder.Property(b => b.Adresse)
                .IsRequired()
                .HasColumnType("TEXT");
            builder.Property(b => b.Type)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            builder.Property(b => b.Statut)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasMany(b => b.Visites)
                .WithOne(b => b.Bien)
                .HasForeignKey(b => b.BienId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
