using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using BookShop.MyBookShopDataSetTableAdapters;

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для AboutOrders.xaml
    /// </summary>
    public partial class AboutOrders : Window
    {
        OrdersTableAdapter ord = new OrdersTableAdapter();
        UsersTableAdapter usOrd = new UsersTableAdapter();
        DiscountsTableAdapter discountsOrd = new DiscountsTableAdapter();
        public AboutOrders()
        {
            InitializeComponent();
            OrderDgr.ItemsSource = ord.GetData();

            useridTxt.ItemsSource = usOrd.GetData();
            useridTxt.DisplayMemberPath = "first_name";
            useridTxt.SelectedValuePath = "id";

            discountTxt.ItemsSource = discountsOrd.GetData();
            discountTxt.DisplayMemberPath = "name";
            discountTxt.SelectedValuePath = "id";
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            RoleWin roleWin = new RoleWin();
            roleWin.Show();
            this.Close();
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void OrderDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = OrderDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                var value1 = rowView[1];
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();
                var value4 = rowView[4];
                string value5 = rowView[5].ToString();

                
                orderidTxt.Text = value2;
                statTxt.Text = value3;
                PriceTxt.Text = value5;
                if (value1 != null)
                {
                    useridTxt.SelectedValue = value1;
                }
                if (value4 != null)
                {
                    discountTxt.SelectedValue = value4;
                }
            }
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            object id = (OrderDgr.SelectedItem as DataRowView).Row[0];
            ord.UpdateOrder(Convert.ToInt32(useridTxt.SelectedValue), Convert.ToDateTime(orderidTxt.Text).ToString(), statTxt.Text, Convert.ToInt32(discountTxt.SelectedValue), PriceTxt.Text, Convert.ToInt32(id));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ord.InsertOrder(Convert.ToInt32(useridTxt.SelectedValue), Convert.ToDateTime(orderidTxt.Text).ToString(), statTxt.Text, Convert.ToInt32(discountTxt.SelectedValue), PriceTxt.Text);
            OrderDgr.ItemsSource = ord.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (OrderDgr.SelectedItem as DataRowView).Row[0];
            ord.DeleteOrder(Convert.ToInt32(id));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Skidka skidka = new Skidka();
            skidka.Show();
            this.Close();
        }

        private void OrdBook_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            OrderBooks orBook = new OrderBooks();
            orBook.Show();
            this.Close();
        }

        private void useridTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (useridTxt.SelectedItem as DataRowView).Row[3];
        }

        private void discountTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (discountTxt.SelectedItem as DataRowView).Row[1];
        }

        private void statTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && statTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PriceTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9,,]+$") && PriceTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
