using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Jirafa
    {
        public string Nombre { get; set; }
        public string Sex { get; set; }
        public Jirafa(string nombre, string sex)
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
            Console.WriteLine("Las jirafas comen hojas ya que son animales herviboros");
        }
        public void comportamiento()
        {
            Console.WriteLine(" el comportamiento de las jirafas es muy tranquio ");
        }


    }
}
