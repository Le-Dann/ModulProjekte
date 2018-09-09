using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Vererbung.Buchkonto
{
    /// <summary>
    /// Account class
    /// </summary>
    public abstract class Konto
    {
        /// <summary>
        /// Account balance
        /// </summary>
        protected double _balance;

        public double Balance
        {
            get { return _balance; }
          
        }

        /// <summary>
        /// Date account was changed
        /// </summary>
        protected DateTime _changedDate;

        public DateTime ChangedDate
        {
            get { return _changedDate; }

        }

        /// <summary>
        /// Date account was created
        /// </summary>
        protected DateTime _createdDate;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
           
        }

        /// <summary>
        /// Wothdrawal limit
        /// </summary>
        /// <remarks> Default limit is 500</remarks>
        protected double _limit = 500;

        public double Limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        /// <summary>
        /// Account name
        /// </summary>
        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Account number
        /// </summary>
        protected int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        /// <summary>
        /// Dispo value
        /// </summary>
        /// <remarks> Default value is -1000</remarks>
        private double _dispValue = -1000;

        public double DispValue
        {
            get { return _dispValue; }
            set { _dispValue = value; }
        }

        private List<Transaktion> transaktionen;

        public List<Transaktion> Transaktionen
        {
            get { return transaktionen; }
            set { transaktionen = value; }
        }



        /// <summary>
        /// basis class
        /// </summary>
        public Konto() : this(0,"",500)
        {

        }

        /// <summary>
        /// second calss
        /// </summary>
        /// <param name="number">account number</param>
        public Konto(int number) : this(number,"",500)
        {

        }

        /// <summary>
        /// third construcotr
        /// </summary>
        /// <param name="number">account number</param>
        /// <param name="name">account name</param>
        public Konto(int number, string name): this (number,name,500)
        {

        }

        /// <summary>
        /// Forth constructor
        /// </summary>
        /// <param name="number">account number</param>
        /// <param name="name">account name</param>
        /// <param name="limit">withdrawal limit</param>
        public Konto(int number, string name, double limit=500)
        {
            Number = number;
            Name = name;
            Limit = limit;
        }

        /// <summary>
        /// Deposit money to account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public virtual void PayIn(double amount)
        {
            if (amount > 0.0)
            {
                Console.WriteLine($"Balance was {Balance}. Current balance {_balance += amount} ");
                _changedDate = DateTime.Now;
            }
            else
            {
                throw new KtoException(-3, "Negativen Wert gilt nicht für Einzahlen");
            }
            
        }

        /// <summary>
        /// Withdraw from account
        /// </summary>
        /// <param name="amount">Amount to be withdrawed</param>
        public virtual void PayOut(double amount)
        {
            _balance -= amount;
            _changedDate = DateTime.Now;
            Console.WriteLine($"The amount {amount} has been withdrawn from your account. Current balance: {Balance}");
        }




    }
}
