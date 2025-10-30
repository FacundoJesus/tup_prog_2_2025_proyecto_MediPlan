using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class Paciente:Usuario
    {
        private HistorialMedico historial;

        public Paciente(int id,string nombre, string email) : base(id, nombre, email) { }

        public void ReservarCita(CitaMedica cita)
        {

        }

        public void CancelarCita(CitaMedica cita)
        {

        }

        public List<CitaMedica> ListarCitas() {

        }

        public HistorialMedico GetHistorialMedico()
        {
            return historial;
        }
    }
}
