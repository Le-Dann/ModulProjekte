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

   /* public static string GetPropertyDisplayName(object descriptor)
        {
            var pd = descriptor as PropertyDescriptor;

            if (pd != null)
            {
                // Check for DisplayName attribute and set the column header accordingly
                var displayName = pd.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;

                if (displayName != null && displayName != DisplayNameAttribute.Default)
                {
                    return displayName.DisplayName;
                }

            }
            else
            {
                var pi = descriptor as PropertyInfo;

                if (pi != null)
                {
                    // Check for DisplayName attribute and set the column header accordingly
                    Object[] attributes = pi.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                    for (int i = 0; i < attributes.Length; ++i)
                    {
                        var displayName = attributes[i] as DisplayNameAttribute;
                        if (displayName != null && displayName != DisplayNameAttribute.Default)
                        {
                            return displayName.DisplayName;
                        }
                    }
                }
            }

            return null;
        }*/
    }
}
