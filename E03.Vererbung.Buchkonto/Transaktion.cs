using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E03.Vererbung.Buchkonto
{
    public class Transaktion
    {
        /// <summary>
        /// Date of transaction
        /// </summary>
        public DateTime Transdate { get; set; }

        /// <summary>
        /// Amount of money transacted
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Current balance of account after transaction
        /// </summary>
        public double Currbalance { get; set; }

        public string Transtyp { get; set; }


        public Transaktion() : this( DateTime.MinValue, 0.0,0.0, "" ) { }

        public Transaktion(DateTime dateTime, double amount, double currbalance, string transtyp)
        {
            Transdate = dateTime;
            Amount = amount;
            Currbalance = currbalance;
            Transtyp = transtyp;
        }
    }
}
