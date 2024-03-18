using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Animales
    {
        public string Nombre {  get; set; } 
        public string Sex { get; set; }
  
        
        public Animales ( string nombre, string sex)
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
            Console.WriteLine("Los leones son carnivoros  y comen cebras, gacelas o jabalies ");
        }
        public void Rugir()
        {
            Console.WriteLine("Grrrrrrr");
        }
    
        public void comportamiento()
        {
            Console.WriteLine(" su comportamiento es  social en comparacion con otros felinos");

        }








    }
}
