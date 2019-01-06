using System;
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
    public partial class instractions : Form
    {
        public instractions()
        {
            InitializeComponent();
        }
        private void instractions_Load(object sender, EventArgs e)
        {

        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide instractions
            var menu = new menu();// הגדרת menu
            menu.Show();//show menu
        }
    }
}
