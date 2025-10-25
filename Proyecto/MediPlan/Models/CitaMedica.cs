using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class CitaMedica
    {
        public DateTime Fecha { get; set; }

        public TimeOnly Hora { get; set; }

        public string Estado { get; set; }

        public CitaMedica(DateTime fecha, TimeOnly hora, string estado )
        {
            this.Fecha = fecha;
            this.Hora = hora;
            this.Estado = estado;
        }

    }
}
