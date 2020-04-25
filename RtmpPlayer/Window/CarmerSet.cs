using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RtmpPlayer.Until.XML_Until;
namespace RtmpPlayer.Window
{
    public partial class CarmerSet : Form
    {
        private string h_name = "";
        public CarmerSet(string hourseName)
        {
            h_name = hourseName; 
            InitializeComponent();

        }

        private void btn_true_Click(object sender, EventArgs e)
        {
            if(carmerName.Text.Trim() =="" || rtmpUrl.Text.Trim() == "")
            {
                MessageBox.Show("请输入摄像头名称或直播地址");
            }
            else
            {
                XmlDocumentUntil.addCamera(h_name, carmerName.Text.Trim(), rtmpUrl.Text.Trim());
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("添加成功");
                this.Close();
                
            }
        }

        private void CarmerSet_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2;
            this.StartPosition = FormStartPosition.Manual; //窗体的位置由Location属性决定
            this.Location = (Point)new Size(x, y);
        }
    }
}
