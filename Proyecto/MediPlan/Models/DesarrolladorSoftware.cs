using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class DesarrolladorSoftware : IMantenible
    {
        private string nombre;
        private string rol;

        public DesarrolladorSoftware(string nombre, string rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        public void CorregirErrores(string descripcion)
        {
            throw new NotImplementedException();
        }

        public void NuevaFuncionalidad(string funcionalidad)
        {
            throw new NotImplementedException();
        }
    }
}
