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
    /// Логика взаимодействия для Skidka.xaml
    /// </summary>
    public partial class Skidka : Window
    {
        DiscountsTableAdapter skid = new DiscountsTableAdapter();
        public Skidka()
        {
            InitializeComponent();
            SkidkaDgr.ItemsSource = skid.GetData();
        }

        private void SkidkaDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataRowView rowView = SkidkaDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();
                string value4 = rowView[4].ToString();


                NameSkTXt.Text = value1;
                PrecentTxt.Text = value2;
                StartDatTxt.Text = value3;
                EndDatTxt.Text = value4;
            }
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            object id = (SkidkaDgr.SelectedItem as DataRowView).Row[0];
            skid.UpdateDiscount(NameSkTXt.Text, Convert.ToDecimal(PrecentTxt.Text), Convert.ToDateTime(StartDatTxt.Text).ToString(), Convert.ToDateTime(EndDatTxt.Text).ToString(), Convert.ToInt32(id));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            skid.InsertDiscount(NameSkTXt.Text, Convert.ToDecimal(PrecentTxt.Text), Convert.ToDateTime(StartDatTxt.Text).ToString(), Convert.ToDateTime(EndDatTxt.Text).ToString());
            SkidkaDgr.ItemsSource = skid.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (SkidkaDgr.SelectedItem as DataRowView).Row[0];
            skid.DeleteDiscount(Convert.ToInt32(id));
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            AboutOrders aboutOrders = new AboutOrders();
            aboutOrders.Show();
            this.Close();
        }

        private void NameSkTXt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NameSkTXt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PrecentTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9,,]+$") && PrecentTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
