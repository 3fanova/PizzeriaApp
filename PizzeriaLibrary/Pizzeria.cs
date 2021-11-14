using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TextBox = System.Windows.Controls.TextBox;
using CostLibrary;
using System.IO;
using System.Text.RegularExpressions;

namespace PizzeriaLibrary
{
    public class Pizzeria
    {
        public static void getCoupon(TextBox tbComment, TextBlock tblSum)
            {
            if (tbComment.Text != null && tbComment.Text != "")
            {
                Random coupon = new Random();
                int couponOne = coupon.Next(1000, 1200);
                saveComment(tbComment);
                MessageBox.Show(" Спасибо за отзыв! " + " Номер купона " + Convert.ToString(couponOne), "Отзыв",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
               if (couponOne > 1000 && couponOne < 1100)
                {
                    MessageBox.Show(" Купон на наггетсы куриные и Pepsi за 185 руб. ", " Купон ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Amount.Sum += 185;
                    tblSum.Text = Convert.ToString(Amount.Sum);
                }
                else
                {
                    MessageBox.Show(" Купон на наггетсы куриные, Coca-cola, картофелm фри за 268 руб.", " Купон ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Amount.Sum += 268;
                    tblSum.Text = Convert.ToString(Amount.Sum);
                }
            }
            else
                MessageBox.Show(" Не оставили отзыв! Попробуйте снова ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static public void getDiscontBirthday(System.Windows.Controls.ComboBox cmbBirthday, TextBlock tblResult)
        {
            if (cmbBirthday.SelectedIndex == 0)
            {
                Amount.Sum = (Amount.Sum * 0.8) / 1;
                tblResult.Text = Convert.ToString(Amount.Sum);

            }
        }
        static public void getOrderDelivery(TextBlock tblDelivery)
        {
            if (Amount.Sum < 1500)
            {
                Amount.Sum += 150;
                tblDelivery.Text = Convert.ToString(Amount.Sum);
            }
        }

        static public void getInfoAboutProgram(TextBlock tblAboutProgram)
        {
            using (StreamReader f = new StreamReader("О программе.txt", System.Text.Encoding.UTF8))
            {
                string str;
                while ((str = f.ReadLine()) != null)
                {
                    tblAboutProgram.Text = (str + Environment.NewLine);
                }
            }
        }

        static public void saveOrder(TextBox tbSurname, TextBox tbNum, System.Windows.Controls.RadioButton rbCash, System.Windows.Controls.RadioButton rbCard)
        {
            if (rbCash.IsChecked==true)
            {
                File.AppendAllText("Заказы.txt", tbSurname.Text + " " + tbNum.Text + " " + " " + rbCash.Content);
            }
            if (rbCard.IsChecked==true)
            {
                File.AppendAllText("Заказы.txt", tbSurname.Text + " " + tbNum.Text + " " + " " + rbCard.Content);
            }
        }

        static public void saveComment(TextBox tbComment)
        {
            File.AppendAllText("Отзывы.txt", tbComment.Text);
        }
        static public bool ValidCharFound(string str)
        {
            bool valid = true;
            foreach (char c in str)
            {
                string bfr = c.ToString();
                if (Regex.IsMatch(bfr, @"[0-9,]"))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
        static public void getCheckout(TextBox tbName, TextBox tbNumber, System.Windows.Controls.RadioButton rbCash, System.Windows.Controls.RadioButton rbCard, TextBox tbSurname)
        {
            if (tbName.Text != null && tbName.Text != "" && tbNumber.Text != null && tbNumber.Text
           != "" && tbSurname.Text != null && tbSurname.Text != "")
            {
                if (ValidCharFound(tbNumber.Text))
                {
                    MessageBox.Show(" Стоимость заказа составила " + Convert.ToString(Amount.Sum) + " руб. ", " Заказ оформлен ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                     saveOrder(tbSurname, tbNumber, rbCash, rbCard);
                }
                else
                {

                    MessageBox.Show(" Укажите числовые значения в поле 'Номер телефона' ", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tbSurname.Text != null && tbSurname.Text != "" && tbNumber.Text != null &&
           tbNumber.Text != "")
                MessageBox.Show(" Заполните поле 'Имя'", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            else if (tbName.Text != null && tbName.Text != "" && tbNumber.Text != null &&
           tbNumber.Text != "")
                MessageBox.Show(" Заполните поле 'Фамилия'", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            else if (tbSurname.Text != null && tbSurname.Text != "" && tbName.Text != null &&
           tbName.Text != "")
                MessageBox.Show(" Заполните поле 'Номер телефона'", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            else if (tbSurname.Text != null && tbSurname.Text != "")
                MessageBox.Show(" Заполните поля 'Номер телефона, 'Имя'", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            else if (tbName.Text != null && tbName.Text != "")
                MessageBox.Show(" Заполните поля 'Фамилия', 'Имя'", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbName.Text != null && tbName.Text != "")
                MessageBox.Show(" Заполните поля 'Имя', 'Номер телефона'", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(" Заполните все обязательные поля ", " Ошибка ", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
            }

