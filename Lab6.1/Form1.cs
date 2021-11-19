using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "*文件(*.*)|*.*|bmp文件(*.bmp)|*.bmp|jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowHelp = true;
            openFileDialog1.Title = "打开图片";
            openFileDialog1.FileName = "示例图片";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName.ToString());
                bitmap = new Bitmap(bitmap, 160, 160 * bitmap.Height / bitmap.Width);
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "*文件(*.*)|*.*|bmp文件(*.bmp)|*.bmp|jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowHelp = true;
            openFileDialog1.Title = "打开图片";
            openFileDialog1.FileName = "示例图片";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Graphics g = this.CreateGraphics();
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName.ToString());
                g.DrawImage(bitmap, new Rectangle(100,100,160, 160 * bitmap.Height / bitmap.Width));
            }
        }
    }
}
