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
    /// Page_device.xaml 的交互逻辑
    /// </summary>
    public partial class Page_device : Page
    {
        public Page_device()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addDevice add_device= new addDevice();
            add_device.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_device.ShowDialog();

        }
    }
}
