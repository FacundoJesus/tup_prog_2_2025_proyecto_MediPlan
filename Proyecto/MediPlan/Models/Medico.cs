using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class Medico:Usuario
    {
        public Medico(int id,string nombre, string email):base(id,nombre, email) { }

        public string ConsultarHistorial(Paciente paciente) {

        }

        public void AtenderPaciente(CitaMedica cita)
        {

        }

        public List<CitaMedica> ListarCitas() {

        }
    }
}
