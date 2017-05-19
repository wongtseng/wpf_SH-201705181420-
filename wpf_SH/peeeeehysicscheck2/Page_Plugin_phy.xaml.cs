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
using wpf_SH.physicscheck;

namespace wpf_SH
{
    /// <summary>
    /// Page_Plugin_phy.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Plugin_phy : Page
    {
        Page_task page_rwgh;
        rwzx page_rwzx;
        uc_pluginbtn[] plugins;
        Page_imageCheckMaster checkMaster;

        public Page_Plugin_phy()
        {
            InitializeComponent();
            InitializeComponent();
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UC_Plugins1, UC_Plugins2, UC_Plugins3 };
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
                case "非线性节点探测":
                    if (checkMaster == null)
                    {
                        checkMaster = new  Page_imageCheckMaster();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = checkMaster

                    };
                    break;

                case "图形图像处理":
                    if (page_rwzx == null)
                    {
                        page_rwzx = new rwzx();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_rwzx

                    };
                    break;

                case "物理分析_结果呈现":
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
