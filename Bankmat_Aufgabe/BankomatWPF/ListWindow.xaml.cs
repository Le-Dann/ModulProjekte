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
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        List<Transaktion> Translist = new List<Transaktion>();
        Konto lkonto;
        public ListWindow()
        {
            InitializeComponent();
        }

        public ListWindow(Konto konto) : this()
        {
            Translist = konto.Transaktionen;
            lkonto = konto;
            DataContext = lkonto;
        }


    }
}
