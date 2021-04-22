using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class Empresa
    {
        public Empresa()
        {
            Usuario = new HashSet<Usuario>();
        }

        [Key]
        public int Nit { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
