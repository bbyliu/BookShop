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
    /// Логика взаимодействия для Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        BooksTableAdapter buyBook = new BooksTableAdapter();
        AuthorsTableAdapter aubk = new AuthorsTableAdapter();
        PublishersTableAdapter pbubbk = new PublishersTableAdapter();
        GenresTableAdapter gnbk = new GenresTableAdapter();
        PromotionsTableAdapter prombk = new PromotionsTableAdapter();
        public Customer()
        {
            InitializeComponent();
            Byu.ItemsSource = buyBook.GetData();

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
            PromTxt.DisplayMemberPath = "name";
            PromTxt.SelectedValuePath = "id";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MenuItem meniitem = sender as MenuItem;

            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView rowView = Byu.SelectedItem as DataRowView;
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
        private void AutTxt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (AutTxt.SelectedItem as DataRowView).Row[2];

        }

        
    }
}