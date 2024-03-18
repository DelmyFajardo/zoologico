using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Pinguino
    {
        public string  Nombre { get; set; }
        public string Sex { get; set; }

        public Pinguino(string nombre, string sex) 
        {
            Nombre = nombre;
            Sex = sex;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + "Sexo" + Sex;
        }
        public void Alimentar()
        {
            Console.WriteLine("su alimentacion se basa en peces, crustaceos eufasidos, calamares  ");
        }

        public void comportamiento()
        {
            Console.WriteLine("  comportamiento:  es muy amigable  ");

        }

    }
}
