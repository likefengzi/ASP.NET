using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, new Rectangle(100,100,100,100));

            Pen pen = new Pen(Color.Blue,10.0f);
            g.DrawLines(pen, new Point[] { new Point(300, 100), new Point(500, 50),new Point(400,20), new Point(300, 100) });

        }
    }
}
