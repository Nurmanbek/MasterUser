﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using Bunifu.Framework.UI;
using MaterialSkin.Controls;

namespace MyDesignForm
{
    public partial class example : Form
    {
        public example()
        {
            InitializeComponent();
        }

        private void example_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
