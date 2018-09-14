using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace E03.Vererbung.Buchkonto
{
    public class Transaktion
    {
        /// <summary>
        /// Date of transaction
        /// </summary>

        [DisplayName("Datum")]
        public DateTime Transdate { get; set; }

        /// <summary>
        /// Amount of money transacted
        /// </summary>

        [DisplayName("Betrag")]
        public double Amount { get; set; }

        /// <summary>     
        /// Current balance of account after transaction
        /// </summary>
        [DisplayName("Saldo")]
        public double Currbalance { get; set; }

        /// <summary>
        /// String showing type of transaction made
        /// </summary>
        [DisplayName("Buchungstyp")]
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
