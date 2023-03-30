using System;
using System.Collections.Generic;
using System.Data;
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
using BookShop.MyBookShopDataSetTableAdapters;

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для OrderBooks.xaml
    /// </summary>
    public partial class OrderBooks : Window
    {
        BookOredersTableAdapter botb = new BookOredersTableAdapter();
        BooksTableAdapter bookor = new BooksTableAdapter();
        OrdersTableAdapter orderus = new OrdersTableAdapter();


        public OrderBooks()
        {
            InitializeComponent();
            orderBookDgr.ItemsSource = botb.GetData();

            idBOOKTXt.ItemsSource = bookor.GetData();
            idBOOKTXt.DisplayMemberPath = "title";
            idBOOKTXt.SelectedValuePath = "id";

            idORDERtTxt.ItemsSource = orderus.GetData();
            idORDERtTxt.DisplayMemberPath = "users_id";
            idORDERtTxt.SelectedValuePath = "id";
        }

        private void orderBookDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = orderBookDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                var value1 = rowView[1];
                var value2 = rowView[2];

                if (value1 != null)
                {
                    idBOOKTXt.SelectedValue = value1;
                }
                if (value2 != null)
                {
                    idORDERtTxt.SelectedValue = value2;
                }
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            AboutOrders aboutOrders = new AboutOrders();
            aboutOrders.Show();
            this.Close();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            object id = (orderBookDgr.SelectedItem as DataRowView).Row[0];
           botb.UpdateOrBook(Convert.ToInt32(idBOOKTXt.SelectedValue), Convert.ToInt32(idORDERtTxt.SelectedValue), Convert.ToInt32(id));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            botb.InsertOrBook(Convert.ToInt32(idBOOKTXt.SelectedValue), Convert.ToInt32(idORDERtTxt.SelectedValue));
            orderBookDgr.ItemsSource = botb.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (orderBookDgr.SelectedItem as DataRowView).Row[0];
            botb.DeleteOrBook(Convert.ToInt32(id));
        }

        private void idBOOKTXt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (idBOOKTXt.SelectedItem as DataRowView).Row[1];
        }

        private void idORDERtTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (idORDERtTxt.SelectedItem as DataRowView).Row[1];
        }
    }
}
