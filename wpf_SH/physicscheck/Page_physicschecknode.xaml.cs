using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace wpf_SH.physicscheck
{
    /// <summary>
    /// Page_physicschecknode.xaml 的交互逻辑
    /// </summary>
    public partial class Page_physicschecknode : Page
    {
        bool fold = false;
      
        static int borderwidth = 250;

       

        public Page_physicschecknode()
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
