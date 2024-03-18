using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Rinoceronte
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public Rinoceronte(string nombre, string sex)
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
            Console.WriteLine(" su alimentacion esta basada en  ramas, hojas y arbustos ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: animal solitario y territorial ");
        }
    }
}
