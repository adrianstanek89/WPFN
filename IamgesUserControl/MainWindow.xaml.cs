using System;
using System.Collections.Generic;
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

namespace IamgesUserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<OurImage> images = new List<OurImage>()
            {
                new OurImage()
            };
            images.Add(new OurImage("user.png", "user"));
            images.Add(new OurImage("test.png", "user"));
            images.Add(new OurImage("user.png", "user"));
            images.Add(new OurImage("asd.png", "user"));

            this.DataContext = images;
        }
    }
}
