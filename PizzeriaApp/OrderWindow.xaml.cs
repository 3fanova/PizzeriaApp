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
using PizzeriaLibrary;
using CostLibrary;
namespace PizzeriaApp
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Pizzeria.getCheckout(tbName, tbPhone, rbCash, rbCard, tbSurname);
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbCash.Content = "Наличными, к оплате " + Convert.ToString(Amount.Sum) + " руб.";
            rbCard.Content = "Картой, к оплате " + Convert.ToString(Amount.Sum) + " руб.";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
