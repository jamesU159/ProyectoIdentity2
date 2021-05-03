﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoUME.Data;

namespace ProyectoUME.Data.Migrations
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ProyectoUME.Models.Documento", b =>
                {
                    b.Property<int>("IdTramite")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificadoArl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoEps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificadoPension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursoAlturas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("HojaVida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTramiteNavigationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdTramite");

                    b.HasIndex("IdTramiteNavigationId");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("ProyectoUME.Models.Empresa", b =>
                {
                    b.Property<int>("Nit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nit");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("ProyectoUME.Models.Excusa", b =>
                {
                    b.Property<int>("IdExcusa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnexoEvidencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellodo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuariosNavigationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExcusa");

                    b.HasIndex("IdUsuariosNavigationId");

                    b.ToTable("Excusa");
                });

            modelBuilder.Entity("ProyectoUME.Models.Jornada", b =>
                {
                    b.Property<int>("IdJornada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Jornada1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJornada");

                    b.ToTable("Jornada");
                });

            modelBuilder.Entity("ProyectoUME.Models.Permisos", b =>
                {
                    b.Property<int>("IdPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuarioNavigationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPermiso");

                    b.HasIndex("IdUsuarioNavigationId");

                    b.ToTable("Permiso");
                });

            modelBuilder.Entity("ProyectoUME.Models.Proyecto", b =>
                {
                    b.Property<int>("IdProyecto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DireccionPoyecto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroEmpleados")
                        .HasColumnType("int");

                    b.Property<string>("PersonaResponsable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProyecto");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("ProyectoUME.Models.TurnoLaboral", b =>
                {
                    b.Property<int>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("HoraIngreso")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSalida")
                        .HasColumnType("time");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuarioNavigationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("JornadaIdJornada")
                        .HasColumnType("int");

                    b.HasKey("IdConsulta");

                    b.HasIndex("IdUsuarioNavigationId");

                    b.HasIndex("JornadaIdJornada");

                    b.ToTable("TurnoLaboral");
                });

            modelBuilder.Entity("ProyectoUME.Models.Usuario", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Cedula")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int?>("EmpresaNitNavigationNit")
                        .HasColumnType("int");

                    b.Property<int?>("IdProyectoNavigationIdProyecto")
                        .HasColumnType("int");

                    b.Property<int?>("JornadaNavigationIdJornada")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("EmpresaNitNavigationNit");

                    b.HasIndex("IdProyectoNavigationIdProyecto");

                    b.HasIndex("JornadaNavigationIdJornada");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoUME.Models.Documento", b =>
                {
                    b.HasOne("ProyectoUME.Models.Usuario", "IdTramiteNavigation")
                        .WithMany()
                        .HasForeignKey("IdTramiteNavigationId");

                    b.Navigation("IdTramiteNavigation");
                });

            modelBuilder.Entity("ProyectoUME.Models.Excusa", b =>
                {
                    b.HasOne("ProyectoUME.Models.Usuario", "IdUsuariosNavigation")
                        .WithMany("Excusa")
                        .HasForeignKey("IdUsuariosNavigationId");

                    b.Navigation("IdUsuariosNavigation");
                });

            modelBuilder.Entity("ProyectoUME.Models.Permisos", b =>
                {
                    b.HasOne("ProyectoUME.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Permiso")
                        .HasForeignKey("IdUsuarioNavigationId");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("ProyectoUME.Models.TurnoLaboral", b =>
                {
                    b.HasOne("ProyectoUME.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("TurnoLaboral")
                        .HasForeignKey("IdUsuarioNavigationId");

                    b.HasOne("ProyectoUME.Models.Jornada", "JornadaIdJornadaNavigation")
                        .WithMany("TurnoLaboral")
                        .HasForeignKey("JornadaIdJornada")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUsuarioNavigation");

                    b.Navigation("JornadaIdJornadaNavigation");
                });

            modelBuilder.Entity("ProyectoUME.Models.Usuario", b =>
                {
                    b.HasOne("ProyectoUME.Models.Empresa", "EmpresaNitNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("EmpresaNitNavigationNit");

                    b.HasOne("ProyectoUME.Models.Proyecto", "IdProyectoNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdProyectoNavigationIdProyecto");

                    b.HasOne("ProyectoUME.Models.Jornada", "JornadaNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("JornadaNavigationIdJornada");

                    b.Navigation("EmpresaNitNavigation");

                    b.Navigation("IdProyectoNavigation");

                    b.Navigation("JornadaNavigation");
                });

            modelBuilder.Entity("ProyectoUME.Models.Empresa", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectoUME.Models.Jornada", b =>
                {
                    b.Navigation("TurnoLaboral");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectoUME.Models.Proyecto", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectoUME.Models.Usuario", b =>
                {
                    b.Navigation("Excusa");

                    b.Navigation("Permiso");

                    b.Navigation("TurnoLaboral");
                });
#pragma warning restore 612, 618
        }
    }
}
