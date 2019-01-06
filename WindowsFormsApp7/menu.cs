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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide menu
            var game = new game();// הגדרת game
            game.Show();//show game
        }

        private void InstractionsBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide menu
            var instractions = new instractions();// הגדרת instractions
            instractions.Show();//show instractions
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide menu
            var about = new about();// הגדרת about
            about.Show();//show about

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide menu
            var settings = new settings();// הגדרת settings
            settings.Show();//show settings
        }
    }
}
