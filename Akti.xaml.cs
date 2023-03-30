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
    /// Логика взаимодействия для Akti.xaml
    /// </summary>
    public partial class Akti : Window
    {
        PromotionsTableAdapter disc = new PromotionsTableAdapter();
        public Akti()
        {
            InitializeComponent();
            AktiDgr.ItemsSource = disc.GetData();
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

            object id = (AktiDgr.SelectedItem as DataRowView).Row[0];
            disc.UpdateProm(NameaktiTXt.Text, DisripAktiTxt.Text, Convert.ToDateTime(StartDateTxt.Text).ToString(), Convert.ToDateTime(EndDateTxt.Text).ToString(), Convert.ToInt32(id));

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            disc.InsertProm(NameaktiTXt.Text, DisripAktiTxt.Text, Convert.ToDateTime(StartDateTxt.Text).ToString(), Convert.ToDateTime(EndDateTxt.Text).ToString());
            AktiDgr.ItemsSource = disc.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (AktiDgr.SelectedItem as DataRowView).Row[0];
            disc.DeleteProm(Convert.ToInt32(id));
        }

        private void AktiDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = AktiDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();
                string value3 = rowView[3].ToString();
                string value4 = rowView[4].ToString();

                NameaktiTXt.Text = value1;
                DisripAktiTxt.Text = value2;
                StartDateTxt.Text = value3;
                EndDateTxt.Text = value4;
            }
        }

        private void NameaktiTXt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NameaktiTXt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void DisripAktiTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && DisripAktiTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }

}
