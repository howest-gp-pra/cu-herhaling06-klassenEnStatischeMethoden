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
using Pra.HerhalingKlassenStatischeMethoden.CORE;

namespace Pra.HerhalingKlassenStatischeMethoden.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnTestProductIntArray_Click(object sender, RoutedEventArgs e)
        {
            int[] getallen = { 4, 5, 7, 8, 12 };
            lblResultaat.Content = Rekenen.Product(getallen);
        }
        private void BtnTestProductIntList_Click(object sender, RoutedEventArgs e)
        {
            List<int> getallen = new List<int>() { 3, 4, 5, 6, 7 };
            lblResultaat.Content = Rekenen.Product(getallen);
        }
    }
}
