using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.VisualBasic;

namespace MyDesignForm
{
    public partial class setting : MetroForm  
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            user1.Text = Properties.Settings.Default.Admin;
            user2.Text = Properties.Settings.Default.User;
            user3.Text = Properties.Settings.Default.Gest;
            pass1.Text = Properties.Settings.Default.AdminPassword;
            pass2.Text = Properties.Settings.Default.UserPassword;
            pass3.Text = Properties.Settings.Default.GestPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Enter editing password!", "Chainge password", "", -1, -1);
            Properties.Settings.Default.AdminPassword = str;
            Properties.Settings.Default.Save();
            pass1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Enter editing password!", "Chainge password", "", -1, -1);
            Properties.Settings.Default.UserPassword = str;
            Properties.Settings.Default.Save();
            pass2.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Enter editing password!", "Chainge password", "", -1, -1);
            Properties.Settings.Default.GestPassword = str;
            Properties.Settings.Default.Save();
            pass3.Text = str;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
