using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoUME.Data.Migrations
{
    public partial class Segunda_migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cedula",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerNombre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    IdTramite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CursoAlturas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoEps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoArl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoPension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HojaVida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.IdTramite);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Nit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Nit);
                });

            migrationBuilder.CreateTable(
                name: "Excusa",
                columns: table => new
                {
                    IdExcusa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnexoEvidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellodo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuarios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excusa", x => x.IdExcusa);
                });

            migrationBuilder.CreateTable(
                name: "Jornada",
                columns: table => new
                {
                    IdJornada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jornada1 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jornada", x => x.IdJornada);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    IdTramite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CursoAlturas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoEps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoArl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificadoPension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HojaVida = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.IdTramite);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    IdProyecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleados = table.Column<int>(type: "int", nullable: false),
                    DireccionPoyecto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonaResponsable = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.IdProyecto);
                });

            migrationBuilder.CreateTable(
                name: "TurnoLaboral",
                columns: table => new
                {
                    IdConsulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoraIngreso = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraSalida = table.Column<TimeSpan>(type: "time", nullable: false),
                    JornadaIdJornada = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnoLaboral", x => x.IdConsulta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Excusa");

            migrationBuilder.DropTable(
                name: "Jornada");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "TurnoLaboral");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrimerNombre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "AspNetUsers");
        }
    }
}
