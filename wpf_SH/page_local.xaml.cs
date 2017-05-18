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
    /// page_local.xaml 的交互逻辑
    /// </summary>
    public partial class page_local : Page
    {
        public page_local()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addlocal add_local = new addlocal();
            add_local.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_local.ShowDialog();

        }
    }
}
