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
    public class EntityVisiteConfig : IEntityTypeConfiguration<Visite>
    {
        public void Configure(EntityTypeBuilder<Visite> builder)
        {
            builder.ToTable("Visites");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.DateVisite)
                .IsRequired()
                .HasColumnType("DATETIME");
            builder.Property(v => v.DateConfirmation)
                .IsRequired(false);
            builder.Property(v => v.Statut)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasOne(v => v.Bien)
               .WithMany(b => b.Visites)
               .HasForeignKey(v => v.BienId);
            builder.HasOne(v => v.Client)
               .WithMany(c => c.Visites)
               .HasForeignKey(v => v.ClientId);
        }
    }
}
