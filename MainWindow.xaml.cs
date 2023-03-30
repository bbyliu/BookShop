using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using BookShop.MyBookShopDataSetTableAdapters;

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter adapter = new UsersTableAdapter();
        public MainWindow()
        {
           InitializeComponent();
           
        }

        private void Avtoriz_Click(object sender, RoutedEventArgs e)
        {
            var alllogns = adapter.GetData().Rows;
            for (int i = 0; i < alllogns.Count; i++)
            {
                if (alllogns[i][1].ToString() == LoginTbx.Text &&
                    alllogns[i][2].ToString() == PasswotdTbx.Password)
                {
                    int roleId = (int)alllogns[i][7];

                    switch (roleId)
                    {
                        case 1:
                             Admin admin = new Admin();
                             admin.Show();
                             this.Close();
                            break;
                        case 2:
                            Customer customer = new Customer();
                            customer.Show();
                            this.Close();
                            break;

                    }

                }
               /* if (alllogns[i][1].ToString() != LoginTbx.Text ||
                     alllogns[i][2].ToString() != PasswotdTbx.Password)
                {
                    MessageBox.Show("Неверно введен пароль или логин", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                }*/


            }

        }

        private void LoginTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z,0-9]+$"))
            {
                e.Handled = true;
            }
        }

        private void PasswotdTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z,0-9]+$"))
            {
                e.Handled = true;
            }
        }
    }
}
