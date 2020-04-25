using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using RtmpPlayer.Until.XML_Until;
using Microsoft.VisualBasic;
using System.Threading;
using System.Runtime.InteropServices;

namespace RtmpPlayer.Window
{
    public partial class PlayerFrm : Form
    {
        private List<VLCLib.UPlayer> uPlayers=new List<VLCLib.UPlayer>();
        private List<System.Windows.Forms.Panel> videoPanels=new List<Panel>();
        private List<Carmer.Carmer> cameraList=new List<Carmer.Carmer>();
        private int channels = 6;
        private int screen = 0;
        private string title = "";
        IList<Rectangle> rectangles;

        System.Timers.Timer t;

        public PlayerFrm()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            initConfig();
            InitializeComponent();


            t = new System.Timers.Timer(10000);//实例化timer类，设置间隔时间为10000毫秒；
            t.Elapsed += new System.Timers.ElapsedEventHandler(GetTimeLong);//到达时间的时候执行事件；
            t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
            t.Enabled = true;//是否执行system.timers.timer.elapsed事件；
            t.Start(); //启动定时器
                       //上面初始化代码可以写到构造函数中

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            //重新计算整体面板大小，调整每个监控画面的内容
            reDrawPanels();
        }
        private void PlayerFrm_Closed(object sender, EventArgs e)
        {
            disposeAllPlayer();
        }

        private void disposeAllPlayer() {
            foreach (VLCLib.UPlayer player in uPlayers)
            {

                player.Stop();
                player.Dispose();
            }
        }

        private void PlayerFrm_Load(object sender, EventArgs e)
        {
            this.titleLable.Text = this.title;
            showOnMonitor(this.screen);
            

        }
        private void showOnMonitor(int showOnMonitor)
        {
            if (showOnMonitor == 0)
            {
                //reDrawPanels(); 
                return; 
            }
            Screen[] sc;
            sc = Screen.AllScreens;
            if (showOnMonitor >= sc.Length)
            {
                MessageBox.Show("显示器只有"+sc.Length+"个,是否重新设置显示的显示器？或调试分屏显示？", "分配配置提示", MessageBoxButtons.OKCancel);
                //showOnMonitor = 0;
            }
            else
            {

                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(sc[showOnMonitor].Bounds.Left, sc[showOnMonitor].Bounds.Top);
                // If you intend the form to be maximized, change it to normal then maximized.  
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void initConfig()
        {
            List<Carmer.Carmer> list = new List<Carmer.Carmer>();
            if (XmlDocumentUntil.configXml == null)
            {
                XmlDocumentUntil.configXml = new XmlDocument();
            }
            XmlDocumentUntil.configXml.Load("device.xml");
            //初始化所有的配置信息
            //1、标题配置
            title = XmlDocumentUntil.configXml.GetElementsByTagName("title")[0].InnerText;
            //2、通道数
            channels = int.Parse(XmlDocumentUntil.configXml.GetElementsByTagName("channels")[0].InnerText);
            //3、显示在哪个屏幕
            screen = int.Parse(XmlDocumentUntil.configXml.GetElementsByTagName("screen")[0].InnerText);
            cameraList = XmlDocumentUntil.getAllList();
        }



        /// <summary>
        /// 动态创建面板
        /// </summary>
        /// <param name="xy">Panel的XY坐标</param>
        /// <param name="wh">Panel的大小</param>
        private Panel CreatePanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            //panel.BackColor = System.Drawing.Color.Transparent;
            //panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Location = rectangle.Location;
            //panel.Name = string.Concat("pVideo");
            panel.BackgroundImageLayout = ImageLayout.Center;
            panel.Size = rectangle.Size;
            //panel.TabIndex = 0;
            panel.BackColor = Color.Black;
            return panel;
        }
        

        private void reDrawPanels() {
            disposeAllPlayer();
            uPlayers.Clear();
            this.main_panel.Controls.Clear();
            videoPanels.Clear();
            /*IList<Rectangle> rectangles = new IList<Rectangle>();*/
            if (channels == 1) {
                Rectangle rectangle = new Rectangle();
                rectangle.Size = this.main_panel.Size;
                rectangle.Location = new Point(0);

                Panel panel = CreatePanel(rectangle);
                
                videoPanels.Add(panel);
                panel.MouseDoubleClick += msDoubleClick;
                if ( cameraList.Count>0)
                {
                    VLCLib.UPlayer player = new VLCLib.UPlayer();
                    player.Play(cameraList[0].CarmerUrl, panel.Handle);
                    player.Name = "0";
                    player.Enabled = false;
                    panel.Controls.Add(player);
                    uPlayers.Add(player);

                }
                this.main_panel.Controls.Add(panel);
                return;
            }

            //计算面板坐标
            rectangles = CalcPanelRectangle(this.channels,this.main_panel.Size);

            //创建面板
            for (int i = 0; i < this.channels; i++)
            {
                Panel panel = CreatePanel(rectangles[i]);
                videoPanels.Add(panel);
                this.main_panel.Controls.Add(panel);
                panel.Name = "videoPanel" + i;
                panel.MouseDoubleClick += msDoubleClick;
                if (i < cameraList.Count)
                {
                    
                    VLCLib.UPlayer player = new VLCLib.UPlayer();
                    if (player.Inited)
                    {
                        player.Init();
                    }

                    player.Play(cameraList[i].CarmerUrl, panel.Handle);
                    player.Name =  i.ToString()+"&"+i;
                    

                    System.Windows.Forms.Panel panelDoubleClick = new System.Windows.Forms.Panel();
                    panelDoubleClick.Dock = DockStyle.Fill;
                    panelDoubleClick.BackColor = Color.Transparent;
                    panelDoubleClick.MouseDoubleClick += msDoubleClick;
                    panel.Controls.Add(player);
                    panel.Controls.Clear();
                    panel.Controls.Add(panelDoubleClick);
                    panelDoubleClick.BringToFront();

                    uPlayers.Add(player);
                }
                //playIndex = i;


            }

           
        }

        int playIndex=0;


        public void GetTimeLong(object source, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < uPlayers.Count; i++)
            {
                VLCLib.UPlayer player = (VLCLib.UPlayer)uPlayers[i];
                Console.WriteLine(i + "播放时长为："  + player.vlcPlayer.GetPlayTime());

                if (player.vlcPlayer.GetPlayTime() == 0)
                {
                    rePlay(i);
                    Thread.Sleep(1000); 
                }
            }
            
        }

        void rePlay(int i)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { rePlay(i); }));
                return;
            }
            VLCLib.UPlayer player = (VLCLib.UPlayer)uPlayers[i];
            player.Stop();
            player.Dispose();


            string playerName = player.Name;
            int crameraIndex = int.Parse(playerName.Split('&')[0]);
            int panelIndex = int.Parse(playerName.Split('&')[1]);

            this.main_panel.Controls.Remove(videoPanels[panelIndex]); 

            Panel panel = CreatePanel(rectangles[panelIndex]);
            string reUrl = cameraList[crameraIndex].CarmerUrl;
            panel.Name = "videoPanel" + i;
            //panel.BackColor = Color.Red;
            panel.MouseDoubleClick += msDoubleClick;

            this.main_panel.Controls.Add(panel);
            VLCLib.UPlayer playerNew = new VLCLib.UPlayer();
            panel.Controls.Add(playerNew);
            playerNew.Play(reUrl, panel.Handle);
            playerNew.Name = playerName;


            System.Windows.Forms.Panel panelDoubleClick = new System.Windows.Forms.Panel();
            panelDoubleClick.Dock = DockStyle.Fill;
            panelDoubleClick.BackColor = Color.Transparent;
            panelDoubleClick.MouseDoubleClick += msDoubleClick;
            panel.Controls.Clear();
            panel.Controls.Add(panelDoubleClick);
            panelDoubleClick.BringToFront();


            uPlayers[i] = playerNew;
            videoPanels[panelIndex] = panel;


            
        }


        Size beforeSize;
        Boolean isFull=false;
        private void msDoubleClick(object sender, MouseEventArgs e)
        {
            
            Control control= (Control)sender;
            /*if (!isFull)
            {
                control.FullScreen(true);
             isFull = true;
            }
            else
            {
                control.FullScreen(false);
                isFull = false;
            }*/
            //object oj= control.Parent.Parent;
            control = control.Parent;
            if (!isFull)
            {
                beforeSize = control.ClientSize;
                Rectangle ret = Screen.GetWorkingArea(this);
                control.ClientSize =  new Size(ret.Width, ret.Height);
                //control.ClientSize = this.main_panel.Size;
                control.Dock = DockStyle.Fill;
                control.BringToFront();
              /*  control.Parent.ClientSize = new Size(ret.Width, ret.Height);
                control.Parent.Dock = DockStyle.Fill;
                control.Parent.BringToFront();*/
                isFull = true;
            }
            else
            {
                control.ClientSize = beforeSize;
                control.Dock = DockStyle.None;
                isFull = false;
            }

        }


        /// 计算视频面板位置和面积
        /// </summary>
        /// <param name="channelCount"></param>
        /// <param name="TotalSquare">总面积和坐标</param>
        /// <returns></returns>
        private IList<Rectangle> CalcPanelRectangle(int channelCount, Size TotalArea)
        {
            IList<Rectangle> result = new List<Rectangle>();

            //模数
            int modulo;
            if (channelCount <= 4)
                modulo = 2;
            else if (channelCount > 64)
                modulo = 8;
            else
                modulo = (int)Math.Ceiling(Math.Sqrt(channelCount));         //平方根

            int width, height;

            //单个画面大小
            width = (TotalArea.Width - modulo * 1) / modulo;
            height = (TotalArea.Height - modulo * 1) / modulo;

            for (int i = 0; i < channelCount; i++)
            {
                Rectangle rect = new Rectangle();
                rect.Width = width;
                rect.Height = height;
                if (i % modulo == 0)
                {
                    rect.X = 1;
                    if (i == 0)
                        rect.Y = 1;
                    else
                        rect.Y = result[i - modulo].Y + height + 1;
                }
                else
                {
                    rect.X = result[i - 1].X + width + 1;
                    rect.Y = result[i - 1].Y;
                }
                result.Add(rect);
            }
            return result;
        }


        private void getCramerList()
        {
            cameraList = XmlDocumentUntil.getAllList();

        }


        private void PlayerFrm_Shown(object sender, EventArgs e)
        {
            
        }

        public void reFresh()
        {
            /*this.Controls.Clear();
            disposeAllPlayer(); */
            reDrawPanels();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (channels != 1)
            {
                setChannels(1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出监控系统吗?", "退出系统？", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                this.Close();
            }
        }

        private void setChannels(int channels) {
            if (this.channels != channels)
            {
                this.channels = channels;
                if (XmlDocumentUntil.configXml == null)
                {
                    XmlDocumentUntil.configXml = new XmlDocument();
                }
                XmlDocumentUntil.configXml.Load("device.xml");
                //初始化所有的配置信息
                //2、通道数
                XmlDocumentUntil.configXml.GetElementsByTagName("channels")[0].InnerText = channels.ToString();
                XmlDocumentUntil.configXml.Save("device.xml");

                reDrawPanels();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
                setChannels(4);
        }

        private void label2_Click(object sender, EventArgs e)
        {
                setChannels(9);
        }

        /// <summary>
        /// 添加摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form form = new CarmerSet("添加通道");
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                reFresh();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            string inputBox = Interaction.InputBox("请输入轮播时间", "轮播时间", "", 100, 100);
            
            MessageBox.Show(inputBox, "轮播时间",MessageBoxButtons.OKCancel);
            
        }



        [DllImport("kernel32.dll")]
        public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

        public void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }



    }


}

