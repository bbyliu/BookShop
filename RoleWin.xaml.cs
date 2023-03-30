using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для RoleWin.xaml
    /// </summary>
    public partial class RoleWin : Window
    {
        RolesTableAdapter rp = new RolesTableAdapter();
        public RoleWin()
        {
            InitializeComponent();
            RpDgr.ItemsSource = rp.GetData();
        }

        private void RpDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = RpDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();


                NameRpTxt.Text = value1;
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

            object id = (RpDgr.SelectedItem as DataRowView).Row[0];
            rp.UpdateRole(NameRpTxt.Text, Convert.ToInt32(id));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            rp.InsertRole(NameRpTxt.Text);
            RpDgr.ItemsSource = rp.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (RpDgr.SelectedItem as DataRowView).Row[0];
            rp.DeleteRole(Convert.ToInt32(id));
        }

        private void NameRpTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NameRpTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }

        }
    }
}
