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

namespace Przelicznikwalut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double zlotyToGBP = 0.19;
        private const double zlotytoUSD = 0.22;
        private const double USDtoGBP = 0.83;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Konwertuj_Click(object sender, RoutedEventArgs e)
        {
            double ilosc = double.Parse(IloscTextBox.Text);
            string zw = ZComboBox.Text;
            string dow = DoComboBox.Text;

            double Przeliczona = Math.Round(Konwertuj(ilosc, zw, dow),2);
            Przeliczonakwota.Text =Przeliczona.ToString();
        }
        private double Konwertuj(double ilosc,string zw,string dow)
        {
            if(ZComboBox.Text == "Złoty" && DoComboBox.Text == "Funt")
            {
                return ilosc*zlotyToGBP;
            }
            if (ZComboBox.Text == "Złoty" && DoComboBox.Text == "Dolar")
            {
                return ilosc * zlotytoUSD;
            }
            if (ZComboBox.Text == "Funt" && DoComboBox.Text == "Dolar")
            {
                return ilosc / USDtoGBP;
            }
            if (ZComboBox.Text == "Funt" && DoComboBox.Text == "Złoty")
            {
                return ilosc / zlotyToGBP;
            }
            if (ZComboBox.Text == "Dolar" && DoComboBox.Text == "Funt")
            {
                return ilosc * USDtoGBP;
            }
            if (ZComboBox.Text == "Dolar" && DoComboBox.Text == "Złoty")
            {
                return ilosc / zlotytoUSD;
            }
            else
            {
                return ilosc;
            }
        }
    }
}
