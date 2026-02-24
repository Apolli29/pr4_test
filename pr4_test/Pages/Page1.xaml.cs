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

namespace pr4_test.Pages
{
    
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)

        {

            if (!double.TryParse(txtX.Text, out double x) ||

            !double.TryParse(txtY.Text, out double y) ||

            !double.TryParse(txtZ.Text, out double z))

            {

                MessageBox.Show("Введите корректные данные!");

                return;

            }


            if (Math.Abs(x) > 1)

            {

                MessageBox.Show("|x| должно быть ≤ 1 для arccos(x)");

                return;

            }


            double denominator = Math.Abs(x - y) * z + x * x;


            if (denominator == 0)

            {

                MessageBox.Show("Знаменатель не может быть равен 0");

                return;

            }


            double gamma =

            5 * Math.Atan(x) -

            0.25 * Math.Acos(x) *

            ((x + 3 * Math.Abs(x - y) + x * x) / denominator);


            txtResult.Text = gamma.ToString("F4");

        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)

        {

            txtX.Clear();

            txtY.Clear();

            txtZ.Clear();

            txtResult.Clear();
        }
    }
}
