using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoUME.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoUME.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Excusa> Excusa { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<Permisos> Permiso { get; set; }
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<TurnoLaboral> TurnoLaboral { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        public virtual DbSet<Documento> Documentos { get; set; }
    }
}
