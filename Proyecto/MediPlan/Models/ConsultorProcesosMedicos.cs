using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MediPlan.Models
{
    public class ConsultorProcesosMedicos : Usuario
    {
        protected string experiencia {  get; set; }

        private Queue<ProtocoloDerivacion> protocolosDerivacion = new Queue<ProtocoloDerivacion>();

        public ConsultorProcesosMedicos(int id, string nombre, string email, string experiencia) : base(id, nombre, email)
        {
            this.experiencia = experiencia;
        }

        public void CrearProtocolo(ProtocoloDerivacion protocolo)
        {
            protocolosDerivacion.Enqueue(protocolo);
            Console.WriteLine($"Protocolo #{protocolo.IdProtocolo} creado por {this.Nombre}");
        }

        public void EliminarProtocolo(ProtocoloDerivacion protocolo)
        {
            protocolo = protocolosDerivacion.Dequeue();
            Console.WriteLine($"Protocolo #{protocolo.IdProtocolo} eliminado por {this.Nombre}");
        }

        public ProtocoloDerivacion VerProtocolo()
        {
            ProtocoloDerivacion protocolo = null;
            if(protocolosDerivacion.Count > 0)
            {
                return protocolo;
            }
            return protocolo;

        }

        public void ModificarProtocolo(ProtocoloDerivacion protocolo, string origen, string condiciones, int prioridad,string destino)
        {
            if (origen != null) protocolo.Origen = origen;
            if (condiciones != null) protocolo.Condiciones = condiciones;
            if (prioridad != null) protocolo.Prioridad= prioridad;
            if (destino != null) protocolo.Destino = destino;

            Console.WriteLine($"Protocolo #{protocolo.IdProtocolo} modificado por {this.Nombre}");
        }


    }
}
