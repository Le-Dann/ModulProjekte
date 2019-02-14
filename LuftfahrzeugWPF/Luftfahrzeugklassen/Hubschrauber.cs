using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Hubschrauber : Luftfahrzeug
    {
        /// <summary>
        /// Rotor diameter
        /// </summary>
        public double RotorDurchmesser { get; set; }

        /// <summary>
        /// basis constructor
        /// </summary>
        public Hubschrauber():this("",0,0.0)
        {

        }

        /// <summary>
        /// second constructor
        /// </summary>
        /// <param name="hersteller">manufacturer</param>
        /// <param name="baujahr">date of manufacture</param>
        /// <param name="rotordurchmesser">rotor diameter</param>
        public Hubschrauber(string hersteller, int baujahr, double rotordurchmesser)
            :base(hersteller,baujahr)
        {
         
            RotorDurchmesser = rotordurchmesser;
        }

        /// <summary>
        /// helicopter lands
        /// </summary>
        public override void Landen()
        {
            Console.WriteLine("Helicopter landed"); ;
        }

        /// <summary>
        /// helicopter takes off
        /// </summary>
        public override void Starten()
        {
            Console.WriteLine("Helicopter taken off"); ;
        }

        public override string ToString()
        {
            return $"Its a helicopter {base.ToString()}\t\tRotordurchmesser {RotorDurchmesser.ToString()}";
        }
    }
}
