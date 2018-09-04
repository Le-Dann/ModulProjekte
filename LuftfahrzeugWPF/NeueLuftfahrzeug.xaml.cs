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
using Flugzeug;

namespace LuftfahrzeugWPF
{
    /// <summary>
    /// Interaction logic for NeueLuftfahrzeug.xaml
    /// </summary>
    public partial class NeueLuftfahrzeug : Window
    {
       public Luftfahrzeug luftzeug= new Luftfahrzeug();
       public bool noexception = false;

        
        
        /// <summary>
        /// Basis constructor for side window
        /// </summary>
        public NeueLuftfahrzeug()
        {
            InitializeComponent();
            DataContext = luftzeug;
        }

        /// <summary>
        /// Second constructor for side window
        /// </summary>
        /// <param name="luftfahrzeug">Luftfahrzeug object</param>
        public NeueLuftfahrzeug(Luftfahrzeug luftfahrzeug) : this()
        {
            luftzeug = luftfahrzeug;
           
        }
        
        /// <summary>
        /// Cancels aircraft object being added to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Butcancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds data entered by user to the Fahrzeug list
        /// </summary>
        /// <remarks>Also checks if valid values were entered for Baujahr property</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButOK_Click(object sender, RoutedEventArgs e)
        {
            string hersteller = Tbhersteller.Text;
            string motorname = Tbmotor.Text;

            Motor motor = new Motor();
            if (comboxfahrtyp.Text == "Flugzeug")
            {
                luftzeug = new Flugzeug.Flugzeug();
                
            }
            else if (comboxfahrtyp.Text == "Zeppelin")
            {
                luftzeug = new Zeppelin();
            }
            else if (comboxfahrtyp.Text == "Hubschrauber")
            {
                luftzeug = new Hubschrauber();
            }
            motor.Name = motorname;
            luftzeug.Hersteller = hersteller;
            luftzeug.Power = motor;


            try
            {
                int baujahr = Convert.ToInt32(Tbbaujahr.Text);
                luftzeug.Baujahr = baujahr;
                noexception = true;

            }
            catch(FormatException)
            {
                MessageBox.Show($"Ungültiges Wert für Baujahr {Tbbaujahr.Text}");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
           
        }

        /// <summary>
        /// Executes commands one window is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (luftzeug != null)
            {
                if (luftzeug.Power != null)
                {
                    Tbbaujahr.Text = Convert.ToString(luftzeug.Baujahr);
                    Tbhersteller.Text = luftzeug.Hersteller;
                    Tbmotor.Text = luftzeug.Power.Name;
                }
            }
            else
            {
                MessageBox.Show("Bitte whälen Sie eine Zeile", "Alert", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                Close();
            }

        }
    }
}
