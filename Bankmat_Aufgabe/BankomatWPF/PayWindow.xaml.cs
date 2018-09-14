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

        public int kontotyp = 0;

        Konto mainkonto;
        public Girokonto gkonto = new Girokonto();
        public Sparkonto skonto = new Sparkonto();
    
        public PayWindow()
        {
            InitializeComponent();
        }
        public PayWindow(Konto konto, int transtyp) : this()
        {
          Transtyp = transtyp; //distinguishes between einzahlen and auszahlen. 
          DataContext = konto;
          mainkonto = konto;
          
        }


        private void Butconfirm_Click(object sender, RoutedEventArgs e)
        {
            double amount = 0.0;
            try
            {
                amount = Convert.ToDouble(TBbetrag.Text);
                
            }
            catch (FormatException)
            {

                MessageBox.Show("Bitte füllen Sie den Betragfeld richtig ein","Alert",MessageBoxButton.OK,MessageBoxImage.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (Transtyp == 1 && amount != 0.0)
            {
                if (mainkonto is Girokonto)
                {
                    gkonto = mainkonto as Girokonto;
                    try
                    {
                        gkonto.PayIn(amount);
                        kontotyp = 1;
                    }
                    catch (KtoException ex)
                    {

                        MessageBox.Show(ex.Message);
                    } 
                }
                else
                {
                    skonto = mainkonto as Sparkonto;
                    try
                    {
                        skonto.PayIn(amount);
                        kontotyp = -1;
                    }
                    catch (KtoException ex)
                    {

                       MessageBox.Show(ex.Message);
                    }
                 
                }
            }
            if (Transtyp == -1 && amount != 0.0)
            {
                if (mainkonto is Girokonto)
                {
                    gkonto = mainkonto as Girokonto;
                    try
                    {
                        gkonto.PayOut(amount);
                        kontotyp = 1;
                    }
                    catch (KtoException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    skonto = mainkonto as Sparkonto;
                    try
                    {
                        skonto.PayOut(amount);
                        kontotyp = -1;
                    }
                    catch (KtoException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
            }
            DialogResult = true;
            this.Close();

        }

        private void Butcancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
