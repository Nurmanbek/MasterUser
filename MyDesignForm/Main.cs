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
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework.Animation;
using MetroFramework.Forms;
using System.Data.SQLite;

namespace MyDesignForm
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();  
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            string program_dir = Application.StartupPath;
            string sqlitedb_constr = $"Data source={program_dir}\\testdb.db;Version=3;";
            string[] btnDtext = new string[10];

            using (var baglan = new SQLiteConnection(sqlitedb_constr))
            {
                using (var query = new SQLiteCommand("SELECT * FROM income", baglan))
                {
                    try
                    {
                        int i = 0;
                        query.Connection.Open();
                        SQLiteDataReader dtr = query.ExecuteReader();
                        while (dtr.Read())
                        {
                            btnDtext[i] = dtr["title"].ToString();
                            i++;
                        }
                        btnD1.Text =" "+btnDtext[0];
                        btnD2.Text =" "+btnDtext[1];
                        btnD3.Text =" "+btnDtext[2];
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.PhoneBooks". При необходимости она может быть перемещена или удалена.

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Normal;
            TopMost = true;

            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            panel9.AutoScroll = false;
            panel9.VerticalScroll.Enabled = false;
            panel9.VerticalScroll.Visible = false;
            panel9.VerticalScroll.Maximum = 0;
            panel9.AutoScroll = true;

            panel11.AutoScroll = false;
            panel11.VerticalScroll.Enabled = false;
            panel11.VerticalScroll.Visible = false;
            panel11.VerticalScroll.Maximum = 0;
            panel11.AutoScroll = true;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 3)
            {
                panelRight.Width = 220;
                this.button67.Visible = false;
            }
            else
            {
                panelRight.Width = 3;
                this.button67.Visible = true;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == 220)
            {
                panelRight.Width = 3;
                this.button67.Visible = true;
            }
            else
            {
                this.button67.Visible = false;
                panelRight.Width = 220;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
