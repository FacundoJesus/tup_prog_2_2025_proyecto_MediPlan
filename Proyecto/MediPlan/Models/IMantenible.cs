using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public interface IMantenible
    {
        public void Actualizar();
        public void CorregirErrores(string descripcion);
        public void NuevaFuncionalidad(string funcionalidad);
    }
}
