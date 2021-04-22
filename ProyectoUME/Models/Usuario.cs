using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class Usuario:IdentityUser
    {
        public Usuario()
        {
            Excusa = new HashSet<Excusa>();
            Permiso = new HashSet<Permisos>();
            TurnoLaboral = new HashSet<TurnoLaboral>();
        }

        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Cedula { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }

        public virtual Empresa EmpresaNitNavigation { get; set; }
        public virtual Proyecto IdProyectoNavigation { get; set; }
        public virtual Jornada JornadaNavigation { get; set; }
        public virtual ICollection<Excusa> Excusa { get; set; }
        public virtual ICollection<Permisos> Permiso { get; set; }
        public virtual ICollection<TurnoLaboral> TurnoLaboral { get; set; }

    }
}
