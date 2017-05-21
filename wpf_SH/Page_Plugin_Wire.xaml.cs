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
using wpf_SH.CableCheck;
namespace wpf_SH
{
    /// <summary>
    /// Page_Plugin_Wire.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Plugin_Wire : Page
    {
        Page_task page_rwgh;
        rwzx page_rwzx;
        uc_pluginbtn[] plugins;
        Page_PowerLine powerline;
        Page_CCTV cctv;
        Page_CircleCheck circle;
        Page_CircleCheckResult circleresult;




        public Page_Plugin_Wire()
        {
            InitializeComponent();
            InitializeComponent();
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UC_Plugins1, UC_Plugins2, UC_Plugins3, UC_Plugins4 };
        }

        private void Btn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            uc_pluginbtn thisone = sender as uc_pluginbtn;
            for (int i = 0; i < plugins.Length; i++)
            {
                if (plugins[i] != thisone)
                {
                    plugins[i].Change();
                }
            }

            switch (thisone.p_type)
            {
                case "电力线":
                    if (powerline == null)
                    {
                        powerline = new  Page_PowerLine();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = powerline

                    };
                    break;

                case "闭路电视":
                    if (cctv == null)
                    {
                        cctv = new  Page_CCTV();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = cctv

                    };
                    break;

                case "线缆分析":
                    if (circle == null)
                    {
                        circle = new  Page_CircleCheck();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = circle

                    };
                    break;

                case "线缆分析_结果呈现":
                    if (circleresult == null)
                    {
                        circleresult = new  Page_CircleCheckResult();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = circleresult

                    };
                    break;

            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
