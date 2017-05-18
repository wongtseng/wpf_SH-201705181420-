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
        public UC_choose()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {

            string name="";
            bool repeat = false;
            ListBoxItem aa = new ListBoxItem(); ;

            if (ListL.Items.Count>0)
            {

                for (int i = 0; i <= ListL.Items.Count-1; i++)
                {

                    if ((ListL.Items[i] as ListBoxItem).Content.ToString() == (ListR.SelectedItem as ListBoxItem).Content.ToString())
                    {
                        MessageBox.Show((ListL.Items[i] as ListBoxItem).Content + "    " + (ListR.SelectedItem as ListBoxItem).Content);
                        repeat = true;
                        return;
                    }
                       
                }
                    if (repeat!=true)
                    {
                    name = (ListR.SelectedItem as ListBoxItem).Content.ToString();
                        aa.Content = name;
                        ListL.Items.Add(aa);
            
                    }

            }
            else
            { 
                name = (ListR.SelectedItem as ListBoxItem).Content.ToString();
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
                string cc = (ListL.Items[index + 1] as ListBoxItem).Content.ToString();
                (ListL.Items[index + 1] as ListBoxItem).Content = (ListL.Items[index] as ListBoxItem).Content;
                (ListL.Items[index] as ListBoxItem).Content = cc;
                (ListL.Items[index + 1] as ListBoxItem).IsSelected = true;
            }

        }

        private void Btn_up_Click(object sender, RoutedEventArgs e)
        {
            int count = ListL.Items.Count;
            int index = ListL.SelectedIndex;

            if (index >= 1)
            {
                string cc = (ListL.Items[index - 1] as ListBoxItem).Content.ToString();
                (ListL.Items[index - 1] as ListBoxItem).Content = (ListL.Items[index] as ListBoxItem).Content;
                (ListL.Items[index] as ListBoxItem).Content = cc;
                (ListL.Items[index - 1] as ListBoxItem).IsSelected = true;
            }

        }



    }





}
