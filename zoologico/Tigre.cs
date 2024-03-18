using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Tigre
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }
        public Tigre(string nombre, string sex)
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
            Console.WriteLine("Son animales carnivoros comen jabalis, ciervos, bufalo y jaguajes");
        }

        public void comportamiento ()
        {
            Console.WriteLine(" sus comportamiento se basa en estar  solitarios  ");
        }

    }
}
