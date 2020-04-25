using System;
using System.Windows.Forms;
using RtmpPlayer.Window;
using RtmpPlayer.Until.XML_Until;
using System.Drawing;

namespace RtmpPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void playBtn_Click(object sender, EventArgs e)
        {
            string url = this.urlTextbox.Text;
            if(url=="" || url == null)
            {
                MessageBox.Show("请输入房间名称");
            }
            else
            {
                this.Hide();
                CarmerSet frm = new CarmerSet(url);
                frm.ShowDialog();
            }
        }

        private void scanLocalVideoBtn_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog dlg=new OpenFileDialog()
            {
                Filter = "视频|*.mp4;*.wmv;*.rmvb;*.avi;*.mkv;*.flv"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
                this.urlTextbox.Text = dlg.FileName;
                */
            this.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (XmlDocumentUntil.checkXML())
            {
                this.Hide();
                PlayerFrm frm = new PlayerFrm();
                frm.ShowDialog();
            }
            else
            {
                int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
                int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
                this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
                this.Location = (Point)new Size(x, y);  
            }
        }
    }
}
