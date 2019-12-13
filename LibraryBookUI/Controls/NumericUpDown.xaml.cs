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

namespace LibraryBookUI.Controls
{
    /// <summary>
    /// Логика взаимодействия для NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown : UserControl
    {
        public NumericUpDown()
        {
            InitializeComponent();
            _numValue = Default;
            txtNum.Text = _numValue.ToString();
        }

        private int _numValue = 0;
        private int _min = int.MinValue;
        private int _max = int.MaxValue;
        private int _default = 0;
        //  private int Default => (_min + _max) / 2;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = Validation(value) ? value : Default;
                txtNum.Text = _numValue.ToString();
            }
        }

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public int Default
        {
            get { return _default; }
            set
            {
                _default = value;
                NumValue = NumValue;
            }
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private int Parse(string text)
        {
            int numValue;
            if (int.TryParse(text, out numValue))
            {
                return numValue;
            }
            else
            {
                return Default;
            }
        }

        private bool Validation(int value)
        {
            return value >= Min && value <= Max;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }
            var value = Parse(txtNum.Text);
            NumValue = value;
            //_numValue = Validation(value) ? value : Default;

            //if (!int.TryParse(txtNum.Text, out _numValue))
            //    txtNum.Text = _numValue.ToString();
        }

    }
}
