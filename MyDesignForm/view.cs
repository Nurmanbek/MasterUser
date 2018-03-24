using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;


namespace MyDesignForm
{
    public partial class view : MetroForm
    {
        public int btnNomer = 0;
        private string DbConst = null;

        public object Columns { get; private set; }

        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            // add columns to datatable
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Аты", typeof(string));
            table.Columns.Add("Кимге", typeof(string));
            table.Columns.Add("Кимден", typeof(string));
            table.Columns.Add("Дата", typeof(string));
            table.Columns.Add("Сумма", typeof(double));

            string program_dir = Application.StartupPath;
            DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";

            using (var baglan = new SQLiteConnection(DbConst))
            {
                using (var query = new SQLiteCommand("SELECT * FROM incomeUsers", baglan))
                {
                    try
                    {
                        int i = 0;
                        string[] btnDtext = new string[6];
                        query.Connection.Open();
                        SQLiteDataReader dtr = query.ExecuteReader();
                        while (dtr.Read())
                        {
                            i++;
                            btnDtext[0] = dtr["id"].ToString();
                            btnDtext[1] = dtr["user"].ToString();
                            btnDtext[2] = dtr["toUser"].ToString();
                            btnDtext[3] = dtr["onUser"].ToString();
                            btnDtext[4] = dtr["date"].ToString();
                            btnDtext[5] = dtr["summa"].ToString();
                            table.Rows.Add(i, btnDtext[0], btnDtext[1], btnDtext[2], btnDtext[3], btnDtext[4], btnDtext[5]);
                        }
                        metroGrid1.DataSource = table;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        }
        
        private void metroGrid1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
            this.Refresh();
        }
    }
    
}
