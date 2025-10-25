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
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Usuario(int id, string nombre, string email)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Email = email;
        }
        public bool LogIn()
        {
            Console.WriteLine($"Usuario {this.Nombre} ha iniciado sesión.");
            return true;
        }

        public void LogOut()
        {
            Console.WriteLine($"Usuario {this.Nombre} ha cerrado sesión.");
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
