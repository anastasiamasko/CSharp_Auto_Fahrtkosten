using FirstClass;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pkw auto1 = new Pkw("Astra", 7.2, 50);//Vignette muss gekauft werden
            //Pkw auto2 = new Pkw("As", 7.2, 50, true); // Vignette schon vorhanden
            //Lkw auto3 = new Lkw("MAN", 19.4, 310, 4);
            //auto1.Fahren(150,true);
            //auto2.Fahren(150, true);
            //auto3.Fahren(150, true);


            var fahrzeuge = new List<Auto>
            {
                new Pkw("Astra", 7.2, 50),//Vignette muss gekauft werden
                new Pkw("As", 7.2, 50, true), // true=Vignette schon vorhanden
                new Lkw("MAN", 19.4, 310, 4)
            };

            foreach (var fahrzeug in fahrzeuge)
            {
                fahrzeug.Tuev();
                fahrzeug.Fahren(150, true);
                Console.WriteLine($"Die Fahrtkosten vom {fahrzeug.Model} betragen {Convert.ToString(fahrzeug.Fahrtkosten)}.");
            }

            //Console.WriteLine($"Die Fahrtkosten mit Vignette vom {auto1.Model} betragen {Convert.ToString(auto1.Fahrtkosten)}.");
            //Console.WriteLine($"Die Fahrtkosten ohne Vignette vom {auto2.Model} betragen {Convert.ToString(auto2.Fahrtkosten)}.");
            //Console.WriteLine($"Die Fahrtkosten vom {auto3.Model} betragen {Convert.ToString(auto3.Fahrtkosten)}.");


        }
    }
}
