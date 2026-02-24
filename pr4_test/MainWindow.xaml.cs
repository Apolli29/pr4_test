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
using System.ComponentModel;
using pr4_test.Pages;

namespace pr4_test
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Page1());
        }
        private void BtnPage1_Click(object sender, RoutedEventArgs e)

        {

            MainFrame.Navigate(new Page1());

        }


        private void BtnPage2_Click(object sender, RoutedEventArgs e)

        {

            MainFrame.Navigate(new Page2());

        }


        private void BtnPage3_Click(object sender, RoutedEventArgs e)

        {

            MainFrame.Navigate(new Page3());

        }


        protected override void OnClosing(CancelEventArgs e)

        {

            if (MessageBox.Show("Вы уверены, что хотите выйти?",

            "Выход",

            MessageBoxButton.YesNo) == MessageBoxResult.No)

            {

                e.Cancel = true;

            }

        }

    }

}
