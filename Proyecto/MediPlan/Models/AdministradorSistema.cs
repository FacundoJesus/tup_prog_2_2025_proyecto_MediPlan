using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public abstract class AdministradorSistema : Usuario
    {
        protected AdministradorSistema(int id, string nombre, string email) : base(id, nombre, email)
        {
        }

        public void ConfigurarParametros()
        {

        }

        public Reporte GenerarReporte(string tipo)
        {

        }
    }
}
