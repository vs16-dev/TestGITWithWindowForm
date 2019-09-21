﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGITWithWindowForm
{
    public partial class Form1 : Form
    {
        TestUserControl testUserControl = null;
        public Form1()
        {
            InitializeComponent();
            testUserControl = new TestUserControl();
            testUserControl.Dock = DockStyle.Top;
            this.Controls.Add(testUserControl);
        }
    }
}
