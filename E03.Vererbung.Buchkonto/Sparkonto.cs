using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Vererbung.Buchkonto
{
    /// <summary>
    /// Savings account
    /// </summary>
   public class Sparkonto : Konto
    {
        /// <summary>
        /// Basis class for a savings account
        /// </summary>
        public Sparkonto() : base(0, "", 500)
        {

        }

        /// <summary>
        /// second calss
        /// </summary>
        /// <param name="number">account number</param>
        public Sparkonto(int number) : base(number, "", 500)
        {

        }

        /// <summary>
        /// third construcotr
        /// </summary>
        /// <param name="number">account number</param>
        /// <param name="name">account name</param>
        public Sparkonto(int number, string name) : base(number, name, 500)
        {

        }

        /// <summary>
        /// Forth constructor
        /// </summary>
        /// <param name="number">account number</param>
        /// <param name="name">account name</param>
        /// <param name="limit">withdrawal limit</param>
        public Sparkonto(int number, string name, double limit = 500) : base(number,name,limit)
        {
     
        }

        /// <summary>
        /// Deposits money to account
        /// </summary>
        /// <param name="amount">amount to be deposited</param>
        public override void PayIn(double amount)
        {
            base.PayIn(amount);
        }

        /// <summary>
        /// Withdraws money from account
        /// </summary>
        /// <param name="amount">Amount to be withdrawn</param>
        public override void PayOut(double amount)
        {
            if (amount >= _balance)
            {
                throw new KtoException(-1,$"The amount {amount} can not be withdrawed. Current Balance: {Balance}");
            }
            else if (amount > Limit)
            {
                throw new KtoException(-2, $"This amount goes over the withdrawal limit: {Limit}");
            }
            else if (amount <= 0.0)
            {
                throw new KtoException(-4, "Negativen Werten gilten nicht für Auszahlen");
            }
            else
            {
                base.PayOut(amount);
            }
        }

    }
}
