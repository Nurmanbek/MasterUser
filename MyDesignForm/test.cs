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
using System.Data.SQLite;
using MetroFramework.Animation;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Drawing.Drawing2D;

namespace MyDesignForm
{
    public partial class test : MetroForm
    {
        int panelWidth;
        bool Hidden;
        public test()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
        }
        

        private void test_Load(object sender, EventArgs e)
        {
            string program_dir = Application.StartupPath;
            string sqlitedb_constr = $"Data source={program_dir}\\testdb.db;Version=3;";
            string[,] btnDtext = new string[10, 2];

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
                            btnDtext[i, 0] = dtr["title"].ToString();
                            btnDtext[i, 1] = dtr["status"].ToString();
                            i++;
                        }
                        btn1.Text = " " + btnDtext[0, 0];
                        btn2.Text = " " + btnDtext[1, 0];
                        btn3.Text = " " + btnDtext[2, 0];
                        if (btnDtext[0, 1] == "0")
                            btn1.Enabled = false;
                        if (btnDtext[1, 1] == "0")
                            btn2.Enabled = false;
                        if (btnDtext[2, 1] == "0")
                            btn3.Enabled = false;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 22;
                if(PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 22;
                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                panel1.Width = 165;
            }
            else
            {
                panel1.Visible = false;
                panel1.Width = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            metroTabControl1.Invalidate();
        }
        
        private void materialRaisedButton5_Click_1(object sender, EventArgs e)
        {
            view v = new view();
            v.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Эу эмне басып жатасың!!!! * *");
        }
        

        private void yaj_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.ShowDialog();
        }

        private void ab_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.ShowDialog();
        }

        private void eb_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(20, 40, 102, 5));
        }
    }
}
