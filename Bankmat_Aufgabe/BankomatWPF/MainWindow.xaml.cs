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
using System.Windows.Navigation;
using System.Windows.Shapes;
using E03.Vererbung.Buchkonto;

namespace BankomatWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// List of accounts to be stored in data grid
        /// </summary>
        Bank b = new Bank("Bank of America", "Canada");
        

        Sparkonto sparkonto = new Sparkonto();
        Girokonto girokonto = new Girokonto();

        public List<Konto>  Kontos
        {
            get { return b.Kontos; }
            set { b.Kontos = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// button adds new account info. to grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAdd_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow w = new AccountWindow();

            w.Owner = this;
            w.ShowDialog();

            if (w.DialogResult == true)
            {
                if (w.kontotyp == -1)
                {
                    sparkonto = w.sparkonto;
                    Kontos.Add(sparkonto);
                }
                else if (w.kontotyp == 1)
                {
                    girokonto = w.girokonto;
                    Kontos.Add(girokonto);
                }
                DataContext = null;
                DataContext = this;
            }
        }

        private void Butchange_Click(object sender, RoutedEventArgs e)
        {
            int indexval = Gridbank.SelectedIndex;
            sparkonto = Gridbank.SelectedItem as Sparkonto;
            girokonto = Gridbank.SelectedItem as Girokonto;
            AccountWindow w = new AccountWindow(sparkonto);
            w.Owner = this;
            if (sparkonto != null)
            {
                w.ShowDialog();
            }
            else if (girokonto != null)
            {
                w = new AccountWindow(girokonto);
                w.ShowDialog();
            }

            if (w.DialogResult == true)
            {
                if (w.kontotyp == -1)
                {
                    Kontos.Remove(sparkonto);
                    sparkonto = w.sparkonto;
                    Kontos.Insert(indexval,sparkonto);
                }
                else if (w.kontotyp == 1)
                {
                    Kontos.Remove(girokonto);
                    girokonto = w.girokonto;
                    Kontos.Insert(indexval,girokonto);
                }
                DataContext = null;
                DataContext = this;
            }
        }

        private void Buteinzahlen_Click(object sender, RoutedEventArgs e)
        {
            int indexval = Gridbank.SelectedIndex;
            sparkonto = Gridbank.SelectedItem as Sparkonto;
            girokonto = Gridbank.SelectedItem as Girokonto;
            PayWindow p = new PayWindow(sparkonto,1);
            p.Owner = this;
            if (sparkonto != null)
            {
                p.ShowDialog();
            }
            else if (girokonto != null)
            {
                p = new PayWindow(girokonto,1);
                p.ShowDialog();
            }
            if (p.DialogResult == true)
            {
                if (p.kontotyp == -1)
                {
                    Kontos.Remove(sparkonto);
                    sparkonto = p.skonto;
                    Kontos.Insert(indexval, sparkonto);
                }
                else if (p.kontotyp == 1)
                {
                    Kontos.Remove(girokonto);
                    girokonto = p.gkonto;
                    Kontos.Insert(indexval, girokonto);
                }
                DataContext = null;
                DataContext = this;
            }
        }

        private void Butauzahlen_Click(object sender, RoutedEventArgs e)
        {
            int indexval = Gridbank.SelectedIndex;
            sparkonto = Gridbank.SelectedItem as Sparkonto;
            girokonto = Gridbank.SelectedItem as Girokonto;
            PayWindow p = new PayWindow(sparkonto, -1);
            p.Owner = this;
            if (sparkonto != null)
            {
                p.ShowDialog();
            }
            else if (girokonto != null)
            {
                p = new PayWindow(girokonto, -1);
                p.ShowDialog();
            }
            if (p.DialogResult == true)
            {
                if (p.kontotyp == -1)
                {
                    Kontos.Remove(sparkonto);
                    sparkonto = p.skonto;
                    Kontos.Insert(indexval, sparkonto);
                }
                else if (p.kontotyp == 1)
                {
                    Kontos.Remove(girokonto);
                    girokonto = p.gkonto;
                    Kontos.Insert(indexval, girokonto);
                }
                DataContext = null;
                DataContext = this;
            }
        }

        private void Butlist_Click(object sender, RoutedEventArgs e)
        {
            Konto konto = Gridbank.SelectedItem as Konto;
            if (konto != null)
            {
                ListWindow lw = new ListWindow(konto);
                lw.Owner = this;

                lw.ShowDialog();
            }

        }
    }
}
