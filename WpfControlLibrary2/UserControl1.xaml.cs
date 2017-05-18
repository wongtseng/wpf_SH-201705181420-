using System;
using System.Windows.Controls;
using WpfApp_interface;

namespace WpfControlLibrary2
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl,IPluginMember
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string PluginName()
        {
            return "WpfPart4444444";
        }

        public int PluginId()
        {
            return GetHashCode();
        }

        public object InitPlugin()
        {
            return this;
        }

        public object InitPlugin(object[] paras)
        {
            return this;
        }

        public bool DisposePlugin()
        {
            throw new NotImplementedException();
        }
    }

}
