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

namespace wpf_SH
{
    /// <summary>
    /// addTask.xaml 的交互逻辑
    /// </summary>
    public partial class addTask : Window
    {
        public addTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = new List<PersonIdIsInt>() {
            new PersonIdIsInt(){Id=1,Name="无线检查",ParentId=0},
            new PersonIdIsInt(){Id=2,Name="有线检查",ParentId=0},
            new PersonIdIsInt(){Id=3,Name="物理检查",ParentId=0},


              new PersonIdIsInt(){Id=4,Name="频谱分析",ParentId=1},
           new PersonIdIsInt(){Id=5,Name="信号采集设备",ParentId=1},
            new PersonIdIsInt(){Id=6,Name="无线网络分析设备",ParentId=1},
            new PersonIdIsInt(){Id=7,Name="伪基站检查设备",ParentId=1},
              new PersonIdIsInt(){Id=15,Name="可见光检查设备",ParentId=1},

              new PersonIdIsInt(){Id=8,Name="电力线检查设备",ParentId=2},
                new PersonIdIsInt(){Id=9,Name="线缆检查设备",ParentId=2},
                  new PersonIdIsInt(){Id=10,Name="闭路电视",ParentId=2},

                    new PersonIdIsInt(){Id=11,Name="非线性节点探测",ParentId=3},
                            new PersonIdIsInt(){Id=12,Name="X光",ParentId=3},
                        new PersonIdIsInt(){Id=13,Name="热成像",ParentId=3},
                           new PersonIdIsInt(){Id=14,Name="视频探测",ParentId=3},
            };
            commonTreeView1.SetItemsSourceData(list, p => p.Name, p => p.Id, p => p.ParentId);

            //绑定第二棵树
             list = new List<PersonIdIsInt>() {
            new PersonIdIsInt(){Id=1,Name="频谱分析",ParentId=0},
            new PersonIdIsInt(){Id=2,Name="无线网络分析",ParentId=0},
            new PersonIdIsInt(){Id=3,Name="可见光检查设",ParentId=0},
            new PersonIdIsInt(){Id=4,Name="频谱分析",ParentId=0},
           new PersonIdIsInt(){Id=5,Name="线缆检查设备",ParentId=0},

            new PersonIdIsInt(){Id=6,Name="设备1",ParentId=1},
            new PersonIdIsInt(){Id=7,Name="设备2",ParentId=1},
              new PersonIdIsInt(){Id=8,Name="设备3",ParentId=2},
                new PersonIdIsInt(){Id=9,Name="设备4",ParentId=2},
                  new PersonIdIsInt(){Id=10,Name="设备5",ParentId=3},
                    new PersonIdIsInt(){Id=11,Name="设备6",ParentId=3},
                            new PersonIdIsInt(){Id=12,Name="设备7",ParentId=4},
                        new PersonIdIsInt(){Id=13,Name="设备8",ParentId=5},
                           new PersonIdIsInt(){Id=14,Name="设备9",ParentId=5},
            };
            commonTreeView2.SetItemsSourceData(list, p => p.Name, p => p.Id, p => p.ParentId);
        }

        public class PersonIdIsInt
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int ParentId { get; set; }
        }


        public class PersonIdIsString
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string ParentId { get; set; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click_choose(object sender, RoutedEventArgs e)
        {
            choose c = new choose();
            c.ShowDialog();
           
        }
    }
}
