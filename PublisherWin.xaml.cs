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
    /// Логика взаимодействия для PublisherWin.xaml
    /// </summary>
    public partial class PublisherWin : Window
    {
        PublishersTableAdapter pb = new PublishersTableAdapter();
        public PublisherWin()
        {
            InitializeComponent();
            PubDgr.ItemsSource = pb.GetData();
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (PubDgr.SelectedItem as DataRowView).Row[0];
            pb.UpdatePub(NamePubTXt.Text, AdressTxt.Text, PhoneTxt.Text, Convert.ToInt32(id));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            pb.InsertPub(NamePubTXt.Text, AdressTxt.Text, PhoneTxt.Text);
            PubDgr.ItemsSource = pb.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (PubDgr.SelectedItem as DataRowView).Row[0];
            pb.DeletePub(Convert.ToInt32(id));
        }

        private void PubDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = PubDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();

                NamePubTXt.Text = value1;
                AdressTxt.Text = value2;
                PhoneTxt.Text = value3;
            }
        }

        private void NamePubTXt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NamePubTXt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void AdressTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z-,,0-9]+$") && AdressTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PhoneTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9,+]+$") && PhoneTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
