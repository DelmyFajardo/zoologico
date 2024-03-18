using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Cocodrilo
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }

        public Cocodrilo(string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "sexo: " + Sex;
        }

        public void Alimentar()
        {
            Console.WriteLine("Son animales carnivoros comen oeces, crustaceos, moluscos, aves y mamiferos "); 
        }
        public  void comportamiento()
        {
            Console.WriteLine("Muestran su furia cuando son molestados "); 
        }

    }
}
