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
        public string permision;
        public long summa6060;
        public long summa8080;
        public long summa6080;

        public test()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
        }
        

        private void test_Load(object sender, EventArgs e)
        {
            //this.bunifuFlatButton1.Normalcolor = Color.Purple;
            //this.bunifuFlatButton1.OnHovercolor = Color.Red;

            //this.bunifuFlatButton1.colbackground = Color.Blue;
            //this.bunifuFlatButton1.colhover = Color.Red;
            //this.bunifuFlatButton1.colselected = Color.Red;
            //this.bunifuFlatButton1.Activecolor = Color.Yellow;
            //this.bunifuFlatButton1.Iconcolor = Color.Violet;


            timerNow.Start();

            string program_dir = Application.StartupPath;
            string sqlitedb_constr = $"Data source={program_dir}\\testdb.db;Version=3;";
            string[,] btnDtext = new string[20, 2];
            //6060
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
                        hbtn1.Text = " " + btnDtext[0, 0];
                        hbtn2.Text = " " + btnDtext[1, 0];
                        hbtn3.Text = " " + btnDtext[2, 0];
                        hbtn4.Text = " " + btnDtext[3, 0];
                        hbtn5.Text = " " + btnDtext[4, 0];
                        hbtn6.Text = " " + btnDtext[5, 0];
                        hbtn7.Text = " " + btnDtext[6, 0];
                        hbtn8.Text = " " + btnDtext[7, 0];
                        hbtn9.Text = " " + btnDtext[8, 0];
                        hbtn10.Text = " " + btnDtext[9, 0];
                        hbtn11.Text = " " + btnDtext[10, 0];
                        hbtn12.Text = " " + btnDtext[11, 0];
                        hbtn13.Text = " " + btnDtext[12, 0];
                        if (btnDtext[0, 1] == "0")
                            hbtn1.Enabled = false;
                        if (btnDtext[1, 1] == "0")
                            hbtn2.Enabled = false;
                        if (btnDtext[2, 1] == "0")
                            hbtn3.Enabled = false;
                        if (btnDtext[3, 1] == "0")
                            hbtn4.Enabled = false;
                        if (btnDtext[4, 1] == "0")
                            hbtn5.Enabled = false;
                        if (btnDtext[5, 1] == "0")
                            hbtn6.Enabled = false;
                        if (btnDtext[6, 1] == "0")
                            hbtn7.Enabled = false;
                        if (btnDtext[7, 1] == "0")
                            hbtn8.Enabled = false;
                        if (btnDtext[8, 1] == "0")
                            hbtn9.Enabled = false;
                        if (btnDtext[9, 1] == "0")
                            hbtn10.Enabled = false;
                        if (btnDtext[10, 1] == "0")
                            hbtn11.Enabled = false;
                        if (btnDtext[11, 1] == "0")
                            hbtn12.Enabled = false;
                        if (btnDtext[12, 1] == "0")
                            hbtn13.Enabled = false;

                        // get sum 6060
                        query.Connection.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                    query.Connection.Close();

                    using (var query1 = new SQLiteCommand("SELECT SUM(summa) FROM incomeUsers", baglan))
                    {
                        try
                        {
                            query1.Connection.Open();
                            //SQLiteDataReader dtr = query1.ExecuteReader();
                            //dtr = query1.ExecuteReader();
                           // dtr.Read();
                            summa6060 = (long)query1.ExecuteScalar();
                            lbl6060.Text = summa6060.ToString();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Connection error!!! : " + error);
                            this.Close();
                        }
                        query1.Connection.Close();
                    }

                }
                //8080
                using (var query = new SQLiteCommand("SELECT * FROM expense", baglan))
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
                        bbtn1.Text = " " + btnDtext[0, 0];
                        bbtn2.Text = " " + btnDtext[1, 0];
                        bbtn3.Text = " " + btnDtext[2, 0];
                        bbtn4.Text = " " + btnDtext[3, 0];
                        bbtn5.Text = " " + btnDtext[4, 0];
                        bbtn6.Text = " " + btnDtext[5, 0];
                        bbtn7.Text = " " + btnDtext[6, 0];
                        bbtn8.Text = " " + btnDtext[7, 0];
                        bbtn9.Text = " " + btnDtext[8, 0];
                        bbtn10.Text = " " + btnDtext[9, 0];
                        bbtn11.Text = " " + btnDtext[10, 0];
                        bbtn12.Text = " " + btnDtext[11, 0];
                        bbtn13.Text = " " + btnDtext[12, 0];
                        //bbtn14.Text = " " + btnDtext[13, 0];
                        //bbtn15.Text = " " + btnDtext[14, 0];
                        if (btnDtext[0, 1] == "0")
                            bbtn1.Enabled = false;
                        if (btnDtext[1, 1] == "0")
                            bbtn2.Enabled = false;
                        if (btnDtext[2, 1] == "0")
                            bbtn3.Enabled = false;
                        if (btnDtext[3, 1] == "0")
                            bbtn4.Enabled = false;
                        if (btnDtext[4, 1] == "0")
                            bbtn5.Enabled = false;
                        if (btnDtext[5, 1] == "0")
                            bbtn6.Enabled = false;
                        if (btnDtext[6, 1] == "0")
                            bbtn7.Enabled = false;
                        if (btnDtext[7, 1] == "0")
                            bbtn8.Enabled = false;
                        if (btnDtext[8, 1] == "0")
                            bbtn9.Enabled = false;
                        if (btnDtext[9, 1] == "0")
                            bbtn10.Enabled = false;
                        if (btnDtext[10, 1] == "0")
                            bbtn11.Enabled = false;
                        if (btnDtext[11, 1] == "0")
                            bbtn12.Enabled = false;
                        if (btnDtext[12, 1] == "0")
                            bbtn13.Enabled = false;
                        //if (btnDtext[13, 1] == "0")
                        //    bbtn14.Enabled = false;
                        //if (btnDtext[14, 1] == "0")
                        //    bbtn15.Enabled = false;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                    query.Connection.Close();
                    using (var query1 = new SQLiteCommand("SELECT SUM(summa) FROM expenseUsers", baglan))
                    {
                        try
                        {
                            query1.Connection.Open();
                            //SQLiteDataReader dtr = query1.ExecuteReader();
                            //dtr = query1.ExecuteReader();
                            // dtr.Read();
                            summa8080 = (long)query1.ExecuteScalar();
                            label8080.Text = summa8080.ToString();
                            summa6080 = summa8080 - summa6060;
                            lbl8060.Text = summa6080.ToString();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Connection error!!! : " + error);
                            this.Close();
                        }
                        query1.Connection.Close();
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

        private void hbtn1_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnName = hbtn1.Text;
            v.btnNomer = 1;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn2_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnName = hbtn2.Text;
            v.btnNomer = 2;
            v.ShowDialog();
            this.test_Load(sender, e);

        }

        private void hbtn3_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 3;
            v.btnName = hbtn3.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn4_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 4;
            v.btnName = hbtn4.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn5_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 5;
            v.btnName = hbtn5.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn6_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 6;
            v.btnName = hbtn6.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn7_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 7;
            v.btnName = hbtn7.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn8_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 8;
            v.btnName = hbtn8.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn9_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 9;
            v.btnName = hbtn9.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn10_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 10;
            v.btnName = hbtn10.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn11_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 11;
            v.btnName = hbtn11.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn12_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 12;
            v.btnName = hbtn12.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void hbtn13_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 6060;
            v.btnNomer = 13;
            v.btnName = hbtn13.Text;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn1_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn1.Text;
            v.btnNomer = 1;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            //bor.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void bbtn2_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn2.Text;
            v.btnNomer = 2;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn3_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 3;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn4_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 4;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn5_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 5;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn6_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 6;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn7_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 7;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn8_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 8;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn9_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 9;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn10_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 10;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn11_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 11;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn12_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 12;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn13_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 13;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn14_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 14;
            v.ShowDialog();
            this.test_Load(sender, e);
        }

        private void bbtn15_Click(object sender, EventArgs e)
        {
            view v = new view();
            v.status86 = 8080;
            v.btnName = bbtn3.Text;
            v.btnNomer = 15;
            v.ShowDialog();
            this.Refresh();
            this.test_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(bunifuCards1, false, null);
            bunifuCards1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuCards1.Visible = false;
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            tab2.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblYear.Text = DateTime.Now.ToString("dd mm yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void lblYear_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
                panel8.Visible = true;
            else
                panel8.Visible = false;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
                panel8.Visible = true;
            else
                panel8.Visible = false;
        }

        private void lblDay_Click(object sender, EventArgs e)
        {
            if (panel8.Visible == false)
                panel8.Visible = true;
            else
                panel8.Visible = false;
        }

        private void tab1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tab_Paint(object sender, PaintEventArgs e)
        {
            //bar.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            
        }

    }
}
