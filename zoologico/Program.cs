using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool abandonar = false;
            Console.WriteLine("Bienvenido al Zooologico virtual la Aurora "); 
            Console.WriteLine(" ");
            do
            {
                Console.WriteLine("0.  Abandonar sitio   ");
                Console.WriteLine("1. Leon ");
                Console.WriteLine("2. Elefante ");
                Console.WriteLine("3. Jirafa ");
                Console.WriteLine("4. Tigre ");
                Console.WriteLine("5. Mono ");
                Console.WriteLine("6  Oso ");
                Console.WriteLine("7. Cocodrilo ");
                Console.WriteLine("8. Serpiente");
                Console.WriteLine("9. Pinguino ");
                Console.WriteLine("10. Lobo ");
                Console.WriteLine("11. Cebra  ");
                Console.WriteLine("12. Rinoceronte   ");
                Console.WriteLine("13. Panda ");
                Console.WriteLine("14. Pavo Real  ");
                Console.WriteLine("15. Tortuga  ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {

                    case 0: abandonar = true; break;
                    case 1: verLeon(); break;
                    case 2: verElefante(); break;
                    case 3: verJirafa(); break;
                    case 4: verTigre(); break;
                    case 5: verMono(); break;
                    case 6: verOso(); break;
                    case 7: verCocodrilo(); break;
                    case 8: verSerpiente(); break;
                    case 9: verPinguino(); break;
                    case 10: verLobo(); break;
                    case 11: verCebra(); break;
                    case 12: verRinoceronte(); break;
                    case 13: verPanda(); break;
                    case 14: verPavoReal(); break;
                    case 15: verTortuga(); break;
                    default: Console.WriteLine("Has ingresado una opcion invalida"); break;

                }
                Console.ReadLine();
            } while (!abandonar);
            Console.WriteLine("vuelve pronto");
            Console.ReadLine();
        }
        static void verLeon()
        {
           Animales  leon = new Animales("Simba", "Macho");
            Console.WriteLine("Bienvenidos a la jaula del Leon un felino de mucha fuerza, realeza  y poder  ");
            leon.Rugir();
            leon.Alimentar();
            leon.comportamiento();
          
        }

        static void verJirafa()
        {
            Jirafa jirafa = new Jirafa("Melida", "Hembra");
            Console.WriteLine("Bienvenidos a la jaula de la jirafa un animal que lo caracteriza la pacencia y la perseverancia ");
            jirafa.Alimentar();
            jirafa.comportamiento();

        }

        static void verElefante()
        {
            Elefante elefante = new Elefante("Vela", "Hembra");
            Console.WriteLine("Bienvenidos a la jaula del elefante un animal que representa  mucha fortaleza ");
            elefante.Alimentar();
            elefante.comportamiento();

        }

        static void verTigre()
        {
            Tigre tigre = new Tigre(" Cobu", " Macho");
            Console.WriteLine("Bienvenidos a la jaula del tigre, representa valentia y constancia");
            tigre.Alimentar();
            tigre.comportamiento();
        }
         
       static void verMono()
        {
            Mono mono = new Mono("sasu ", "Macho");
            Console.WriteLine("Bienvenidos  a la jaula del mono un animal con mucha inteligencia ");
            mono.Alimentar();
            mono.comportamiento();
            
        }
        static void verOso()
        {
            Oso oso = new Oso(" Vapor ", "Macho");
            Console.WriteLine("Bienvenidos a la jaula del oso simbolo del poder y coraje");
            oso.Alimentar ();
            oso.comportamiento();
         
        }

        static void verCocodrilo()
        {
            Cocodrilo cocodrilo = new Cocodrilo("tefiti", "Hembra");
            Console.WriteLine("Bienvido a la jaula del cocodrilo simbolo de la prudencia y rectitud en el mundo onirico  ");
            cocodrilo.Alimentar();
            cocodrilo.comportamiento();
           
        }

        static void verSerpiente()
        {
            Serpiente serpiente = new Serpiente("Zafira", "hembra");
            Console.WriteLine(" Bienvenido a la jaula de la serpiente que representa sabiduria y prudencia");
            serpiente.Alimentar();
            serpiente.comportamiento();
         
        }

        static void verPinguino()
        {
            Pinguino pinguino = new Pinguino("stif", "Macho");
            Console.WriteLine(" Bienvenidos a la jaula del pingüino simbolo de la fidelidad y amor ");
            pinguino.Alimentar();
            pinguino.comportamiento();
         
         }
        static void  verLobo()
        {
            Lobo lobo = new Lobo("ruffi", "Macho");
            Console.WriteLine( "Bienvenido a la jaula del lobo simbolo del poder ");
            lobo.Alimentar();
            lobo.comportamiento();

        }

        static void verCebra()
        {
            Cebra cebra = new Cebra("Lali", "Hembra");
            Console.WriteLine("Bienvenido a la jaula  de la cebra  simbolo de la libertad ");
            cebra.Alimentar();
            cebra.comportamiento();

        }

        static void verRinoceronte()
        {
            Rinoceronte rinoceronte = new Rinoceronte("Paco", "Macho");
            Console.WriteLine("Bienvenido a la jaula del rinoceronte  que lo identifica la proteccion y la ambicion ");
            rinoceronte.Alimentar();
            rinoceronte.comportamiento();


        }

        static void verPanda()
        {
            Panda panda= new Panda("Mani", "Macho");
            Console.WriteLine("Bienvenido a la jaula del panda simbolo de la prosperidad y buena suerte ");
            panda.Alimentar();
            panda.comportamiento();
        }

        static void verPavoReal()
        {
            PavoReal pavoReal = new PavoReal("Alenka", "Hembra");
            Console.WriteLine("Bienvenido a la jaula del Pavo Real simbolo de la belleza y amor propio ");
            pavoReal.Alimentar();
            pavoReal.comportamiento();
        }

        static void verTortuga()
        {
            Tortuga tortuga = new Tortuga("kristal", "Hembra");
            Console.WriteLine("Bienvenido a la jaula de la tortuga simbolo de la sabiduria y paciencia ");
            tortuga.Alimentar();
            tortuga.comportamiento();

        }


    }

}
