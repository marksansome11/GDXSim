﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDXSim
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExponentialForm exponentialForm = new ExponentialForm();
            exponentialForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeometryForm geometryForm = new GeometryForm();
            geometryForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrigForm trigForm = new TrigForm();
            trigForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tutorials tutorials = new Tutorials();
            tutorials.Show();
            this.Hide();
        }
    }
}
