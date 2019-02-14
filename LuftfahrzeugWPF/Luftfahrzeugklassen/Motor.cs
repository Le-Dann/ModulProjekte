using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Motor
    {
        /// <summary>
        /// Motor weight
        /// </summary>
        public int Gewicht { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Hersteller { get; set; }
        public float Leistung { get; set; }
        public string Name { get; set; }

        public Motor() : this("","")
        {

        }

        public Motor(string name, string hersteller)
        {
            Name = name;
            Hersteller = hersteller;
        }

        public override string ToString()
        {
            return $"Hersteller: {Hersteller}\t\tName: {Name}\t\tLeistung: {Leistung.ToString()}";
        }
    }
}
