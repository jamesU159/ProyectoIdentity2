using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUME.Models
{
    public class TurnoLaboral
    {
        [Key]
        public int IdConsulta { get; set; }
        public TimeSpan HoraIngreso { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int JornadaIdJornada { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Jornada JornadaIdJornadaNavigation { get; set; }
    }
}
