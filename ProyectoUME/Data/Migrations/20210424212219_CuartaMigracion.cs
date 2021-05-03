using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoUME.Data.Migrations
{
    public partial class CuartaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permiso_AspNetUsers_IdTramiteNavigationId",
                table: "Permiso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permiso",
                table: "Permiso");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Permiso");

            migrationBuilder.RenameColumn(
                name: "IdTramiteNavigationId",
                table: "Permiso",
                newName: "IdUsuarioNavigationId");

            migrationBuilder.RenameColumn(
                name: "HojaVida",
                table: "Permiso",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "CursoAlturas",
                table: "Permiso",
                newName: "Nombre2");

            migrationBuilder.RenameColumn(
                name: "CertificadoPension",
                table: "Permiso",
                newName: "Nombre1");

            migrationBuilder.RenameColumn(
                name: "CertificadoEps",
                table: "Permiso",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "CertificadoArl",
                table: "Permiso",
                newName: "Apellido2");

            migrationBuilder.RenameColumn(
                name: "IdTramite",
                table: "Permiso",
                newName: "IdUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Permiso_IdTramiteNavigationId",
                table: "Permiso",
                newName: "IX_Permiso_IdUsuarioNavigationId");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Permiso",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdPermiso",
                table: "Permiso",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Apellido1",
                table: "Permiso",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permiso",
                table: "Permiso",
                column: "IdPermiso");

            migrationBuilder.AddForeignKey(
                name: "FK_Permiso_AspNetUsers_IdUsuarioNavigationId",
                table: "Permiso",
                column: "IdUsuarioNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permiso_AspNetUsers_IdUsuarioNavigationId",
                table: "Permiso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permiso",
                table: "Permiso");

            migrationBuilder.DropColumn(
                name: "IdPermiso",
                table: "Permiso");

            migrationBuilder.DropColumn(
                name: "Apellido1",
                table: "Permiso");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Permiso",
                newName: "HojaVida");

            migrationBuilder.RenameColumn(
                name: "Nombre2",
                table: "Permiso",
                newName: "CursoAlturas");

            migrationBuilder.RenameColumn(
                name: "Nombre1",
                table: "Permiso",
                newName: "CertificadoPension");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioNavigationId",
                table: "Permiso",
                newName: "IdTramiteNavigationId");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Permiso",
                newName: "IdTramite");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Permiso",
                newName: "CertificadoEps");

            migrationBuilder.RenameColumn(
                name: "Apellido2",
                table: "Permiso",
                newName: "CertificadoArl");

            migrationBuilder.RenameIndex(
                name: "IX_Permiso_IdUsuarioNavigationId",
                table: "Permiso",
                newName: "IX_Permiso_IdTramiteNavigationId");

            migrationBuilder.AlterColumn<int>(
                name: "IdTramite",
                table: "Permiso",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Permiso",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permiso",
                table: "Permiso",
                column: "IdTramite");

            migrationBuilder.AddForeignKey(
                name: "FK_Permiso_AspNetUsers_IdTramiteNavigationId",
                table: "Permiso",
                column: "IdTramiteNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
