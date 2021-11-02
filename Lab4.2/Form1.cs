﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4._2
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
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, Color.White, Color.Blue,LinearGradientMode.Vertical);
            g.FillRectangle(brush, ClientRectangle);
        }
    }
}
