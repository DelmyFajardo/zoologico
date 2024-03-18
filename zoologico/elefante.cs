using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Elefante
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }
        public Elefante(string nombre, string sex)
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
            Console.WriteLine("los elefantes son animales herviboros es decir comen plantas ");
        }

        public void comportamiento()
        {
            Console.WriteLine(" Sus comportamiento es  muy sociables ");
        }


    }
}
