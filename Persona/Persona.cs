using System;
using System.Text;

namespace Persona
{
    public class Persona
    {
        private string apellido;
        private string nombre;

        public Persona()
        {

        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} {this.Apellido}");
            return sb.ToString();
        }
    }
}
