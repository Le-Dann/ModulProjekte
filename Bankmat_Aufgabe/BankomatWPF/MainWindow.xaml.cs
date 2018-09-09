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
        private List<Konto> kontos = new List<Konto>();

        public List<Konto>  Kontos
        {
            get { return kontos; }
            set { kontos = value; }
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
            Sparkonto sparkonto = new Sparkonto();
            Girokonto girokonto = new Girokonto();
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
    }
}
