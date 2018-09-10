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

namespace BankomatWPF
{
    /// <summary>
    /// Interaction logic for PayWindow.xaml
    /// </summary>
    public partial class PayWindow : Window
    {
        /// <summary>
        /// value determines transaction type. 
        /// </summary>
        /// <remarks>-1 for auszahlen. 1 for einzahlen</remarks>
        int Transtyp = 0;

        public Sparkonto skonto = new Sparkonto();
        public Girokonto gkonto = new Girokonto();
        public PayWindow()
        {
            InitializeComponent();
        }
        public PayWindow(Sparkonto sparkonto, int transtyp) : this()
        {
          Transtyp = transtyp; //distinguishes between einzahlen and auszahlen. 
          DataContext = sparkonto;
          skonto = sparkonto;
          
        }

        public PayWindow(Girokonto girokonto, int transtyp) : this()
        {
            Transtyp = transtyp; //distinguishes between einzahlen and auszahlen. 
            DataContext = girokonto;
            gkonto = girokonto;

        }

        private void Butconfirm_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                double amount = Convert.ToDouble(TBbetrag.Text);
                if (Transtyp == 1)
                {
                    if (gkonto != null)
                    {

                        gkonto.PayIn(amount);
                    }
                    else
                    {
                        skonto.PayIn(amount);
                    }
                }
                if (Transtyp == -1)
                {
                    if (gkonto != null)
                    {

                        gkonto.PayOut(amount);
                    }
                    else
                    {
                        skonto.PayOut(amount);
                    }
                }
                DialogResult = true;
                this.Close();
            }
            catch (FormatException)
            {

                MessageBox.Show("Bitte füllen Sie den Betragfeld richtig ein","Alert",MessageBoxButton.OK,MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
