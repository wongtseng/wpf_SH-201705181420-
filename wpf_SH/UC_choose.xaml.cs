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
    /// UC_choose.xaml 的交互逻辑
    /// </summary>
    public partial class UC_choose : UserControl
    {

        private string Type;
        private string  tb_name;
      
        public UC_choose()
        {
            InitializeComponent();
        }

      
        public string P_tb_name
        {
            set
            {
                tb_name = value;
            }
            get
            {
                return tb_name;
            }

        }



        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {

            string name = "";
            bool repeat = false;
            ListBoxItem aa;

            if (ListL.Items.Count > 0)
            {

                for (int i = 0; i <= ListL.Items.Count - 1; i++)
                {
                    //name = ListL.Items[i].ToString();ListBoxItem:
                    name = ListL.Items[i].ToString();
                    int a = name.LastIndexOf(":");
                    name = name.Substring(a+1).Trim();
                    
                   
                   
                   
                    string name2 = ListR.SelectedItem.ToString();
                    if (name==name2)
                    {
                        MessageBox.Show("已存在" + ListL.Items[i].ToString());
                        repeat = true;
                        return;
                    }

                }
                if (repeat != true)
                {
                    ListL.Items.Add(ListR.SelectedItem);
                }

            }
            else
            {
                name = string.Empty;
                name= ListR.SelectedItem.ToString();
                         //  name = (ListR.SelectedItem as ListBoxItem).Content.ToString();
                aa = new ListBoxItem(); ;
                aa.Content = name;
      
                ListL.Items.Add(aa);
            }

        }

        private void Btn_remove_Click(object sender, RoutedEventArgs e)
        {

            if (ListL.SelectedItem != null)
            {
                ListL.Items.Remove(ListL.SelectedItem);
            }

        }

        private void Btn_down_Click(object sender, RoutedEventArgs e)
        {
            int count = ListL.Items.Count;
            int index = ListL.SelectedIndex;

            if (index < count - 1)
            {
               
               object cc = ListL.Items[index + 1];
                ListL.Items[index +1] = ListL.Items[index];
                ListL.Items[index] = cc;
                ListL.SelectedIndex = index +1;
            }

        }

        private void Btn_up_Click(object sender, RoutedEventArgs e)
        {
            int count = ListL.Items.Count;
            int index = ListL.SelectedIndex;
        

            if (index >1)
            {

                string cc = ListL.Items[index - 1].ToString();
                ListL.Items[index - 1] = ListL.Items[index].ToString();
                ListL.Items[index] = cc;
                ListL.SelectedIndex = index -1;


            }
            if (index == 1)
            {
                int Strindex = ListL.Items[index - 1].ToString().IndexOf(":");
                string cc = ListL.Items[index - 1].ToString().Substring(Strindex +1).Trim();
                ListL.Items[index - 1] = ListL.Items[index].ToString();
                ListL.Items[index] = cc;
                ListL.SelectedIndex = index - 1;

            }
          

        }

        public string p_Type
        {

            set { Type = value;
               set(Type);

            }
            get { return Type; }

        }


        public string[] p_chooseValue
        {
            set { }
            get
            {
                int length = ListL.Items.Count;
                string[] SelectedItems = new string[length];


                for (int i = 0; i < ListL.Items.Count;i++)
                {
                  
                    int Strindex = ListL.Items[i].ToString().IndexOf(":");
                    SelectedItems[i] = ListL.Items[i].ToString().Substring(Strindex + 1).Trim(); 
                  
                }

                return SelectedItems;


            }



        }

        private void set(string thisType)
        {

            switch(thisType)
            {
                case "检查内容":
                    SP.Visibility = System.Windows.Visibility.Visible;
                     LB_Type.Content = "当前检查对象为";
                    ChooseType.Content = "指定检查内容";
                    CB.IsEnabled = false;
                    TitleL.Content = "本次检查内容";
                    TitleR.Content = "可选检查内容";
                    break;
                case "检查手段":
                    SP.Visibility = System.Windows.Visibility.Visible;
                    LB_Type.Content = "选择检查内容";
                    ChooseType.Content = "指定检查手段";
                    TitleL.Content = "本次检查手段";
                    TitleR.Content = "可选检查手段";
                    break;
                case "执行人员":
                    SP.Visibility = System.Windows.Visibility.Visible;
                    LB_Type.Content = "选择检查手段";
                    ChooseType.Content = "指定操作人员";
                    TitleL.Content = "本次操作人员";
                    TitleR.Content = "可选人员";
                    break;
                case "检查人员":
                    SP.Visibility = System.Windows.Visibility.Collapsed;
                    LB_Type.Content = "选择检查手段";
                    ChooseType.Content = "指定检查人员";
                    TitleL.Content = "本次检查人员";
                    TitleR.Content = "可选人员";
                    setListR("people");
                    break;
                case "检查地点":
                    SP.Visibility = System.Windows.Visibility.Collapsed;
                    LB_Type.Content = "选择检查手段";
                    ChooseType.Content = "指定检查地点";
                    TitleL.Content = "本次检查地点";
                    TitleR.Content = "可选检查地点";
                    setListR("location");
                    break;
                case "检查对象":
                    SP.Visibility = System.Windows.Visibility.Collapsed;
                    LB_Type.Content = "选择检查手段";
                    ChooseType.Content = "指定对象";
                    TitleL.Content = "本次对象";
                    TitleR.Content = "可选检查对象";
                    setListR("object");
                    break;
            }

        }


        private  void setListR( string value_type)
        {

            if(ListR.Items.Count > 0)
            {
                //清空所有项
                ListR.Items.Clear();
                ListL.Items.Clear();
            }

          
            ListBoxItem item = new ListBoxItem();

            switch(value_type)
            {
                case "people":
                    {
                        ListR.Items.Add( item.Content="丁 益辉");
                        ListR.Items.Add(item.Content = "马伟军");
                        ListR.Items.Add(item.Content = "刘志军");
                        ListR.Items.Add(item.Content = "刘晓鹏");
                        ListR.Items.Add(item.Content = "王占军");
                   
                    }
                    break;
                case "location":
                    {
                        ListR.Items.Add(item.Content = "三楼");
                        ListR.Items.Add(item.Content = "二楼");
                        ListR.Items.Add(item.Content = "办公楼");
                        ListR.Items.Add(item.Content = "会议中心");
                        ListR.Items.Add(item.Content = "员工宿舍");
                    }
                    break;
                case "object":
                    {
                      
                        ListR.Items.Add(item.Content = "办公室201");
                        ListR.Items.Add(item.Content = "办公室203");
                        ListR.Items.Add(item.Content = "办公室901");
                        ListR.Items.Add(item.Content = "2号大会议室");
                        ListR.Items.Add(item.Content = "移动电话");
                        ListR.Items.Add(item.Content = "办公电脑");
                        ListR.Items.Add(item.Content = "墙面装饰");


                    }
                    break;
            }

            }
                   






        


         











    }

}
