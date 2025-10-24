using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediPlan.Models
{
    public abstract class Usuario:IComparable
    {
        protected int id {  get; set; }
        protected string nombre { get; set; }
        protected string email { get; set; }

        public Usuario(int id, string nombre, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
        }
        public bool LogIn()
        {
            Console.WriteLine($"Usuario {this.nombre} ha iniciado sesión.");
            return true;
        }

        public void LogOut()
        {
            Console.WriteLine($"Usuario {this.nombre} ha cerrado sesión.");
        }

        public int CompareTo(object obj)
        {
            Usuario nuevoUsuario = obj as Usuario;
            if(nuevoUsuario != null)
            {
                return this.id.CompareTo(nuevoUsuario.id);
            }
            return -1;
        }
    }
}
