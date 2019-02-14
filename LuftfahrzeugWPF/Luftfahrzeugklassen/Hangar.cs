using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flugzeug
{
    public class Hangar
    {
        /// <summary>
        /// Hangar Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Hangar Location
        /// </summary>
        public string Ort { get; set; }

        /// <summary>
        /// list of aircrafts in hanger
        /// </summary>
        public List<Luftfahrzeug> Luftfahrzeuge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Hangar():this("","")
        {

        }

        public Hangar(string name, string ort)
        {
            Name = name;
            Ort = ort;
            Luftfahrzeuge = new List<Luftfahrzeug>();
        }

        public string Startall()
        {
            foreach (var zeug in Luftfahrzeuge)
            {
                zeug.Starten();
            }
            return "All aircrafts have left the hangar";
        }

        public string Landall()
        {
            foreach (var zeug in Luftfahrzeuge)
            {
                zeug.Landen();
            }
            return "All aircrafts are back in the hangar";
        }


    }
}
