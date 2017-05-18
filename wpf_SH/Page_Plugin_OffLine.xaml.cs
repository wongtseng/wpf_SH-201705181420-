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
    /// Page_Plugin_OffLine.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Plugin_OffLine : Page
    {
        Page_task page_rwgh;
        rwzx page_rwzx;
        uc_pluginbtn[] plugins;

        public Page_Plugin_OffLine()
        {
            InitializeComponent();
            InitializeComponent();
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UC_Plugins1, UC_Plugins2 };
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
                    if (page_rwgh == null)
                    {
                        page_rwgh = new Page_task();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwgh

                    };
                    break;

                case "闭路电视":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "线缆分析":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "缆分析_结果呈现":
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
