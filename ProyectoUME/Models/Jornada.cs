using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class Jornada
    {
        public Jornada()
        {
           TurnoLaboral = new HashSet<TurnoLaboral>();
           Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int IdJornada { get; set; }
        public string Jornada1 { get; set; }

        public virtual ICollection<TurnoLaboral> TurnoLaboral { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
