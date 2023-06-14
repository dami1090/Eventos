using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGGG
{
    public class Usuario
    {
        public event DelegadoString EventoString;
        private string apellido;
        private string nombre;

        public Usuario()
        {
            Apellido = string.Empty;
            Nombre = string.Empty;
        }
        public delegate void DelegadoString(string msg);
        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value != "")
                {
                    apellido = value;
                    if (!(EventoString is null))
                    {
                        EventoString.Invoke("El apellido es :" + apellido);
                    }
                }

            }
         }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != "")
                {
                    nombre = value;
                    if (!(EventoString is null))
                    {
                        EventoString.Invoke("El nombre es :" + nombre);
                    }
                }

            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido}");
            return sb.ToString();
        }
    }
}
