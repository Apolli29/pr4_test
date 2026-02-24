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
    
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)

        {

            if (!double.TryParse(txtX.Text, out double x))

            {

                MessageBox.Show("Введите корректное число!");

                return;

            }


            double fx = 0;


            if (rbSh.IsChecked == true)

                fx = Math.Sinh(x);

            else if (rbX2.IsChecked == true)

                fx = x * x;

            else if (rbExp.IsChecked == true)

                fx = Math.Exp(x);

            else

            {

                MessageBox.Show("Выберите функцию!");

                return;

            }


            txtResult.Text = fx.ToString("F4");

        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)

        {

            txtX.Clear();

            txtResult.Clear();

            rbSh.IsChecked = false;

            rbX2.IsChecked = false;

            rbExp.IsChecked = false;

        }

    }

}

