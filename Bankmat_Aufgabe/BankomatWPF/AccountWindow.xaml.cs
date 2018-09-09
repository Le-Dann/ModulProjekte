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
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        /// <summary>
        /// Represents the type of account that was created
        /// </summary>
        /// <remarks>Default value 0. Sparkonto -1. Girokonto 1</remarks>
        public int kontotyp = 0;

        public Sparkonto sparkonto = new Sparkonto();
        public Girokonto girokonto = new Girokonto();
        public AccountWindow()
        {
            InitializeComponent();
            DataContext = sparkonto; //set text fields with default values when window is first opened
        }

        public AccountWindow(Konto konto) : this ()
        {
            DataContext = konto;
            if (konto is Sparkonto)
            {
                cmbokontotyp.Text = "Sparkonto";
            }
            if (konto is Girokonto)
            {
                cmbokontotyp.Text = "Girokonto";
            }
        }

        private void butOK_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbAccountno.Text) || String.IsNullOrEmpty(cmbokontotyp.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle PflichtFelder ein", "Alert", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else
            {
                try
                {
                    if (cmbokontotyp.Text == "Sparkonto")
                    {
                        sparkonto.Name = tbName.Text;
                        sparkonto.Number = Convert.ToInt32(tbAccountno.Text);
                        if (String.IsNullOrEmpty(tblimit.Text))
                        {
                            tblimit.Text = Convert.ToString(sparkonto.Limit);
                        }
                        sparkonto.Limit = Convert.ToDouble(tblimit.Text);
                        kontotyp = -1;
                    }
                    else if(cmbokontotyp.Text == "Girokonto")
                    {
                        girokonto.Name = tbName.Text;
                        girokonto.Number = Convert.ToInt32(tbAccountno.Text);
                        if (String.IsNullOrEmpty(tblimit.Text))
                        {
                            tblimit.Text = Convert.ToString(girokonto.Limit);
                        }
                        girokonto.Limit = Convert.ToDouble(tblimit.Text);
                        kontotyp = 1;
                    }
                    DialogResult = true;
                    this.Close();
                }
                catch (FormatException)
                {

                    MessageBox.Show("Felder wird nicht richtig ausgefüllt","Alert",MessageBoxButton.OK,MessageBoxImage.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void butAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
