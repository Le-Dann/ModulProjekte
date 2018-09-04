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
using Flugzeug;

namespace LuftfahrzeugWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Luftfahrzeug> luftfahrzeuge = new List<Luftfahrzeug>();

        public List<Luftfahrzeug> Luftfahrzeuge
        {
            get { return this.luftfahrzeuge ; }
            set { this.luftfahrzeuge = value; }
        }

    
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Changes data already stored in the grid list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Butchange_Click(object sender, RoutedEventArgs e)
        {
            Luftfahrzeug luftfahrzeug = FahrzeugGrid.SelectedItem as Luftfahrzeug;
            NeueLuftfahrzeug w = new NeueLuftfahrzeug(luftfahrzeug);

            w.Owner = this;
            w.ShowDialog();
            if (w.noexception == true)
            {
                Luftfahrzeuge.Remove(luftfahrzeug);
                Luftfahrzeuge.Add(w.luftzeug);
            }
            DataContext = null;
            DataContext = this;

        }

        /// <summary>
        /// Adds new data to the grid list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Butadd_Click(object sender, RoutedEventArgs e)
        {
            NeueLuftfahrzeug n = new NeueLuftfahrzeug();
            n.Owner = this;
            n.ShowDialog();

            if(n.noexception == true)
            {
                Luftfahrzeuge.Add(n.luftzeug);
            }

            DataContext = null;
            DataContext = this;

        }

        /// <summary>
        /// Deletes data from the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Butdelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBox = MessageBox.Show($"Wollen Sie das Luftfahrzeug wirklich löschen?","Löschen",MessageBoxButton.YesNo,MessageBoxImage.Question);

            if (messageBox == MessageBoxResult.Yes)
            {
                Luftfahrzeug luftfahrzeug = FahrzeugGrid.SelectedItem as Luftfahrzeug;

                if (luftfahrzeug != null)
                {
                    luftfahrzeuge.Remove(luftfahrzeug);
                }

                DataContext = null;
                DataContext = this;
                
            }
        }
    }
}
