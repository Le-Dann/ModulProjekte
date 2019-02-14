using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Zeppelin : Luftfahrzeug
    {
        /// <summary>
        /// Gas volume
        /// </summary>
        public double Gasvolumen { get; set; }

        /// <summary>
        /// Basis constructor
        /// </summary>
        public Zeppelin(): this("",0,0.0)
        {

        }

        /// <summary>
        /// Second constructor
        /// </summary>
        /// <param name="hersteller">manufaturer</param>
        /// <param name="baujahr">date of manufacture</param>
        /// <param name="gasvolumen">gas volume</param>
        public Zeppelin(string hersteller, int baujahr, double gasvolumen)
            :base(hersteller,baujahr)
        {

            Gasvolumen = gasvolumen;
        }

        /// <summary>
        /// Zepplin takes off
        /// </summary>
        public override void Starten()
        {
            Console.WriteLine("Zepplin taken off");
        }

        /// <summary>
        /// Zepplin lands
        /// </summary>
        public override void Landen()
        {
            Console.WriteLine("Zepplin landed");
        }

        public override string ToString()
        {
            return $"This is a zepplin {base.ToString()}\t\tGasvolumen {Gasvolumen.ToString()}";
        }
    }
}
