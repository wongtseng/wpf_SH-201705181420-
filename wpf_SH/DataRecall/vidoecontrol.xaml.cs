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

namespace wpf_SH.DataRecall
{
    /// <summary>
    /// vidoecontrol.xaml 的交互逻辑
    /// </summary>
    public partial class vidoecontrol : UserControl
    {

        bool play = false;
        public vidoecontrol()
        {
            InitializeComponent();
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
            if(!play)
            {
                (sender as Image).Source = new BitmapImage(new Uri(@"../images/nn-pause.png", UriKind.Relative));
                play = true;
            }
          
            else
            {
                play = false;
                (sender as Image).Source = new BitmapImage(new Uri(@"../images/nn-play.png", UriKind.Relative));

            }

        }
    }
}
