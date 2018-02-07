using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> listOfPeople = new ObservableCollection<PersonData>();

        //private string Email_Regex =   
        string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        
        public MainWindow()
        {
            InitializeComponent();
            listOfPeople.Add(new PersonData() { Name = "Warol", Age = 24, Email = "karol@wp.pl" });
            listOfPeople.Add(new PersonData() { Name = "Warol", Age = 20, Email = "karol@wp.pl" });
            listOfPeople.Add(new PersonData() { Name = "Aneta", Age = 200, Email = "maciek@wp.pl" });
            listOfPeople.Add(new PersonData() { Name = "Marta", Age = 25, Email = "marta@wp.pl" });

            ListaImion.ItemsSource = listOfPeople;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = int.TryParse(AgeToAdd.Text, out var num) ? num : 0,
                Email = Regex.IsMatch(EmailToAdd.Text, pattern) ? EmailToAdd.Text : string.Empty });
        }

        private void NameToAdd_GotFocus(object sender, RoutedEventArgs e)
        {
            //if(EmailToAdd.Text == "Wpisz imie")
            //{
            //    NameToAdd.Clear();
            //}
           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedItem = (PersonData)ListaImion.SelectedItem;
            if (selectedItem != null)
            {
                listOfPeople.Remove(selectedItem);
            }
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = (sender as GridViewColumnHeader);
            string columnNameToSort = header.Content.ToString();

            var howToSort = ListSortDirection.Ascending;

            CollectionView view = CollectionViewSource.GetDefaultView(ListaImion.ItemsSource) as CollectionView;

            if(view.SortDescriptions.Any())
            {
                SortDescription item = view.SortDescriptions.ElementAt(0);
                if(columnNameToSort == item.PropertyName.ToString())
                {
                    if(item.Direction == ListSortDirection.Ascending)
                    {
                        howToSort = ListSortDirection.Descending;
                    }
                    else
                    {
                        howToSort = ListSortDirection.Ascending;
                    }
                }
            }

            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription(columnNameToSort, howToSort));
        }

        
    }
}
