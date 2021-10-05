﻿// <auto-generated />
using System;
using BookMarket.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookMarket.Migrations
{
    [DbContext(typeof(BookMarket_DBContext))]
    [Migration("20210826191501_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookMarket.Models.BookCarrello", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.Property<int?>("IdUtente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdLibro");

                    b.HasIndex("IdUtente");

                    b.ToTable("BookCarrello");
                });

            modelBuilder.Entity("BookMarket.Models.BookLibri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codice")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)")
                        .HasMaxLength(13);

                    b.Property<DateTime>("DataCaricamento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdAcquirente")
                        .HasColumnType("int");

                    b.Property<int>("IdProprietario")
                        .HasColumnType("int");

                    b.Property<int?>("IdUtente")
                        .HasColumnType("int");

                    b.Property<string>("Materia")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal?>("Prezzo")
                        .HasColumnType("decimal(5,2)");

                    b.Property<bool?>("Venduto")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdAcquirente");

                    b.HasIndex("IdProprietario");

                    b.ToTable("BookLibri");
                });

            modelBuilder.Entity("BookMarket.Models.BookUtenti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppuntamentoFinale")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AppuntamentoRilascio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AppuntamentoRitiro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("LastMailSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("MailToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookUtenti");
                });

            modelBuilder.Entity("BookMarket.Models.EventsLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Evento")
                        .IsRequired()
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.HasKey("Id");

                    b.ToTable("EventsLog");
                });

            modelBuilder.Entity("BookMarket.Models.BookCarrello", b =>
                {
                    b.HasOne("BookMarket.Models.BookLibri", "Libro")
                        .WithMany("BookCarrello")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMarket.Models.BookUtenti", "Utente")
                        .WithMany("BookCarrello")
                        .HasForeignKey("IdUtente");
                });

            modelBuilder.Entity("BookMarket.Models.BookLibri", b =>
                {
                    b.HasOne("BookMarket.Models.BookUtenti", "Acquirente")
                        .WithMany("LibriVenduti")
                        .HasForeignKey("IdAcquirente");

                    b.HasOne("BookMarket.Models.BookUtenti", "Proprietario")
                        .WithMany("LibriRegistrati")
                        .HasForeignKey("IdProprietario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
