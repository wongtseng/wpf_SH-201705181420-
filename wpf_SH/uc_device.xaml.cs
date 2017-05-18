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

namespace wpf_SH
{
    /// <summary>
    /// uc_device.xaml 的交互逻辑
    /// </summary>
    public partial class UC_device : UserControl
    {

        private string name;
        private string ip_Time;
        private bool on_off;
        private string detype;

        Color Color_on = (Color)ColorConverter.ConvertFromString("#2279d6");
        Color Color_off = (Color)ColorConverter.ConvertFromString("#BE0003");
        public UC_device()
        {
            InitializeComponent();

        }
        
    
        
        public string d_name
        {
            set { name = value;
                xname.Text = value;
            }
            get { return name; }
        }

        public string d_ip_Time
        {
            set { ip_Time = value;

                IPtime.Text = value;


            }
            get { return ip_Time; }
        }

        public bool d_on_off
        {
            set { on_off = value;
                if (on_off == false)
                    onoff.Fill = new SolidColorBrush(Color_on);
                else
                    onoff.Fill = new SolidColorBrush(Color_off);


            }
            get { return on_off; }
        }

        public string d_type
        {
            set { detype = value;
                switch(value)
                {
                    case "lab":
                        imagetype.Source = new BitmapImage(new Uri(@"images/笔记本.png", UriKind.Relative));
                        break;
                    case "server":
                        this.imagetype.Source = new BitmapImage(new Uri(@"images/服务器.png", UriKind.Relative));
                        break;
                    case "device":
                        this.imagetype.Source = new BitmapImage(new Uri(@"images/设备.png", UriKind.Relative));
                        break;

                }

            }
            get { return name; }
        }

    }
}
