﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush mybrush = new SolidBrush(Color.DarkGreen);
            Pen mypen = new Pen(mybrush, 5);
            g.DrawRectangle(mypen, 10, 10, 200, 200);
            mypen.Dispose();
            mybrush.Dispose();






        }
    }
}
