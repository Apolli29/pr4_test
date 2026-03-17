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
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                int mode = 0;
                if (rbSh.IsChecked == true) mode = 1;
                if (rbX2.IsChecked == true) mode = 2;
                if (rbExp.IsChecked == true) mode = 3;

                double result = Calculate(x, mode);
                txtResult.Text = result.ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)

        {

            txtX.Clear();

            txtResult.Clear();

            rbSh.IsChecked = false;

            rbX2.IsChecked = false;

            rbExp.IsChecked = false;

        }
        /// <summary>
        /// Вычисление
        /// </summary>
        public double Calculate(double x, int mode)
        {
            switch (mode)
            {
                case 1: return Math.Sinh(x);
                case 2: return x * x;
                case 3: return Math.Exp(x);
                default: throw new ArgumentException("Функция не выбрана");
            }
        }
    }
}

