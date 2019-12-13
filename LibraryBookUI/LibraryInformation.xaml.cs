using LibraryBookController;
using LibraryBookModels;
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



namespace LibraryBookUI
{
    /// <summary>
    /// Логика взаимодействия для LibraryInformation.xaml
    /// </summary>
    public partial class LibraryInformation : Window
    {
        private ILibraryInformationController _controler;

        public LibraryInformation(ILibraryInformationController library)
        {
            InitializeComponent();
            _controler = library;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LibraryInfoModels Model =new LibraryInfoModels
            {
                Name = textBoxNameBook.Text,
                Avtor = textBoxAvtor.Text,
                Date = textBoxYear.NumValue,
                Read = CheckBox.IsChecked ?? false,
                Comments = TextBoxComments.Text,
            };
            _controler.Save(Model);
            Close();
        }
    }
}
