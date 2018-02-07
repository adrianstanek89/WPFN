using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PersonData> dataGridPerson = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();
            dataGridPerson.Add(new PersonData()
            {
                Name = "Maciek",
                Age = 24,
                Email = "asd@asd.pl",
                IsSubscribedToNewsletter = true,
                WebSite = new Uri("http://mila.com"),
                Image = "user.png",
                Description = "To jest wino"
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Ola",
                Age = 224,
                Email = "asd@asd.pl",
                IsSubscribedToNewsletter = false,
                
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Konrad",
                Age = 249,
                Email = "asd@asldkpaosjd.pl"
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Konrad",
                Age = 249,
                Email = "asd@asldkpaosjd.pl"
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Konrad",
                Age = 249,
                Email = "asd@asldkpaosjd.pl"
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Konrad",
                Age = 249,
                Email = "asd@asldkpaosjd.pl"
            }
            );
            dataGridPerson.Add(new PersonData()
            {
                Name = "Konrad",
                Age = 249,
                Email = "asd@asldkpaosjd.pl"
            }
            );

            dataGridPeople.ItemsSource = dataGridPerson;

        }
    }
}
