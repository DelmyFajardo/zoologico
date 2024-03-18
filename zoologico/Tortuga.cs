using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Tortuga
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public Tortuga(string nombre, string sex)
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
            Console.WriteLine("sus alimentacion esta basada en  lechugas, acelgas, escarola, cangrejos entre otros. ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: son criaturas que viajan en grupo y algunas son solitarias ");
        }
    }
}
