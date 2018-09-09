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
        /// Account which made transaktion
        /// </summary>
        public Konto Transkonto { get; set; }

        /// <summary>
        /// Date of transaction
        /// </summary>
        public DateTime Transdate { get; set; }

        /// <summary>
        /// Amount of money transacted
        /// </summary>
        public double Amount { get; set; }
    }
}
