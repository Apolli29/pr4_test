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
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                double z = Convert.ToDouble(txtZ.Text);

                double result = Calculate(x, y, z);

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

            txtY.Clear();

            txtZ.Clear();

            txtResult.Clear();
        }
        /// <summary>
        /// Вычисление
        /// </summary>
        public double Calculate(double x, double y, double z)
        {
            if (Math.Abs(x) > 1)
                throw new ArgumentException("|x| должно быть <= 1");
            double denominator = Math.Abs(x - y) * z + x * x;
            if (denominator == 0)
                throw new DivideByZeroException();

            double gamma = 5 * Math.Atan(x) - 0.25 * Math.Acos(x) * ((x + 3 * Math.Abs(x - y) +x * x) / denominator);
            return gamma;
        }
    }
}
