﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = lblName.Location.Y;

            lblName.Location = new Point(lblName.Location.X, y - 10);

            if(lblName.Location.Y<=panel2.Location.Y)
            {
                lblName.Location = new Point(lblName.Location.X, panel2.Location.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "SAS";
            timer1.Start();
        }
    }
}
