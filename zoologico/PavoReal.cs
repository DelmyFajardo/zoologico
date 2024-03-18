using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class PavoReal
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public PavoReal(string nombre, string sex)
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
            Console.WriteLine("su alimentacion es omnivora compuesta por semillas,frutos, plantas, insectos, entre otros ");
        }
        public void comportamiento()
        {
            Console.WriteLine("Comportamiento: son territoriales  ");
        }
    }
}
