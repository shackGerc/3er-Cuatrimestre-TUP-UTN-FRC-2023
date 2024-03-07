﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20230615014158_Initial_migration")]
    partial class Initial_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Clases.Models.Barco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Cuota")
                        .HasColumnType("double precision");

                    b.Property<int>("IdSocio")
                        .HasColumnType("integer");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NroAmarre")
                        .HasColumnType("integer");

                    b.Property<int>("NroMatricula")
                        .HasColumnType("integer");

                    b.Property<int>("idBarco")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("idBarco");

                    b.ToTable("barcos");
                });

            modelBuilder.Entity("Clases.Models.Socio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefono")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("socios");
                });

            modelBuilder.Entity("Clases.Models.Barco", b =>
                {
                    b.HasOne("Clases.Models.Socio", "IdSocioNavigation")
                        .WithMany()
                        .HasForeignKey("idBarco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdSocioNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
