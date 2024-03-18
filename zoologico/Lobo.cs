using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Lobo
    {
        public string Nombre {  get; set; }
        public string Sex { get; set; }

        public Lobo (string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }
        public override string ToString()
        {
            return "Nombre: "+ Nombre + "Sexo: "+Sex;
        }

        public void Alimentar()
        {
            Console.WriteLine("Son animales carnivoros comen venados, borrgos, antilopes, liebres y roedores ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: Viven en manadas  ");
        }
    }
}
