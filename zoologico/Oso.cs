using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Oso
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }
        public Oso(string nombre, string sex)
        {
            Nombre = nombre;
            Sex = sex;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre +  "Sexo: "+ Sex;
        }

        public void  Alimentar()
        {
            Console.WriteLine("los osos son omnivoros  comen frutos, insectos y carne ");
        }

        public void comportamiento()
        {
            Console.WriteLine(" Tiene un consucta muy particular con aspecto imponente pero solidarios "); 
        }

    }
  
}
