using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class ConsultorProcesosMedicos : Usuario
    {
        protected string experiencia {  get; set; }
        public ConsultorProcesosMedicos(int id, string nombre, string email, string experiencia) : base(id, nombre, email)
        {
            this.experiencia = experiencia;
        }

        public void Configurar()
        {

        }

        public void Personalizar()
        {

        }

        public void DefinirProtocolos()
        {

        }


    }
}
