using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "w"; 

            Hangar hangar = new Hangar("Joes Place", "Canada");

            Flugzeug flugzeug1 = new Flugzeug("Mercedes", 1998, 33.33);

            flugzeug1.Power = new Motor("Super charged", "bleh");

            Zeppelin zeppelin1 = new Zeppelin("Rolls Royce", 2001, 66.66);
            zeppelin1.Power = new Motor("kinda charged", "meh");

            Hubschrauber hubschrauber1 = new Hubschrauber("Mazda", 1960, 44.44);
            hubschrauber1.Power = new Motor("charged", "leh");

            hangar.Luftfahrzeuge.Add(flugzeug1);
            hangar.Luftfahrzeuge.Add(zeppelin1);
            hangar.Luftfahrzeuge.Add(hubschrauber1);

            foreach (var zeug in hangar.Luftfahrzeuge)
            {
                Console.WriteLine(zeug.ToString());
            }

            do
            {
            Console.WriteLine("S: start all planes \t\t L:Land all planes");
            string status = Console.ReadLine();

            if (status == "s")
            {
               answer = hangar.Startall();
                    Console.WriteLine(answer);
            }
            else if(status == "l")
            {
                 answer = hangar.Landall();
                    Console.WriteLine(answer);
            }
            else
            {
                answer = "w";
            }

            } while (answer != "w");

            
        }

    }
}
