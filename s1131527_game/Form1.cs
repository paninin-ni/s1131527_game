using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1131527_game
{
    public partial class Form1 : Form
    {
        PictureBox[] pic = new PictureBox[4];
        public Form1()
        {
            InitializeComponent();
            InitializePoker();
        }
        private void InitializePoker()
        {
            // 動態產生4張牌
            for (int i = 0; i < 4; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Image = GetImage("back");
                pic[i].Name = "pic" + i;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                // 將 pic 丟至到 groupBox1 內
                this.groupBox1.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }
        private Image GetImage(string name)
        {
            return Properties.Resources.ResourceManager
            .GetObject(name) as Image;
        }
        private void pic_Click(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            MessageBox.Show("你選擇了" + pic.Name);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
