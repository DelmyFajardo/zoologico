using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Mono
    {
        public string Nombre { set; get; }
        public string Sex { set; get; }

        public Mono(string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "sexo: " + Sex + "]";
        }
        public void Alimentar()
        {
            Console.WriteLine("Los monos son animales omnivoros comen frutos, semillas, hojas, insectos, entre otros ");
        }

        public void comportamiento()
        {
            Console.WriteLine(" sus comportamiento es muy  social  ");
        }
    }
}
