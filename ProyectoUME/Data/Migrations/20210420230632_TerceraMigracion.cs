using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoUME.Data.Migrations
{
    public partial class TerceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUsuarioNavigationId",
                table: "TurnoLaboral",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdTramiteNavigationId",
                table: "Permiso",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuariosNavigationId",
                table: "Excusa",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdTramiteNavigationId",
                table: "Documentos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaNitNavigationNit",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProyectoNavigationIdProyecto",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JornadaNavigationIdJornada",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TurnoLaboral_IdUsuarioNavigationId",
                table: "TurnoLaboral",
                column: "IdUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoLaboral_JornadaIdJornada",
                table: "TurnoLaboral",
                column: "JornadaIdJornada");

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_IdTramiteNavigationId",
                table: "Permiso",
                column: "IdTramiteNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Excusa_IdUsuariosNavigationId",
                table: "Excusa",
                column: "IdUsuariosNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_IdTramiteNavigationId",
                table: "Documentos",
                column: "IdTramiteNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmpresaNitNavigationNit",
                table: "AspNetUsers",
                column: "EmpresaNitNavigationNit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IdProyectoNavigationIdProyecto",
                table: "AspNetUsers",
                column: "IdProyectoNavigationIdProyecto");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JornadaNavigationIdJornada",
                table: "AspNetUsers",
                column: "JornadaNavigationIdJornada");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Empresa_EmpresaNitNavigationNit",
                table: "AspNetUsers",
                column: "EmpresaNitNavigationNit",
                principalTable: "Empresa",
                principalColumn: "Nit",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jornada_JornadaNavigationIdJornada",
                table: "AspNetUsers",
                column: "JornadaNavigationIdJornada",
                principalTable: "Jornada",
                principalColumn: "IdJornada",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Proyecto_IdProyectoNavigationIdProyecto",
                table: "AspNetUsers",
                column: "IdProyectoNavigationIdProyecto",
                principalTable: "Proyecto",
                principalColumn: "IdProyecto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documentos_AspNetUsers_IdTramiteNavigationId",
                table: "Documentos",
                column: "IdTramiteNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Excusa_AspNetUsers_IdUsuariosNavigationId",
                table: "Excusa",
                column: "IdUsuariosNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permiso_AspNetUsers_IdTramiteNavigationId",
                table: "Permiso",
                column: "IdTramiteNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnoLaboral_AspNetUsers_IdUsuarioNavigationId",
                table: "TurnoLaboral",
                column: "IdUsuarioNavigationId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurnoLaboral_Jornada_JornadaIdJornada",
                table: "TurnoLaboral",
                column: "JornadaIdJornada",
                principalTable: "Jornada",
                principalColumn: "IdJornada",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Empresa_EmpresaNitNavigationNit",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jornada_JornadaNavigationIdJornada",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Proyecto_IdProyectoNavigationIdProyecto",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Documentos_AspNetUsers_IdTramiteNavigationId",
                table: "Documentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Excusa_AspNetUsers_IdUsuariosNavigationId",
                table: "Excusa");

            migrationBuilder.DropForeignKey(
                name: "FK_Permiso_AspNetUsers_IdTramiteNavigationId",
                table: "Permiso");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnoLaboral_AspNetUsers_IdUsuarioNavigationId",
                table: "TurnoLaboral");

            migrationBuilder.DropForeignKey(
                name: "FK_TurnoLaboral_Jornada_JornadaIdJornada",
                table: "TurnoLaboral");

            migrationBuilder.DropIndex(
                name: "IX_TurnoLaboral_IdUsuarioNavigationId",
                table: "TurnoLaboral");

            migrationBuilder.DropIndex(
                name: "IX_TurnoLaboral_JornadaIdJornada",
                table: "TurnoLaboral");

            migrationBuilder.DropIndex(
                name: "IX_Permiso_IdTramiteNavigationId",
                table: "Permiso");

            migrationBuilder.DropIndex(
                name: "IX_Excusa_IdUsuariosNavigationId",
                table: "Excusa");

            migrationBuilder.DropIndex(
                name: "IX_Documentos_IdTramiteNavigationId",
                table: "Documentos");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmpresaNitNavigationNit",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_IdProyectoNavigationIdProyecto",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JornadaNavigationIdJornada",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdUsuarioNavigationId",
                table: "TurnoLaboral");

            migrationBuilder.DropColumn(
                name: "IdTramiteNavigationId",
                table: "Permiso");

            migrationBuilder.DropColumn(
                name: "IdUsuariosNavigationId",
                table: "Excusa");

            migrationBuilder.DropColumn(
                name: "IdTramiteNavigationId",
                table: "Documentos");

            migrationBuilder.DropColumn(
                name: "EmpresaNitNavigationNit",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IdProyectoNavigationIdProyecto",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JornadaNavigationIdJornada",
                table: "AspNetUsers");
        }
    }
}
