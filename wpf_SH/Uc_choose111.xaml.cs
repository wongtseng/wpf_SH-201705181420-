using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace wpf_SH
{
  /// <summary>
  /// 
  /// </summary>
    public partial class Uc_choose : UserControl
    {
        public Uc_choose()
        {
            InitializeComponent();
        }

      

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {

            string name = (ListR.SelectedItem as ListBoxItem).Content.ToString();
            ListBoxItem aa = new ListBoxItem();
            aa.Content = name;
            listl.Items.Add(aa);
        }

        private void Btn_remove_Click(object sender, RoutedEventArgs e)
        {

            if (listl.SelectedItem != null)
            {
                listl.Items.Remove(listl.SelectedItem);
            }

        }

        private void Btn_down_Click(object sender, RoutedEventArgs e)
        {
            int count = listl.Items.Count;
            int index = listl.SelectedIndex;

            if (index < count - 1)
            {
                string cc = (listl.Items[index + 1] as ListBoxItem).Content.ToString();
                (listl.Items[index + 1] as ListBoxItem).Content = (listl.Items[index] as ListBoxItem).Content;
                (listl.Items[index] as ListBoxItem).Content = cc;
                (listl.Items[index + 1] as ListBoxItem).IsSelected = true;
            }

        }

        private void Btn_up_Click(object sender, RoutedEventArgs e)
        {
            int count = listl.Items.Count;
            int index = listl.SelectedIndex;

            if (index >= 1)
            {
                string cc = (listl.Items[index - 1] as ListBoxItem).Content.ToString();
                (listl.Items[index - 1] as ListBoxItem).Content = (listl.Items[index] as ListBoxItem).Content;
                (listl.Items[index] as ListBoxItem).Content = cc;
                (listl.Items[index - 1] as ListBoxItem).IsSelected = true;
            }

        }
    }
}
