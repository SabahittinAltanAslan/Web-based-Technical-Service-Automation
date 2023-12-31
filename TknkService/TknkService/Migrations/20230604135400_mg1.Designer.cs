﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TknkService.Models;

#nullable disable

namespace TknkService.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230604135400_mg1")]
    partial class mg1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TknkService.Models.Cihaz", b =>
                {
                    b.Property<int>("cihazID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cihazID"));

                    b.Property<string>("aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cihazAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cihazDurum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cihazID");

                    b.ToTable("cihazs");
                });

            modelBuilder.Entity("TknkService.Models.Musteri", b =>
                {
                    b.Property<int>("Musteriid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Musteriid"));

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("chzcihazID")
                        .HasColumnType("int");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Musteriid");

                    b.HasIndex("chzcihazID");

                    b.ToTable("musteris");
                });

            modelBuilder.Entity("TknkService.Models.Personel", b =>
                {
                    b.Property<int>("perId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("perId"));

                    b.Property<string>("perAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perId");

                    b.ToTable("personels");
                });

            modelBuilder.Entity("TknkService.Models.Musteri", b =>
                {
                    b.HasOne("TknkService.Models.Cihaz", "chz")
                        .WithMany("mus")
                        .HasForeignKey("chzcihazID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chz");
                });

            modelBuilder.Entity("TknkService.Models.Cihaz", b =>
                {
                    b.Navigation("mus");
                });
#pragma warning restore 612, 618
        }
    }
}
