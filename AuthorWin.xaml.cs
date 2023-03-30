using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
    /// Логика взаимодействия для AuthorWin.xaml
    /// </summary>
    public partial class AuthorWin : Window
    {
        AuthorsTableAdapter au = new AuthorsTableAdapter();
        public AuthorWin()
        {
            InitializeComponent();
            AuthotDgr.ItemsSource = au.GetData();
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

       

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            au.InsertAuthor(FNTbx.Text, LNTxt.Text, Convert.ToDateTime(BirthTxt.Text).ToString(), CountryTxt.Text);
            AuthotDgr.ItemsSource = au.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (AuthotDgr.SelectedItem as DataRowView).Row[0];
            au.DeleteAuthor(Convert.ToInt32(id));
        }

        private void AuthotDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = AuthotDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();
                string value4 = rowView[4].ToString();

                FNTbx.Text = value1;
                LNTxt.Text = value2;
                BirthTxt.Text = value3;
                CountryTxt.Text = value4;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            
            object id = (AuthotDgr.SelectedItem as DataRowView).Row[0];
            au.UpdateAuthor(FNTbx.Text, LNTxt.Text, Convert.ToDateTime(BirthTxt.Text).ToString(), CountryTxt.Text, Convert.ToInt32(id));

        }

        private void FNTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && FNTbx.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void LNTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && LNTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void CountryTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && CountryTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
