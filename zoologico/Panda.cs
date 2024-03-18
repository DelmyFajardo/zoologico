using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Panda
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public Panda (string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "Sexo: " + Sex;
        }

        public void Alimentar()
        {
            Console.WriteLine(" Principalmente comen bambu ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: son animales solitarios ");
        }
    }
}
