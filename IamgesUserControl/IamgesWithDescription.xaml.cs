using System.Windows.Controls;

namespace DependecyProperty
{
    /// <summary>
    /// Interaction logic for IamgesWithDescription.xaml
    /// </summary>
    public partial class IamgesWithDescription : UserControl
    {
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
                //switch (_blur)
                //{
                //    case "Off":                        
                //        this.blurek.Radius = 0;
                //        break;
                //    case "Medium":
                //        this.blurek.Radius = 2;
                //        break;
                //    case "Full":
                //        this.blurek.Radius = 6;
                //        break;
                //    default:
                //        this.blurek.Radius = 1;
                //        break;
                //}
            }
        }

        public IamgesWithDescription()
        {
            //InitializeComponent();
        }
    }
}
