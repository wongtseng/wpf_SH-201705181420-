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
    /// uc_pluginbtn.xaml 的交互逻辑
    /// </summary>
    public partial class uc_pluginbtn : UserControl
    {

        Color Color_Clicked = (Color)ColorConverter.ConvertFromString("Red");
        Color Color_unClicked = (Color)ColorConverter.ConvertFromString("Black");
        bool Myclicked = false;
        private string Mytype=null;

        public uc_pluginbtn()
        {
            InitializeComponent();
        }


        public string p_type
        {
            set
            {
                Mytype = value;
                switch (value)
                {
                    case "任务管理":
                      Myimage.Source= new BitmapImage(new Uri(@"images/任务规划.png", UriKind.Relative));
                        Mylb.Content = "任务管理";
                       
                        break;
                    case "数据录入":
                        Myimage.Source = new BitmapImage(new Uri(@"images/数据录入.png", UriKind.Relative));
                        Mylb.Content = "数据录入";
                        break;
                    case "本地数据录入":
                        Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                        Mylb.Content = "本地数据录入";
                        break;
                    case "协同数据录入":
                        Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                        Mylb.Content = "协同数据录入";
                        break;
                    case "设备监控":
                        Myimage.Source = new BitmapImage(new Uri(@"images/设备监控.png", UriKind.Relative));
                        Mylb.Content = "设备监控";
                        break;
                    case "系统管理":
                        Myimage.Source = new BitmapImage(new Uri(@"images/applications.png", UriKind.Relative));
                        Mylb.Content = "系统管理";
                        break;
                    case "无线检查":
                        Myimage.Source = new BitmapImage(new Uri(@"images/无线检查.png", UriKind.Relative));
                        Mylb.Content = "无线检查";
                        break;
                                case "频谱分析":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "频谱分析";
                                    break;
                                case "信号识别":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "信号识别";
                                    break;
                                case "无线视频":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "无线视频";
                                    break;
                                case "话音取证":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "话音取证";
                                    break;
                                case "结果呈现":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "结果呈现";
                                    break;
                                case "PR100":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "PR100";
                                    break;
                                case "频谱仪":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "频谱仪";
                                    break;
                                case "协同分析":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "协同分析";
                        break;
                    case "有线检查":
                        Myimage.Source = new BitmapImage(new Uri(@"images/有线检查.png", UriKind.Relative));
                        Mylb.Content = "有线检查";
                        break;
                                case "电力线":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "电力线";
                                    break;
                                case "闭路电视":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "闭路电视";
                                    break;
                                case "线缆分析":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "线缆分析";
                                    break;
                                case "线缆分析_结果呈现":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "结果呈现";
                                    break;
                    case "物理检查":
                        Myimage.Source = new BitmapImage(new Uri(@"images/物理检查.png", UriKind.Relative));
                        Mylb.Content = "物理检查";
                        break;
                    #region 物理检查子插件
                    case "非线性节点探测":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "非线性节点探测";
                                    break;
                                case "图形图像处理":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "图形图像处理";
                                    break;
                                case "物理分析_结果呈现":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "结果呈现";
                                    break;
                    #endregion
                    case "综合评估":
                        Myimage.Source = new BitmapImage(new Uri(@"images/综合评估.png", UriKind.Relative));
                        Mylb.Content = "综合评估";
                        break;
                    #region 综合评估子插件
                                case "流程评估":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "流程评估";
                                    break;
                                case "基线评估":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "基线评估";
                                    break;
                                case "报告生成":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "报告生成";
                                    break;
                    #endregion

                    case "离线分析":
                        Myimage.Source = new BitmapImage(new Uri(@"images/离线分析.png", UriKind.Relative));
                        Mylb.Content = "离线分析";
                        break;
                    #region 离线分析 子插件
                                case "数据回溯":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "数据回溯";
                                    break;
                                case "信号分析":
                                    Myimage.Source = new BitmapImage(new Uri(@"images/plugins.png", UriKind.Relative));
                                    Mylb.Content = "信号分析";
                                    break;
                    #endregion
                    case "数据管理":
                        Myimage.Source = new BitmapImage(new Uri(@"images/数据管理.png", UriKind.Relative));
                        Mylb.Content = "数据管理";
                        break;
                    case "任务配置":
                        Myimage.Source = new BitmapImage(new Uri(@"images/数据管理.png", UriKind.Relative));
                        Mylb.Content = "任务配置";
                        break;
                    case "任务监控":
                        Myimage.Source = new BitmapImage(new Uri(@"images/数据管理.png", UriKind.Relative));
                        Mylb.Content = "任务监控";
                        break;

                }

            }
            get { return Mytype; }


        }

        public bool p_click
        {
            set { Myclicked = value; }
          
            get { return Myclicked; }


        }

        public void Change()
        {
            Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3f3f46"));//原始色
            Mylb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7d7b80"));//原始色
            Myclicked = false;
        }

        private void Myborder_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Myclicked!=true)
            {
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#252527"));//"#252527"
                Mylb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//白色
            }

          
        }

        private void Myborder_MouseLeave(object sender, MouseEventArgs e)
        {
            if(Myclicked!=true)
            {
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3f3f46"));//原始色
                Mylb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7d7b80"));//原始色

            }

           

        }

        private void Myborder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Myclicked == false)
            {
                Myclicked = true;
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
                Mylb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//白色
            }
               
            else
                Myclicked = false;


          
        }

        public void Click()
        {
            if (Myclicked == false)
            {
                Myclicked = true;
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
                Mylb.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//白色
            }

            else
                Myclicked = false;


        }


    }

            

 
    
}
