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
            this.SetClientSizeCore(500, 600);
            Graphics g = e.Graphics;
            System.Drawing.Drawing2D.HatchBrush brush;
            int x = 20;
            int y = 20;
            foreach (System.Drawing.Drawing2D.HatchStyle brushStyle in Enum.GetValues(typeof(System.Drawing.Drawing2D.HatchStyle)))
            {
                brush = new System.Drawing.Drawing2D.HatchBrush(brushStyle, Color.Navy, Color.Yellow);
                g.FillRectangle(brush, x, y, 40, 20);
                y += 30;
                if ((y + 30) > this.ClientSize.Height)
                {
                    y = 20;
                    x += 150;


                }

            }
            g.Dispose();



        }
    }
}
