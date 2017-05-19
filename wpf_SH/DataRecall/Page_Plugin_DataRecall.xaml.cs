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
    /// Page_Plugin_DataRecall.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Plugin_DataRecall : Page
    {
        bool fold = false;
        UcMyRbtn[] rbtns;
        static int borderwidth = 200;
        


        public Page_Plugin_DataRecall()
        {
            SplashScreen aa = new SplashScreen("images/hourglass.png");
            aa.Show(true);

            InitializeComponent();
          

            MyRadiobtn1.Click();
            rbtns = new UcMyRbtn[] { MyRadiobtn1, MyRadiobtn2, MyRadiobtn3, MyRadiobtn4, MyRadiobtn5 };
            //scope2.Title.Text = "频谱图";
            //scope2.YAxis.AxisLabel.Text = "信号强度（dBM）";
            //scope2.Title.Font.Size = 13;


        }

        

        private void MyRadiobtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var d = sender as UcMyRbtn;

            for (int i = 0; i < rbtns.Length; i++)
            {
                if (rbtns[i] != d)
                {
                    rbtns[i].Change();
                }

            }
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
    }
}
