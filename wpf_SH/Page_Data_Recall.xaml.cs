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
    /// Page_Data_Recall.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Data_Recall : Page
    {
        public Page_Data_Recall()
        {
            InitializeComponent();
            scope2.YAxis.Min.Value = 0;
            scope2.YAxis.Max.Value =100;
            scope2.YAxis.MajorTicks.Step = 3;
            
        }
    }
}
