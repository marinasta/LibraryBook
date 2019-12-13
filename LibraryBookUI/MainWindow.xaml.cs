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
using LibraryBookController;

namespace LibraryBookUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILibraryInformationController _controler;
        public MainWindow()
        {
            InitializeComponent();
            _controler = new LibraryInformationController();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var library = new LibraryInformation(_controler);
            library.Owner = this;
            library.ShowDialog();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var library = new LibraryInformation(_controler);
            library.Owner = this;
            library.ShowDialog();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
