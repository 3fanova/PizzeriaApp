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

using CostLibrary;

namespace PizzeriaApp
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
      
       
        public MenuWindow()
        {
            InitializeComponent();

        }

        
        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
           
            if (tblSum.Text != null && tblSum.Text != "" && tblSum.Text != "0") 
            {
                DiscontWindow discont = new DiscontWindow();
                discont.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите позиции!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       

       
       

        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void cbPizzaMargarita_Checked(object sender, RoutedEventArgs e)
        {  
                Amount.Sum += 415;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaMargarita_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 415;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaVegat_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 415;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaVegat_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 415;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaFourCheese_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 485;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaFourCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 485;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaHawaiian_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 490;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaHawaiian_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 490;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaCaesar_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 500;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPizzaCaesar_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 500;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbNaggets_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 120;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbNaggets_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 120;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbFri_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 80;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbFri_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 80;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbVegetables_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum +=65;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbVegetables_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 65;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPork_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum +=350;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPork_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 350;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbSalmon_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 187;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbSalmon_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 187;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbFruitDrink_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum +=75;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbFruitDrink_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 75;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbJuice_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum +=130;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbJuice_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 130;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbCola_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 90;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbCola_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 90;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbBonAqua_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 80;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbBonAqua_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 80;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPepsi_Checked(object sender, RoutedEventArgs e)
        {
            Amount.Sum += 87;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }

        private void cbPepsi_Unchecked(object sender, RoutedEventArgs e)
        {
            Amount.Sum -= 87;
            tblSum.Text = Convert.ToString(Amount.Sum);
        }
    }
}
