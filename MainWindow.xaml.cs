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
using Velacro.UIElements.Basic;

namespace DolanKuyDesktopPalingbaru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MyPage listWisataPage;
        private MyPage akomodasiPage;
        private MyPage kategoriPage;

        public MainWindow()
        {
            listWisataPage = new ListWisata.ListWisata();
            akomodasiPage = new Akomodasi.Akomodasi();
            kategoriPage = new Kategori.Kategori();
            InitializeComponent();
        }

        private void wisata_click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(listWisataPage);
        }

        private void akomodasi_click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(akomodasiPage);
        }

        private void kategori_click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(kategoriPage);
        }
    }
}
