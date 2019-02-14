using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Luftfahrzeug
    {
        /// <summary>
        /// Date of manufacture
        /// </summary>
        public int Baujahr { get; set; }

        /// <summary>
        /// Maufacturer
        /// </summary>
        public string Hersteller { get; set; }
        /// <summary>
        /// Motor object of aircraft
        /// </summary>
        public Motor Power { get; set; }

        /// <summary>
        /// Lands aircraft
        /// </summary>
        public virtual void Landen()
        {
            Console.WriteLine("Aircraft landed");
        }
        
        /// <summary>
        /// Starts aircraft 
        /// </summary>
        public virtual void Starten()
        {
            Console.WriteLine("Aircraft taken off");
        }

        /// <summary>
        /// Basis constructor
        /// </summary>
        public Luftfahrzeug() : this("", 0) { }

        /// <summary>
        /// Second constructor
        /// </summary>
        /// <param name="hersteller"></param>
        /// <param name="baujahr"></param>
        public Luftfahrzeug(string hersteller, int baujahr)
        {
            Hersteller = hersteller;
            Baujahr = baujahr;
        }

        /// <summary>
        /// Information on Aircraft
        /// </summary>
        /// <returns>aircraft information</returns>
        public override string ToString()
        {
            return $"Hersteller: {Hersteller}\t\t Baujahr: {Baujahr}\t\tPower: {Power.ToString()}";
        }

    }
}
