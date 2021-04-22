using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class Proyecto
    {
        public Proyecto()
       {
            Usuario = new HashSet<Usuario>();
       }

        [Key]
        public int IdProyecto { get; set; }
        public int NumeroEmpleados { get; set; }
        public string DireccionPoyecto { get; set; }
        public string PersonaResponsable { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
