using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Vererbung.Buchkonto
{
    public class Bank
    {
        /// <summary>
        /// Bank Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Bank location
        /// </summary>
        public string Ort { get; set; }

        /// <summary>
        /// List of accounts at the bank
        /// </summary>
        private List<Konto> kontos;

        public List<Konto> Kontos
        {
            get { return kontos; }
            set { kontos = value; }
        }



        public Bank() : this("","")
        {

        }

        public Bank(string name, string ort)
        {
            Name = name;
            Ort = ort;
        }
    }
}
