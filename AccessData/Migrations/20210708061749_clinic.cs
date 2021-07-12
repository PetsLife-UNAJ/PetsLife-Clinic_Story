﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AccessData.Migrations
{
    public partial class clinic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Veterinaria",
                columns: table => new
                {
                    VeterinariaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinaria", x => x.VeterinariaId);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Edad = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Peso = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascota_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultorio",
                columns: table => new
                {
                    ConsultorioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    VeterinariaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultorio", x => x.ConsultorioId);
                    table.ForeignKey(
                        name: "FK_Consultorio_Veterinaria_VeterinariaId",
                        column: x => x.VeterinariaId,
                        principalTable: "Veterinaria",
                        principalColumn: "VeterinariaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoriasClinicas",
                columns: table => new
                {
                    HistoriaClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriasClinicas", x => x.HistoriaClinicaId);
                    table.ForeignKey(
                        name: "FK_HistoriasClinicas_Mascota_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascota",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    VeterinarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    FechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ConsultorioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.VeterinarioId);
                    table.ForeignKey(
                        name: "FK_Veterinario_Consultorio_ConsultorioId",
                        column: x => x.ConsultorioId,
                        principalTable: "Consultorio",
                        principalColumn: "ConsultorioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    RegistroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Analisis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HistoriaClinicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.RegistroId);
                    table.ForeignKey(
                        name: "FK_Registros_HistoriasClinicas_HistoriaClinicaId",
                        column: x => x.HistoriaClinicaId,
                        principalTable: "HistoriasClinicas",
                        principalColumn: "HistoriaClinicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    TurnoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horafin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MascotaId = table.Column<int>(type: "int", nullable: false),
                    VeterinarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.TurnoId);
                    table.ForeignKey(
                        name: "FK_Turno_Mascota_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascota",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turno_Veterinario_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Veterinario",
                        principalColumn: "VeterinarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tratamiento",
                columns: table => new
                {
                    TratamientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tratamiento", x => x.TratamientoId);
                    table.ForeignKey(
                        name: "FK_Tratamiento_Registros_RegistroId",
                        column: x => x.RegistroId,
                        principalTable: "Registros",
                        principalColumn: "RegistroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "Direccion", "Dni", "Email", "Nombre", "Telefono" },
                values: new object[] { 5, "Bravo", "Calle 9 N2946", "39876453", "cliente@gmail.com", "Jose", "1136756432" });

            migrationBuilder.InsertData(
                table: "Veterinaria",
                columns: new[] { "VeterinariaId", "Direccion", "Nombre", "Telefono" },
                values: new object[] { 1, "Av. San martin 382", "Pet's Life", "4256-2351" });

            migrationBuilder.InsertData(
                table: "Consultorio",
                columns: new[] { "ConsultorioId", "Numero", "VeterinariaId" },
                values: new object[,]
                {
                    { 1, 100, 1 },
                    { 2, 101, 1 },
                    { 3, 200, 1 },
                    { 4, 201, 1 },
                    { 5, 202, 1 }
                });

            migrationBuilder.InsertData(
                table: "Veterinario",
                columns: new[] { "VeterinarioId", "Apellido", "ConsultorioId", "Dni", "Domicilio", "Email", "FechaNacimiento", "Matricula", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 2, "Diaz", 1, "42132121", "Calle 21 231", "veterinario2@gmail.com", "14-9-1990", "ADS213", "Juan", "m", "42113212" });

            migrationBuilder.InsertData(
                table: "Veterinario",
                columns: new[] { "VeterinarioId", "Apellido", "ConsultorioId", "Dni", "Domicilio", "Email", "FechaNacimiento", "Matricula", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 3, "Perez", 2, "321321321", "Calle 132 7654", "veterinario3@gmail.com", "28-3-1958", "XSD213", "Martina", "f", "4232136" });

            migrationBuilder.InsertData(
                table: "Veterinario",
                columns: new[] { "VeterinarioId", "Apellido", "ConsultorioId", "Dni", "Domicilio", "Email", "FechaNacimiento", "Matricula", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 4, "Martinez", 3, "25432567", "Calle 252 532", "veterinario4@gmail.com", "12-1-1974", "TDQ231", "Claudio", "m", "42562132" });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ClienteId",
                table: "Cliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultorio_ConsultorioId",
                table: "Consultorio",
                column: "ConsultorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultorio_VeterinariaId",
                table: "Consultorio",
                column: "VeterinariaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_HistoriaClinicaId",
                table: "HistoriasClinicas",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriasClinicas_MascotaId",
                table: "HistoriasClinicas",
                column: "MascotaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_ClienteId",
                table: "Mascota",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_MascotaId",
                table: "Mascota",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_HistoriaClinicaId",
                table: "Registros",
                column: "HistoriaClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_RegistroId",
                table: "Registros",
                column: "RegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Tratamiento_RegistroId",
                table: "Tratamiento",
                column: "RegistroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turno_MascotaId",
                table: "Turno",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_TurnoId",
                table: "Turno",
                column: "TurnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_VeterinarioId",
                table: "Turno",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinaria_VeterinariaId",
                table: "Veterinaria",
                column: "VeterinariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Veterinario_ConsultorioId",
                table: "Veterinario",
                column: "ConsultorioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veterinario_VeterinarioId",
                table: "Veterinario",
                column: "VeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tratamiento");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropTable(
                name: "HistoriasClinicas");

            migrationBuilder.DropTable(
                name: "Consultorio");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Veterinaria");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
