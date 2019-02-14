using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Flugzeug : Luftfahrzeug
    {
        /// <summary>
        /// span width of plane
        /// </summary>
        public double Spannweite { get; set; }

        /// <summary>
        /// base constructor
        /// </summary>
        public Flugzeug(): this("",0,0.0)
        {

        }

        /// <summary>
        /// second constructor
        /// </summary>
        /// <param name="hersteller">manufacturer</param>
        /// <param name="baujahr">date of manufacture</param>
        /// <param name="spannweite">plane width</param>
        public Flugzeug(string hersteller,int baujahr, double spannweite)
            :base(hersteller,baujahr)
        {
            Spannweite = spannweite;
        }

        /// <summary>
        /// Returnds object string
        /// </summary>
        /// <returns>object string</returns>
        public override string ToString()
        {
            return $"It's a plane: {base.ToString()}\t\t Spannweite: {Spannweite}";
        }

        /// <summary>
        /// Start airplane
        /// </summary>
        public override void Starten()
        {
            Console.WriteLine("Airplane taken off");
        }

        /// <summary>
        /// Land airplane
        /// </summary>
        public override void Landen()
        {
            Console.WriteLine("Airplane landed");
        }
    }
}
