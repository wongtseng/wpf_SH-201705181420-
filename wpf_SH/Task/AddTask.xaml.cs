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
using System.Windows.Shapes;

namespace wpf_SH.Task
{
    /// <summary>
    /// AddTask.xaml 的交互逻辑
    /// </summary>
    public partial class AddTask : Window
    {
        UC_choose mychoose;
        public AddTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            chooseuserfather.Visibility = System.Windows.Visibility.Collapsed;
            allborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Transparent"));//原始色
            string[] choose = mychoose.p_chooseValue;
            if (choose != null)
            {
                object oj = Findtextbox.FindName(mychoose.P_tb_name);
           
                TextBox valuetb = oj as  TextBox;

                valuetb.Text = null;
                for (int i = 0; i < choose.Length; i++)
                    valuetb.Text += mychoose.p_chooseValue[i] + "  ";
            }

        }

        public void  AddContent(object sender, RoutedEventArgs e)
        {
            allborder.Background= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2d2c31"));//原始色
            Button thisbtn = sender as Button;
            if(mychoose==null)
            mychoose = new UC_choose();
         

            mychoose.p_Type = thisbtn.Tag.ToString();
            if (mychoose.p_Type == "检查人员")
                mychoose.P_tb_name = "tb_choose_User";
            if(mychoose.p_Type=="检查地点")
                mychoose.P_tb_name = "tb_choose_place";


            chooseuser.Child = mychoose;
            chooseuserfather.Visibility = System.Windows.Visibility.Visible;
            chooseuser.Visibility = System.Windows.Visibility.Visible;


        }
    }
}
