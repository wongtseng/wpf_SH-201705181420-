using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace MyPlot
{
    public partial class UserControl1 : UserControl, INotifyPropertyChanged
    {

        private string mousepoint;
        private Thread thread;
        private Random random = new Random();
        private double[] bufData = new double[1024];
        const int yMax = 1500;//Y显示的最大值
        const int yMin = 0;//Y显示的最小值

        public event PropertyChangedEventHandler PropertyChanged;

        public UserControl1()
        {
            InitializeComponent();
            scope1.YAxis.Max.DataValue = yMax; //Y显示的最大值
            scope1.YAxis.Max.Value = yMax;//Y显示的最大值
            scope1.YAxis.Min.DataValue = yMin;
            scope1.YAxis.Min.Value = yMin;
            //scope1.YAxis.ZoomTo(-1500, 1500);//缩放到设定的位置

            thread = new Thread(new ThreadStart(SetData));//新建线程
            thread.IsBackground = true;//设置为后台线程
            scope1.Hold = false; //开启刷屏
            thread.Priority = ThreadPriority.Normal;//设置线程优先级

            //添加频谱线-最大值-绘制事件
            scope1.Channels[0].ChannelDraw += scope1_Channel0_ChannelDraw;

            //缩放后触发scope_ZoomChanged事件
            scope1.ZoomChanged += new Mitov.PlotLab.ZoomChangedEvent(scope_ZoomChanged);

            //添加频谱线点击事件
            this.scope1.Channels.Click += scope1_Channels_Click;


            thread.Start();

            for (int i = 0; i < scope1.Cursors.Count; i++)
            {
                scope1.Cursors[i].Channels.Clear();
                Mitov.PlotLab.DisplayCursorChannelLink AChannelLink = new Mitov.PlotLab.DisplayCursorChannelLink();
                AChannelLink.ChannelIndex = 0;
                scope1.Cursors[i].Channels.Add(AChannelLink);
            }
        }

        public string wpf_mousepoint
        {
            set { mousepoint = value; }
            get { return mousepoint; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region 生成模拟数据
        void SetData()
        {
            while (true)
            {
                for (int i = 0; i < bufData.Length; i++)
                {
                    bufData[i] = random.Next(-950, 950);
                }

                try
                {
                    scope1.Channels[0].Data.SetYData(bufData);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                Thread.Sleep(600);
            }
        }
        #endregion

        #region  频谱线绘制-最大最下值
        ///<summary>
        /// 频谱线绘制
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="args"></param>
        void scope1_Channel0_ChannelDraw(object sender, Mitov.PlotLab.ChannelDrawEventArgs args)
        {
            if (!args.WasChanged)
                return;
            scope1.Channels[0].DrawMarkers.Clear();//清除所有的标志
            Mitov.PlotLab.ScopeChannelMarker AMarker;//声明新标志
            double MaxValue = 900;//定义一个最大值为
            int MaxPosition = 0;//最大点（最大值的点）
            double MinValue = -900;//定义一个最小值为
            int MinPosition = 0;//最小点（最小值的点）
            for (int i = 0; i < args.DataSize; i++)
            {
                double value = args.ChannelData[i];
                if (MaxValue < value)
                {
                    MaxValue = value;
                    MaxPosition = i;
                }
                if (MinValue > value)
                {
                    MinValue = value;
                    MinPosition = i;
                }
                //如果大于则在该点标记一个图标
                if (value > 900)
                {
                    AMarker = new Mitov.PlotLab.ScopeChannelMarker();
                    AMarker.MarkerGroupIndex = 1;
                    AMarker.Position = i;
                    scope1.Channels[0].DrawMarkers.Add(AMarker);
                }
            }

            //最大值
            AMarker = new Mitov.PlotLab.ScopeChannelMarker();
            AMarker.MarkerGroupIndex = 0;
            AMarker.Position = MaxPosition;
            scope1.Channels[0].DrawMarkers.Add(AMarker);
            //最小值
            AMarker = new Mitov.PlotLab.ScopeChannelMarker();
            AMarker.MarkerGroupIndex = 2;
            AMarker.Position = MinPosition;
            scope1.Channels[0].DrawMarkers.Add(AMarker);

        }

        #endregion

        /// <summary>
        /// 限定只缩放Y值
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="Args"></param>
        void scope_ZoomChanged(object Sender, Mitov.PlotLab.ZoomChangedEventArgs Args)
        {
            scope1.Hold = false; //开启刷屏
            if (this.scope1.YAxis.Zooming.Max != 1150)
                this.scope1.YAxis.ZoomTo(-1150, 1150);//缩放到原来的位置
        }

        ///<summary>
        /// 频谱线点击时
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="args"></param>
        ///
        void scope1_Channels_Click(object sender, Mitov.PlotLab.ChannelClickEventArgs args)
        {
            wpf_mousepoint = (args.ClickedValue.X + scope1.XAxis.Min.Value).ToString("####.##")
            + "，" + (args.ClickedValue.Y + scope1.YAxis.Min.Value).ToString("####.##");
            this.OnPropertyChanged("wpf_mousepoint");
            //this.label1.Text += (args.ClickedValue.X * scope1.XAxis.MajorTicks.Step + scope1.XAxis.Min.Value).ToString("####.##")
            //+ "，" + (args.ClickedValue.Y * scope1.YAxis.MajorTicks.Step + scope1.YAxis.Min.Value).ToString("####.##");

        }



    }
}
