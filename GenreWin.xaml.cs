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
    /// Логика взаимодействия для GenreWin.xaml
    /// </summary>
    public partial class GenreWin : Window
    {
        GenresTableAdapter gen = new GenresTableAdapter();
        public GenreWin()
        {
            InitializeComponent();
            GenreDgr.ItemsSource = gen.GetData();
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

            object id = (GenreDgr.SelectedItem as DataRowView).Row[0];
            gen.UpdateGenre(NameGenreTXt.Text, DisripTxt.Text, Convert.ToInt32(id));

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            gen.InsertGenre(NameGenreTXt.Text, DisripTxt.Text);
            GenreDgr.ItemsSource = gen.GetData();
        }

        private void Dele_Click(object sender, RoutedEventArgs e)
        {
            object id = (GenreDgr.SelectedItem as DataRowView).Row[0];
            gen.DeleteGenre(Convert.ToInt32(id));
        }

        

        private void GenreDgr_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DataRowView rowView = GenreDgr.SelectedItem as DataRowView;
            if (rowView != null)
            {
                string value1 = rowView[1].ToString();
                string value2 = rowView[2].ToString();


                NameGenreTXt.Text = value1;
                DisripTxt.Text = value2;

            }

        }

        private void DisripTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && NameGenreTXt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }

        private void NameGenreTXt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[a-zA-Z]+$") && DisripTxt.Text.Length <= 20)
            {
                e.Handled = true;
            }
        }
    }
}
