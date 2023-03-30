using BookShop.MyBookShopDataSetTableAdapters;
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

namespace BookShop
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        BooksTableAdapter bk = new BooksTableAdapter();
        AuthorsTableAdapter aubk = new AuthorsTableAdapter();
        PublishersTableAdapter pbubbk = new PublishersTableAdapter();
        GenresTableAdapter gnbk = new GenresTableAdapter();
        PromotionsTableAdapter prombk = new PromotionsTableAdapter();
        public Admin()
        {
            InitializeComponent();
            BookDgr.ItemsSource = bk.GetData();
            AutTxt.ItemsSource = aubk.GetData();
            AutTxt.DisplayMemberPath = "last_name";
            AutTxt.SelectedValuePath = "id";

            PubTxt.ItemsSource = pbubbk.GetData();
            PubTxt.DisplayMemberPath = "name";
            PubTxt.SelectedValuePath = "id";

            GenTxt.ItemsSource = gnbk.GetData();
            GenTxt.DisplayMemberPath = "name";
            GenTxt.SelectedValuePath = "id";

            PromTxt.ItemsSource = prombk.GetData();
            PromTxt.DisplayMemberPath= "name";
            PromTxt.SelectedValuePath = "id";

        }
        private void MuneItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            Admin admin = new Admin();
            admin.Show();
            this.Close();

        }
        private void MuneItem_Click2(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            UserAbout userAbout = new UserAbout();
            userAbout.Show();
            this.Close();
        }
        private void MuneItem_Click3(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            AboutOrders aboutOrders = new AboutOrders();
            aboutOrders.Show();
            this.Close();
        }
        private void MuneItem_Click4(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            AuthorWin authorWin = new AuthorWin();
            authorWin.Show();
            this.Close();
        }
        private void MuneItem_Click5(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            GenreWin genreWin = new GenreWin(); 
            genreWin.Show();    
            this.Close();
        }
        private void MuneItem_Click6(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            PublisherWin publisherWin = new PublisherWin(); 
            publisherWin.Show();
            this.Close();
        }
        private void MuneItem_Click7(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;
            Akti akti = new Akti(); 
            akti.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            object id = (BookDgr.SelectedItem as DataRowView).Row[0];
            bk.UpdateBook(NameTbx.Text, Convert.ToInt32(AutTxt.SelectedValue), Convert.ToInt32(PubTxt.SelectedValue), Convert.ToInt32(yearTxt.Text), Convert.ToInt32(GenTxt.SelectedValue), Convert.ToInt32(PagesTxt.Text), Convert.ToDecimal(PriceTxt.Text), Convert.ToInt32(PromTxt.SelectedValue), Convert.ToInt32(id));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bk.InsertBook(NameTbx.Text, Convert.ToInt32(AutTxt.SelectedValue), Convert.ToInt32(PubTxt.SelectedValue), Convert.ToInt32(yearTxt.Text), Convert.ToInt32(GenTxt.SelectedValue), Convert.ToInt32(PagesTxt.Text), Convert.ToDecimal(PriceTxt.Text), Convert.ToInt32(PromTxt.SelectedValue));
            BookDgr.ItemsSource = bk.GetData();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (BookDgr.SelectedItem as DataRowView).Row[0];
            bk.DeleteBook(Convert.ToInt32(id));
        }

        private void BookDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = BookDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                var cbinfo = rowView[2];
                var pubinfo = rowView[3];
                string value4 = rowView[4].ToString();
                var geninfo = rowView[5];
                string value6 = rowView[6].ToString();
                string value7 = rowView[7].ToString();
                var prominfo = rowView[8];

                NameTbx.Text = value1;
                yearTxt.Text = value4;
                PagesTxt.Text = value6;
                PriceTxt.Text = value7;
                PromTxt.SelectedValue = prominfo;
                if (cbinfo != null)
                {
                    AutTxt.SelectedValue = cbinfo;
                }
                if (pubinfo != null)
                {
                    PubTxt.SelectedValue = pubinfo;
                }
                if (geninfo != null)
                {
                    GenTxt.SelectedValue = geninfo;
                }
               

            }
            
        }

        private void AutTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (AutTxt.SelectedItem as DataRowView).Row[2];
            
        }

        private void PubTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (PubTxt.SelectedItem as DataRowView).Row[1];
        }

        private void GenTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (GenTxt.SelectedItem as DataRowView).Row[1];
        }

        private void PromTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (PromTxt.SelectedItem as DataRowView).Row[1];
        }

        private void NameTbx_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NameTbx.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void yearTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9]+$") && yearTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PagesTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9]+$") && PagesTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void PriceTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9-,]+$") && NameTbx.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
