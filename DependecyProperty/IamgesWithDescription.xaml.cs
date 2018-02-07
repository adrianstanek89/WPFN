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

namespace OurDependecyProperty
{
    /// <summary>
    /// Interaction logic for IamgesWithDescription.xaml
    /// </summary>
    public partial class IamgesWithDescription : UserControl
    {
        #region Properties
        private double _szerokosc;
        public double Szerokosc
        {
            get
            {
                return _szerokosc;
            }
            set
            {
                _szerokosc = value;
                this.Width = _szerokosc / 2;
            }
        }

        private string _blur;
        public string Blur
        {
            get
            {
                return _blur;
            }
            set
            {
                _blur = value;
                switch (_blur)
                {
                    case "Off":
                        this.blurek.Radius = 0;
                        break;
                    case "Medium":
                        this.blurek.Radius = 2;
                        break;
                    case "Full":
                        this.blurek.Radius = 6;
                        break;
                    default:
                        this.blurek.Radius = 1;
                        break;
                }
            }
        }
        #endregion

        #region DependencyProperty
        //private List<OurImage> _imagesSource;
        public List<OurImage> ImagesSource
        {
            get
            {
                return (List<OurImage>)GetValue(ImagesSourceProperty);
            }
            set
            {
                SetValue(ImagesSourceProperty, value);
            }
        }


        //ImagesSource trzeba powiazac z zwyklym property poprzez rejstracje
        public static readonly DependencyProperty ImagesSourceProperty = DependencyProperty.Register(
            "ImagesSource", //nazwa naszego zwyklego property
            typeof(List<OurImage>), //typ jaki jest zwracany przez nasze zwykle property
            typeof(IamgesWithDescription), //klasa w ktorej znajduje sie nasze property
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback((dependecyObject, dependecyPropertyEventArgs) => {
                //jest to wywolanie anonimowej funkcji
                //dependecyObject - zrodlow wywolania (IamgesWithDescription)
                //dependecyPropertyEventArgs - wlasciwosc ktora zostala zmieniona (ImagesSource)

                var source = dependecyObject as IamgesWithDescription;

                source.itemsControl.ItemsSource = (List<OurImage>)dependecyPropertyEventArgs.NewValue;
            }))
            );
        #endregion

        
        public IamgesWithDescription()
        {
            InitializeComponent();
            ImagesSource = new List<OurImage>();
        }
    }
}
