using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class ProtocoloDerivacion
    {
        public int IdProtocolo { get; set; }
        public string Origen {  get; set; }
        public string Destino { get; set; }
        public string Condiciones { get; set; }
        public int Prioridad { get; set; }
        

        public ProtocoloDerivacion(string origen, string destino, string condiciones, int prioridad)
        {
            this.Origen = origen;
            this.Destino = destino;
            this.Condiciones = condiciones;
            this.Prioridad = prioridad;
        }

        public bool ValidarDerivacion()
        {

        }

        
    }
}
