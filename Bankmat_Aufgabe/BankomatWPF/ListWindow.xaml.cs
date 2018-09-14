using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using E03.Vererbung.Buchkonto;
using System.ComponentModel;
using System.Reflection;

namespace BankomatWPF
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
       public Konto lkonto;

        private List<Transaktion> transaktions = new List<Transaktion>();

        public List<Transaktion> Translist
        {
            get {return transaktions;}
            set {transaktions = value;}
        }

        public ListWindow()
        {
            InitializeComponent();
        }

        public ListWindow(Konto konto) : this()
        {
            lkonto = konto;
            DataContext = lkonto;
            Translist = lkonto.Transaktionen;
         
        }

        private void Gridtranslist_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
           

            if (e.Column.Header.ToString() == "Transtyp")
            {
                e.Column.Header = "Buchungstyp";
                e.Column.Width = 150;
            }

            if (e.Column.Header.ToString() == "Currbalance")
            {
                e.Column.Header = "Saldo";
                e.Column.Width = 150;
            }


            if (e.Column.Header.ToString() == "Amount")
            {
                e.Column.Header = "Betrag";
                e.Column.Width = 150;
            }


            if (e.Column.Header.ToString() == "Transdate")
            {
                e.Column.Header = "Datum";
                e.Column.Width = 150;
            }

        }
    }
}
