﻿// <auto-generated />
using System;
using Agence.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agence.Infrastructure.Migrations
{
    [DbContext(typeof(AgenceDbContext))]
    partial class AgenceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Agence.Domain.Models.BienImmobilier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Surface")
                        .HasColumnType("DECIMAL(10,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Biens", (string)null);
                });

            modelBuilder.Entity("Agence.Domain.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateNaissance")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("SituationFamiliale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("Agence.Domain.Models.Visite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BienId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DateConfirmation")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateVisite")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BienId");

                    b.HasIndex("ClientId");

                    b.ToTable("Visites", (string)null);
                });

            modelBuilder.Entity("Agence.Domain.Models.Visite", b =>
                {
                    b.HasOne("Agence.Domain.Models.BienImmobilier", "Bien")
                        .WithMany("Visites")
                        .HasForeignKey("BienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Agence.Domain.Models.Client", "Client")
                        .WithMany("Visites")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Agence.Domain.Models.BienImmobilier", b =>
                {
                    b.Navigation("Visites");
                });

            modelBuilder.Entity("Agence.Domain.Models.Client", b =>
                {
                    b.Navigation("Visites");
                });
#pragma warning restore 612, 618
        }
    }
}
