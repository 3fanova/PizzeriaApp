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
using System.IO;
using CostLibrary;

namespace PizzeriaApp
{
    /// <summary>
    /// Логика взаимодействия для DiscontWindow.xaml
    /// </summary>
    public partial class DiscontWindow : Window
    {
        public DiscontWindow()
        {
            
            InitializeComponent();
            cmbBirthday.Items.Add("Да");
        }
        
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
           if (rbPickup.IsChecked == true)
            {
                tblSum.Text = Convert.ToString(Amount.Sum);
                Random orders = new Random();
                int ord = orders.Next(1000, 9000);
                MessageBox.Show("Ваш заказ оформлен, ожидайте! " + " Номер заказа: " + ord + " " + " К оплате: " + tblSum.Text +  " руб.", "Оформление заказа", MessageBoxButton.OK, MessageBoxImage.Information);
                File.AppendAllText("D:/Пиццерия_Ефанова/PizzeriaApp/PizzeriaApp/Resources/Заказы.txt", "Сумма к оплате: " + tblSum.Text + " " + rbPickup.Content);
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
           else if (rbCourier.IsChecked==true)
            {
                OrderWindow order = new OrderWindow();
                order.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка, выберите способ даставки!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void cmbBirthday_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pizzeria.getDiscontBirthday(cmbBirthday, tblSum);
        }

        private void btnComment_Click(object sender, RoutedEventArgs e)
        {
            Pizzeria.saveComment(tbComment);
            Pizzeria.getCoupon(tbComment, tblSum);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbComment.Text = "";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }

        private void rbCourier_Checked(object sender, RoutedEventArgs e)
        {
            Pizzeria.getOrderDelivery(tblSum);
        }

        private void rbPickup_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblSum.Text = Convert.ToString(Amount.Sum);
        }
    }
}
