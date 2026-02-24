using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr4_test.Pages
{
    
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            Chart1.ChartAreas.Add(new ChartArea("Main"));

            var series = new Series("График")

            {

                ChartType = SeriesChartType.Line

            };

            Chart1.Series.Add(series);

        }


        private void BtnCalc_Click(object sender, RoutedEventArgs e)

        {

            if (!double.TryParse(txtX0.Text, out double x0) ||

            !double.TryParse(txtXk.Text, out double xk) ||

            !double.TryParse(txtDx.Text, out double dx) ||

            !double.TryParse(txtB.Text, out double b))

            {

                MessageBox.Show("Введите корректные данные!");

                return;

            }


            if (dx <= 0 || xk < x0)

            {

                MessageBox.Show("Проверьте диапазон и шаг!");

                return;

            }


            txtOutput.Clear();

            var series = Chart1.Series.First();

            series.Points.Clear();


            for (double x = x0; x <= xk; x += dx)

            {

                double underRoot = Math.Pow(x, 3) + Math.Pow(b, 3);


                if (underRoot < 0)

                {

                    txtOutput.AppendText($"x={x:F2} → ошибка\n");

                    continue;

                }


                double y = 9 * (x + 15 * Math.Sqrt(underRoot));


                txtOutput.AppendText($"x={x:F2} y={y:F4}\n");

                series.Points.AddXY(x, y);

            }

        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)

        {

            txtX0.Clear();
            txtXk.Clear();
            txtDx.Clear();
            txtB.Clear();
            txtOutput.Clear();
            Chart1.Series.First().Points.Clear();

        }

    }

}
