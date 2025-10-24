using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public class Administrativo:Usuario
    {
        public Administrativo(int id, string nombre, string email):base(id,nombre,email) { }

        public void CoordinarAgenda()
        {

        }

        public void GestionarCitas()
        {

        }
    }
}
