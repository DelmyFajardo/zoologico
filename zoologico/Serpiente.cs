using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Serpiente
    {
        public string Nombre { get; set; }
        public string Sex { get; set;}

        public Serpiente (string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }
        public override string ToString()
        {
            return "Nombre: "+ Nombre + "sexo: "+ Sex;
        }

        public void Alimentar()
        {
            Console.WriteLine("Su alimentacion se basa en ratones, babosas, gusanos, insectos y otras plagas ");
        }

        public void comportamiento()
        {
            Console.WriteLine("  Comportamiento: Son animales timidos  ");
        }
    }
}
