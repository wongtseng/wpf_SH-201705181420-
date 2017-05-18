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
    /// Page_task.xaml 的交互逻辑
    /// </summary>
    public partial class Page_task : Page
    {
        public Page_task()
        {

            InitializeComponent();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addTask add_task = new addTask();
            add_task.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_task.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            showtask show_task = new showtask();
            show_task.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
            show_task.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            alert alert = new alert();
            alert.ShowDialog();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void dg_user_Loaded(object sender, RoutedEventArgs e)
        {
            dg_user.Visibility = Visibility.Visible;
        }
    }
}
