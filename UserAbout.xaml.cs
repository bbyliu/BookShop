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
    /// Логика взаимодействия для UserAbout.xaml
    /// </summary>
    public partial class UserAbout : Window
    {
        UsersTableAdapter us = new UsersTableAdapter();
        RolesTableAdapter roUser = new RolesTableAdapter();
        public UserAbout()
        {
            InitializeComponent();
            UserDgr.ItemsSource = us.GetData();

            roleTxt.ItemsSource = roUser.GetData();
            roleTxt.DisplayMemberPath = "role_name";
            roleTxt.SelectedValuePath = "id";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            RewiewsWin rewiewsWin = new RewiewsWin();
            rewiewsWin.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            RoleWin roleWin = new RoleWin();
            roleWin.Show();
            this.Close();
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            object id = (UserDgr.SelectedItem as DataRowView).Row[0];
            us.UpdateUser(LoginTbx.Text, PassTxt.Text, FirstTxt.Text, LastTxt.Text, AdrTxt.Text, PhonUsTxt.Text, Convert.ToInt32(roleTxt.SelectedValue), Convert.ToInt32(id));

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            us.InsertQuery(LoginTbx.Text, PassTxt.Text, FirstTxt.Text, LastTxt.Text, AdrTxt.Text, PhonUsTxt.Text, Convert.ToInt32(roleTxt.SelectedValue));
            UserDgr.ItemsSource = us.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (UserDgr.SelectedItem as DataRowView).Row[0];
            us.DeleteUser(Convert.ToInt32(id));
        }

        private void UserDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = UserDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();
                string value4 = rowView[4].ToString();
                string value5 = rowView[5].ToString();
                string value6 = rowView[6].ToString();
                var value7 = rowView[7];

                LoginTbx.Text = value1;
                PassTxt.Text = value2;
                FirstTxt.Text = value3;
                LastTxt.Text = value4;
                AdrTxt.Text = value5;
                PhonUsTxt.Text = value6;

                if (value7 != null)
                {
                    roleTxt.SelectedValue = value7;
                }
            }
        }

        private void roleTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (roleTxt.SelectedItem as DataRowView).Row[1];
        }

        private void LoginTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z,0-9]+$") && LoginTbx.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PassTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z,0-9]+$") && PassTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void FirstTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && FirstTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void LastTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && LastTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void AdrTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z,0-9,,]+$") && AdrTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PhonUsTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9,+]+$") && PhonUsTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
