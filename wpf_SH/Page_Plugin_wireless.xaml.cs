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
    /// Page_Plugin_wireless.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Plugin_wireless : Page
    {
        Page_task page_rwgh;
        rwzx page_rwzx;
        uc_pluginbtn[] plugins;

        public Page_Plugin_wireless()
        {
            InitializeComponent();
            InitializeComponent();
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UC_Plugins1, UC_Plugins2,UC_Plugins3,UC_Plugins4, UC_Plugins5, UC_Plugins6, UC_Plugins7, UC_Plugins8 };
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
                case "频谱分析":
                    if (page_rwgh == null)
                    {
                        page_rwgh = new Page_task();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwgh

                    };
                    break;

                case "信号识别":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "无线视频":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "话音取证":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "结果呈现":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;
                case "PR100":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "频谱仪（驻留）":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "协同分析（驻留）":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;


            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
