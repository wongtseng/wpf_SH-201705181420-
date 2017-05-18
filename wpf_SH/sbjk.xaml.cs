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
    /// page_device.xaml 的交互逻辑
    /// </summary>
    public partial class page_device : Page
    {
        public page_device()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UC_device uc = new UC_device();
            uc.d_type = "server";
           // wp2.Children.Add(uc);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UC_device uc = new UC_device();
            uc.d_type = "lab";
          //  wp1.Children.Add(uc);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UC_device uc = new UC_device();
            uc.d_type = "device";
           // wp2.Children.Add(uc);
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (right.Width != 0)
                right.Width = 0;
            else
                right.Width = 150;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
