﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide about
            var menu = new menu();// הגדרת menu
            menu.Show();//show menu
        }

        private void about_Load(object sender, EventArgs e)
        {

        }
    }
}
