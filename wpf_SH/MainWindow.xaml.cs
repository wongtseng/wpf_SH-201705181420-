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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


     
        system page_system;
        Page_task page_rwgh;
        page_device page_device;
        Page_temp page_temp;


        Page_plugin_task plugin_task;
        Page_plugin_Data plugin_data;
        Page_Plugin_wireless plugin_wireless;
        Page_Plugin_Wire plugin_wire;
        Page_Plugin_phy plugin_phy;
        Page_Plugin_UCAssessment plugin_Assessment;
        Page_Plugin_OffLine plugin_offLine;
        Page_Plugin_DataManage plugin_Datamanage;

        string name;

        uc_pluginbtn[] plugins;
       
        

        public string username
        {
            set { name = value;

                lb_user.Content = "当前用户："+name;
            }
            get { return name; }


        }


        public MainWindow()
        {
            InitializeComponent();
              SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            plugins = new uc_pluginbtn[] { UCrwgh, UCdata, UCwireless, UCwire, UCphy, UCAssessment, UCoffline, UCsbjk, UCdatemanage, UCsystem };

        
        }

       
  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
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
                    case "任务管理":
                         if(plugin_task == null)
                        {
                        plugin_task = new  Page_plugin_task();
                        }

                        MyContentControl.Content = new Frame()
                        {
                            Content = plugin_task

                        };
                        break;
                    case "数据录入":
                    if (plugin_data == null)
                    {
                        plugin_data = new  Page_plugin_Data();
                    }

                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_data

                    };
                    break;
                    case "设备监控":
                        if (page_device == null)
                        {
                            page_temp = new Page_temp();
                        }
                        MyContentControl.Content = new Frame()
                        {
                            Content = page_temp

                        };
                        break;
                    case "无线检查":
                        if (plugin_wireless == null)
                        {
                        plugin_wireless = new Page_Plugin_wireless();

                        }
                        MyContentControl.Content = new Frame()
                        {
                            Content = plugin_wireless
                        };
                        break;
                    case "系统管理":
                    if (page_system == null)
                    {
                        page_system = new system();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = page_system
                    };

                    break;
                    case "有线检查":
                
                    if (plugin_wire == null)
                    {
                        plugin_wire = new Page_Plugin_Wire();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_wire
                    };
                

                    break;
                    case "物理检查"://
                    if (plugin_phy == null)
                    {
                        plugin_phy = new Page_Plugin_phy();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_phy
                    };

                    break;
                    case "综合评估"://
                    if (plugin_Assessment == null)
                    {
                        plugin_Assessment = new Page_Plugin_UCAssessment();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_Assessment
                    };
                    break;
                    case "离线分析":
                    if (plugin_offLine == null)
                    {
                        plugin_offLine = new  Page_Plugin_OffLine();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_offLine
                    };
                    break;
                    case "数据管理"://
                    if (plugin_Datamanage == null)
                    {
                        plugin_Datamanage = new  Page_Plugin_DataManage();

                    }
                    MyContentControl.Content = new Frame()
                    {
                        Content = plugin_Datamanage
                    };
                    break;

                }


            }

     



       

        private void UCrwzx_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //UCrwgh.Change();
            ////UCrwzx.Change();
            //UCsbjk.Change();
            //UCsystem.Change();


            //if (page_rwzx == null)
            //{
            //    page_rwzx = new rwzx();
            //}
            //MyContentControl.Content = new Frame()
            //{
            //    Content = page_rwzx
            //};
        }

        

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UCrwgh.Click();

            Btn_PreviewMouseDown(UCrwgh, null);
          
        }
    }
}
