using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class Permisos
    {
        [Key]
        public int IdTramite { get; set; }
        public DateTime? Fecha { get; set; }
        public string CursoAlturas { get; set; }
        public string CertificadoEps { get; set; }
        public string CertificadoArl { get; set; }
        public string CertificadoPension { get; set; }
        public string HojaVida { get; set; }

        public virtual Usuario IdTramiteNavigation { get; set; }
    }
}
