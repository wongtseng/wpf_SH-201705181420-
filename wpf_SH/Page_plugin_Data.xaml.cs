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
using wpf_SH.DataInput;

namespace wpf_SH
{
    /// <summary>
    /// Page_plugin_Data.xaml 的交互逻辑
    /// </summary>
    public partial class Page_plugin_Data : Page
    {
        Page_task page_rwgh;
        rwzx page_rwzx;
        uc_pluginbtn[] plugins;
        Page_Input_LocalData inputlocal;
        Page_Input_ShareData sharedate;

        public Page_plugin_Data()
        {
            InitializeComponent();
            InitializeComponent();
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UCTaskMange, UCTaskmonitor };
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
                case "本地数据录入":
                    if (inputlocal == null)
                    {
                        inputlocal = new  Page_Input_LocalData();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = inputlocal

                    };
                    break;

                case "协同数据录入":
                    if (sharedate == null)
                    {
                        sharedate = new  Page_Input_ShareData();
                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = sharedate

                    };
                    break;

            }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }


    }
}
