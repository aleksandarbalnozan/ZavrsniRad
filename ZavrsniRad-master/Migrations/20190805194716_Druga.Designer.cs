﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolovniAutomobiliZavrsniRad.Models;

namespace PolovniAutomobiliZavrsniRad.Migrations
{
    [DbContext(typeof(AutoContext))]
    [Migration("20190805194716_Druga")]
    partial class Druga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Komentar", b =>
                {
                    b.Property<int>("KomentarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Korisnik")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("KorisnikId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("VoziloId");

                    b.HasKey("KomentarId");

                    b.HasIndex("VoziloId");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Marka", b =>
                {
                    b.Property<int>("MarkaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MarkaId");

                    b.ToTable("Marka");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Modeli", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarkaId");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ModelId")
                        .HasName("PK__Modeli__E8D7A12CCDD27570");

                    b.HasIndex("MarkaId");

                    b.ToTable("Modeli");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.TipVozila", b =>
                {
                    b.Property<int>("TipVozilaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TipVozilaId");

                    b.ToTable("TipVozila");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Vozilo", b =>
                {
                    b.Property<int>("VoziloId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojBrzina")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<int>("Cena");

                    b.Property<string>("Kilometraza")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("KorisnikId")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Kubikaza")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("MarkaId");

                    b.Property<string>("Menjac")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("ModelId");

                    b.Property<string>("Opis")
                        .HasMaxLength(200);

                    b.Property<string>("Pogon")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<byte[]>("Slika");

                    b.Property<string>("SlikaTip")
                        .HasMaxLength(20);

                    b.Property<string>("Snaga")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("TipVozilaId");

                    b.HasKey("VoziloId");

                    b.HasIndex("MarkaId");

                    b.HasIndex("ModelId");

                    b.HasIndex("TipVozilaId");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Komentar", b =>
                {
                    b.HasOne("PolovniAutomobiliZavrsniRad.Models.Vozilo", "Vozilo")
                        .WithMany("Komentars")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK__Komentar__Vozilo__5535A963");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Modeli", b =>
                {
                    b.HasOne("PolovniAutomobiliZavrsniRad.Models.Marka", "Marka")
                        .WithMany("Modelis")
                        .HasForeignKey("MarkaId")
                        .HasConstraintName("FK__Modeli__MarkaId__4BAC3F29");
                });

            modelBuilder.Entity("PolovniAutomobiliZavrsniRad.Models.Vozilo", b =>
                {
                    b.HasOne("PolovniAutomobiliZavrsniRad.Models.Marka", "Marka")
                        .WithMany("Vozilos")
                        .HasForeignKey("MarkaId")
                        .HasConstraintName("FK__Vozilo__MarkaId__5070F446");

                    b.HasOne("PolovniAutomobiliZavrsniRad.Models.Modeli", "Modeli")
                        .WithMany("Vozilos")
                        .HasForeignKey("ModelId")
                        .HasConstraintName("FK__Vozilo__ModelId__5165187F");

                    b.HasOne("PolovniAutomobiliZavrsniRad.Models.TipVozila", "TipVozila")
                        .WithMany("Vozilos")
                        .HasForeignKey("TipVozilaId")
                        .HasConstraintName("FK__Vozilo__TipVozil__52593CB8");
                });
#pragma warning restore 612, 618
        }
    }
}