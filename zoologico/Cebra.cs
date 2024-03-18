using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Cebra
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public Cebra(string nombre, string sex)
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
            Console.WriteLine("su alimentacion esta basada en plantas como hierbas, arbustos, entre otros  ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: son animales sociables y viven en manadas  ");
        }
    }
}
