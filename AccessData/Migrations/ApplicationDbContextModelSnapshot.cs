﻿// <auto-generated />
using System;
using AccessData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ClienteId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Cliente");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Apellido = "Bravo",
                            Direccion = "Calle 9 N2946",
                            Dni = "39876453",
                            Email = "bravo.jose.luis18@gmail.com",
                            Nombre = "Jose",
                            Telefono = "1136756432"
                        },
                        new
                        {
                            ClienteId = 2,
                            Apellido = "Damico",
                            Direccion = "Moreno 322",
                            Dni = "12383764",
                            Email = "claudio.damico@gmail.com",
                            Nombre = "Claudio",
                            Telefono = "1123455877"
                        },
                        new
                        {
                            ClienteId = 3,
                            Apellido = "Nuzzo",
                            Direccion = "Lavelle 987",
                            Dni = "39987666",
                            Email = "julian.nuzzo@gmail.com",
                            Nombre = "Julian",
                            Telefono = "1123982376"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Peso")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("MascotaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MascotaId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Domain.Entities.Veterinario", b =>
                {
                    b.Property<int>("VeterinarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ConsultorioId")
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("VeterinarioId");

                    b.HasIndex("ConsultorioId")
                        .IsUnique();

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Veterinario");
                });

            modelBuilder.Entity("Domain.Models.CalendarioTurno", b =>
                {
                    b.Property<int>("CalendarioTurnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horafin")
                        .HasColumnType("datetime2");

                    b.Property<int>("VeterinarioId")
                        .HasColumnType("int");

                    b.HasKey("CalendarioTurnoId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("CalendarioTurno");
                });

            modelBuilder.Entity("Domain.Models.Consultorio", b =>
                {
                    b.Property<int>("ConsultorioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numero")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("VeterinariaId")
                        .HasColumnType("int");

                    b.HasKey("ConsultorioId");

                    b.HasIndex("ConsultorioId");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Consultorio");
                });

            modelBuilder.Entity("Domain.Models.HistoriaClinica", b =>
                {
                    b.Property<int>("HistoriaClinicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.HasKey("HistoriaClinicaId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("MascotaId")
                        .IsUnique();

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("Domain.Models.Registro", b =>
                {
                    b.Property<int>("RegistroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Analisis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("RegistroId");

                    b.HasIndex("HistoriaClinicaId");

                    b.HasIndex("RegistroId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("Domain.Models.Turno", b =>
                {
                    b.Property<int>("TurnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CalendarioTurnoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horafin")
                        .HasColumnType("datetime2");

                    b.Property<int>("MascotaId")
                        .HasColumnType("int");

                    b.HasKey("TurnoId");

                    b.HasIndex("CalendarioTurnoId");

                    b.HasIndex("MascotaId")
                        .IsUnique();

                    b.HasIndex("TurnoId");

                    b.ToTable("Turno");
                });

            modelBuilder.Entity("Domain.Models.Veterinaria", b =>
                {
                    b.Property<int>("VeterinariaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("VeterinariaId");

                    b.HasIndex("VeterinariaId");

                    b.ToTable("Veterinaria");
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Veterinario", b =>
                {
                    b.HasOne("Domain.Models.Consultorio", "Consultorio")
                        .WithOne("Veterinario")
                        .HasForeignKey("Domain.Entities.Veterinario", "ConsultorioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultorio");
                });

            modelBuilder.Entity("Domain.Models.CalendarioTurno", b =>
                {
                    b.HasOne("Domain.Entities.Veterinario", "Veterinario")
                        .WithMany("CalendarioTurnos")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Domain.Models.Consultorio", b =>
                {
                    b.HasOne("Domain.Models.Veterinaria", "Veterinaria")
                        .WithMany("Consultorios")
                        .HasForeignKey("VeterinariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Veterinaria");
                });

            modelBuilder.Entity("Domain.Models.HistoriaClinica", b =>
                {
                    b.HasOne("Domain.Entities.Mascota", "Mascota")
                        .WithOne("HistoriaClinica")
                        .HasForeignKey("Domain.Models.HistoriaClinica", "MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Domain.Models.Registro", b =>
                {
                    b.HasOne("Domain.Models.HistoriaClinica", "HistoriaClinica")
                        .WithMany("Registros")
                        .HasForeignKey("HistoriaClinicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoriaClinica");
                });

            modelBuilder.Entity("Domain.Models.Turno", b =>
                {
                    b.HasOne("Domain.Models.CalendarioTurno", "CalendarioTurno")
                        .WithMany("Turnos")
                        .HasForeignKey("CalendarioTurnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mascota", "Mascota")
                        .WithOne("Turno")
                        .HasForeignKey("Domain.Models.Turno", "MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalendarioTurno");

                    b.Navigation("Mascota");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Domain.Entities.Mascota", b =>
                {
                    b.Navigation("HistoriaClinica");

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("Domain.Entities.Veterinario", b =>
                {
                    b.Navigation("CalendarioTurnos");
                });

            modelBuilder.Entity("Domain.Models.CalendarioTurno", b =>
                {
                    b.Navigation("Turnos");
                });

            modelBuilder.Entity("Domain.Models.Consultorio", b =>
                {
                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("Domain.Models.HistoriaClinica", b =>
                {
                    b.Navigation("Registros");
                });

            modelBuilder.Entity("Domain.Models.Veterinaria", b =>
                {
                    b.Navigation("Consultorios");
                });
#pragma warning restore 612, 618
        }
    }
}
