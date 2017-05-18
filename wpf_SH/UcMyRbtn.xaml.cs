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
    /// UcMyRbtn.xaml 的交互逻辑
    /// </summary>
    public partial class UcMyRbtn : UserControl
    {
        private string text;
        public bool Myclicked = false;

        public UcMyRbtn()
        {
            InitializeComponent();
        }

        public string p_text
        {
            set { text = value;

                MyTB.Text = text;

            }
            get { return text; }
        }

        public double p_height
        {
            set
            {
                Myborder.Height = value;
            }
            get { return MyTB.Height; }
        }
        public string p_width
        {
            set
            {
                Myborder.Width = double.Parse(value);
            }
            get { return text; }
        }

        public bool p_click
        {
            set { Myclicked = value; }

            get { return Myclicked; }


        }

        public void Change()
        {
            Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3f3f46"));//原始色
            MyTB.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3f3f46"));//原始色
            MyTB.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//原始色
            Myclicked = false;
        }

        private void Myborder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (Myclicked == false)
            {
                Myclicked = true;
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
                MyTB.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//白色
                MyTB.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
            }

            else
                Myclicked = false;



        }

        public void Click()
        {
            if (Myclicked == false)
            {
                Myclicked = true;
                Myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
                MyTB.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));//白色
                MyTB.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2279d6"));//"蓝色"
            }

            else
                Myclicked = false;


        }
    }
}
