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
    /// Page_Video_recall.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Video_recall : Page
    {
        public Page_Video_recall()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //new Uri(@"images/任务规划.png", UriKind.Relative)
            // Myvideo.Source = new Uri(@"images/wmv.wmv", UriKind.Relative);//new Uri("pack://application:,,,/程序集名称;component/Resources/bj.png", UriKind.Absolute);
            //Myvideo.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          //  Myvideo.Stop();
        }

        private void Myvideo_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
