using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public List<string> horariosDisponibles = new List<string>();
        public List<string> diasDisponibles = new List<string>();

        private Queue<CitaMedica> citas = new Queue<CitaMedica>();

        public Agenda(int id) {
            this.Id = id;
        }

        public void AgregarCita(CitaMedica cita)
        {
            citas.Enqueue(cita);
        }

        public void CancelarCita(CitaMedica cita)
        {
            if (citas.Count > 0) {
            citas.Dequeue();
            }
        }

        public Queue<CitaMedica> ListarCitas()
        {
            return citas;
        }

        
    }
}
