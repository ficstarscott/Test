﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Application
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void comboBoxWebsite_SelectedValueChanged(object sender, EventArgs e)
        {
            string badString = "Hello";
            badString += " World";
            MessageBox.Show(badString);
        }
    }
}
