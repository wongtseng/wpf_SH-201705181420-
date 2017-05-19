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
    /// Page_SignRecall.xaml 的交互逻辑
    /// </summary>
    public partial class Page_SignRecall : Page
    {
        bool fold = false;
        UcMyRbtn[] rbtns;
        static int borderwidth = 250;
        Page_Data_Recall datarecall;
        Page_Sign_Recall signrecall;
        Page_Image_recall imagerecall;
        Page_Video_recall videorecall;
        Page_Audio_Recall audiorecall;


        public Page_SignRecall()
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

                if(d.p_text!="图形")
                    picmessage.Visibility = Visibility.Collapsed;

            }

            switch (d.p_text)
            {
                case "频谱回看":
                    if (datarecall == null)
                    {
                        datarecall = new Page_Data_Recall();
                    }

                    CCLeft.Content = new Frame()
                    {
                        Content = datarecall

                    };
                    break;

                case "信号回看":
                    if (signrecall == null)
                    {
                        signrecall = new   Page_Sign_Recall();
                    }
                    CCLeft.Content = new Frame()
                    {
                        Content = signrecall

                    };
                    break;

                case "图形":
                    if (imagerecall == null)
                    {
                        imagerecall = new  Page_Image_recall();
                    }
                    CCLeft.Content = new Frame()
                    {
                        Content = imagerecall

                    };
                    picmessage.Visibility = Visibility.Visible;
                    break;

                case "图像": 
                    if (videorecall == null)
                    {
                        videorecall = new  Page_Video_recall();
                    }
                    CCLeft.Content = new Frame()
                    {
                        Content = videorecall

                    };
                
                    break;
                case "话音数据":
                    if (audiorecall == null)
                    {
                        audiorecall = new  Page_Audio_Recall();
                    }
                    CCLeft.Content = new Frame()
                    {
                        Content = audiorecall

                    };
                    break;

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyRadiobtn1.Click();
            if (datarecall == null)
            {
                datarecall = new Page_Data_Recall();
            }

            CCLeft.Content = new Frame()
            {
                Content = datarecall

            };




        }
    }
}
