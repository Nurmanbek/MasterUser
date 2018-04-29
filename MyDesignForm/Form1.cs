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
using MaterialSkin;
using MaterialSkin.Controls;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using Bunifu.Framework.Lib;
using MetroFramework.Controls;
using MetroFramework.Animation;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using System.Threading;

namespace MyDesignForm
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            Thread t = new Thread(new ThreadStart(load));
            t.Start();

            InitializeComponent();
            for (int i = 0; i < 200; i++)
                Thread.Sleep(10);
            t.Abort();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Yellow100, Primary.Blue700, Accent.Orange400, TextShade.BLACK);
            txtPassword.ForeColor = Color.White;
            txtUsername.ForeColor = Color.White;
            txtUsername.BackColor = Color.FromArgb(26, 65, 79);
            txtPassword.BackColor = Color.FromArgb(26, 65, 79);
            
        }

        void load()
        {
            Dialog d = new Dialog();
            Application.Run(d);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Properties.Settings.Default.Admin && txtPassword.Text == Properties.Settings.Default.AdminPassword)
            {
                this.Hide();
                timer1.Start();
                test t = new test();
                t.permision = "admin";
                Properties.Settings.Default.logintemp = "admin";
                Properties.Settings.Default.Save();
                t.ShowDialog();
            }
            else if (txtUsername.Text == Properties.Settings.Default.User && txtPassword.Text == Properties.Settings.Default.UserPassword)
            {
                this.Hide();
                timer1.Start();
                test t = new test();
                t.permision = "user";
                Properties.Settings.Default.logintemp = "user";
                Properties.Settings.Default.Save();
                t.ShowDialog();
            }
            else if(txtUsername.Text == Properties.Settings.Default.Gest && txtPassword.Text == Properties.Settings.Default.GestPassword)
            {
                this.Hide();
                timer1.Start();
                test t = new test();                
                t.permision = "gest";
                Properties.Settings.Default.logintemp = "gest";
                Properties.Settings.Default.Save();
                t.ShowDialog();
            }
            else
            {
                Properties.Settings.Default.logintemp = "none";
                Properties.Settings.Default.Save();
                MessageBox.Show("Колдонуучунун АТЫ же СЫР СӨЗҮ туура эмес!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            string nomer;

            nomer = Interaction.InputBox("Сыр сөзүңүздү жазыңыз!", "Code", "", -1, -1);
            if(nomer == "2636")
            {
                setting st = new setting();
                st.Show();
            }
            else
            {
                MessageBox.Show("Код туура эмес!");
            }
        }
      
        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = materialCheckBox1.Checked ? '\0' : '*';
        }
    }
}
