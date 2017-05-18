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
    /// rwzx.xaml 的交互逻辑
    /// </summary>
    public partial class rwzx : Page
    {
        public rwzx()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            alert alert = new alert();
            alert.ShowDialog();

            if(start.Content.ToString()=="启动任务")
            start.Content = "停止任务";
            else
                start.Content = "启动任务";
        }
    }
}
