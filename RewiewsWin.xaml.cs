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
    /// Логика взаимодействия для RewiewsWin.xaml
    /// </summary>
    public partial class RewiewsWin : Window
    {
        ReviewsTableAdapter rew = new ReviewsTableAdapter();
        BooksTableAdapter rewBook = new BooksTableAdapter();
        UsersTableAdapter rewus = new UsersTableAdapter();
        public RewiewsWin()
        {
            InitializeComponent();
            RewDgr.ItemsSource = rew.GetData();

            BkidTbx.ItemsSource = rewBook.GetData();
            BkidTbx.DisplayMemberPath = "title";
            BkidTbx.SelectedValuePath = "id";

            UsidTxt.ItemsSource = rewus.GetData();
            UsidTxt.DisplayMemberPath = "first_name";
            UsidTxt.SelectedValuePath = "id";
        }

        private void RewDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = RewDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                var value1 = rowView[1];
                var value2 = rowView[2];
                string value3 = rowView[3].ToString();
                string value4 = rowView[4].ToString();
                string value5 = rowView[5].ToString();

                ratTxt.Text = value3;
                ComTxt.Text = value4;
                dateTxt.Text = value5;

                if (value1 != null)
                {
                    BkidTbx.SelectedValue = value1;
                }
                if (value2 != null)
                {
                    UsidTxt.SelectedValue = value2;
                }
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            UserAbout userAbout = new UserAbout();
            userAbout.Show();
            this.Close();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            object id = (RewDgr.SelectedItem as DataRowView).Row[0];
            rew.UpdateRew(Convert.ToInt32(BkidTbx.Text), Convert.ToInt32(UsidTxt), Convert.ToInt32(ratTxt),ComTxt.Text, Convert.ToDateTime(dateTxt.Text).ToString(), Convert.ToInt32(id));

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            rew.InsertRew(Convert.ToInt32(BkidTbx.Text), Convert.ToInt32(UsidTxt), Convert.ToInt32(ratTxt),ComTxt.Text, Convert.ToDateTime(dateTxt.Text).ToString());
            RewDgr.ItemsSource = rew.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (RewDgr.SelectedItem as DataRowView).Row[0];
            rew.DeleteRew(Convert.ToInt32(id));
        }

        private void BkidTbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (BkidTbx.SelectedItem as DataRowView).Row[1];
        }

        private void UsidTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (UsidTxt.SelectedItem as DataRowView).Row[3];
        }

        private void ratTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9]+$") && ratTxt.Text.Length < 2)
            {
                e.Handled = true;
            }
        }

        private void ComTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && ComTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
