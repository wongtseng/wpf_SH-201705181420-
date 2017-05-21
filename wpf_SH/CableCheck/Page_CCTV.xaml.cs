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

namespace wpf_SH.CableCheck
{
    /// <summary>
    /// Page_CCTV.xaml 的交互逻辑
    /// </summary>
    public partial class Page_CCTV : Page
    {
        bool fold = false;
        static int borderwidth = 250;



        public Page_CCTV()
        {
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);
            InitializeComponent();
            MyRadiobtn1.Click();
        }
        private void MyRadiobtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var d = sender as UcMyRbtn;
        }

        private void MyRadiobtn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (fold == false)
            {
                MyBorderR.Width = 0;
                MyBorderR.Margin = new Thickness(0);
                fold = true;
            }
            else
            {
                MyBorderR.Width = borderwidth;
                MyBorderR.Margin = new Thickness(5, 5, 2, 5);
                fold = false;

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
