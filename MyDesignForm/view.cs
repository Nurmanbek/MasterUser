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
using System.Data.SqlClient;

namespace MyDesignForm
{
    public partial class view : MetroForm
    {
        public int status86 = 0;
        public int btnNomer = 0;
        private int rowNom = 0;
        private int rowID = 0;
        public int maxRowID = 0;
        public string btnName = "Name";
        private string DbConst = null;
        private object row;

        public object Columns { get; private set; }

        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appData.PhoneBooks". При необходимости она может быть перемещена или удалена.
            //this.phoneBooksTableAdapter.Fill(this.appData.PhoneBooks);
            switch (Properties.Settings.Default.logintemp)
            {
                case "admin":
                    DeleteBtn.Enabled = true;
                    button2.Enabled = true;
                    break;
                case "user":
                    DeleteBtn.Enabled = true;
                    button2.Enabled = true;
                    break;
                case "gest":
                    DeleteBtn.Enabled = false;
                    button2.Enabled = false;
                    break;
                default:
                    DeleteBtn.Enabled = false;
                    button2.Enabled = false;
                    break;
            }

            if (this.status86 == 8080)
                this.Text = this.btnName + "  8080 ";
            else
                this.Text = this.btnName + "  6060 ";
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
            DbConst = $"Data source={program_dir}\\testdb.db;Version=3";
            
            using (var baglan = new SQLiteConnection(DbConst))
            {
                using (var query = new SQLiteCommand(baglan))
                {
                    if (this.status86 == 6060)
                        query.CommandText = $"SELECT * FROM incomeUsers where incomeid={this.btnNomer}";
                    else
                        query.CommandText = $"SELECT * FROM expenseUsers where expenseid={this.btnNomer}";

                    try
                    {
                        int i = 0;
                        int searchSummaValue = 0;
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
                            searchSummaValue += int.Parse(dtr["summa"].ToString());
                            table.Rows.Add(i, btnDtext[0], btnDtext[1], btnDtext[2], btnDtext[3], btnDtext[4], btnDtext[5]);
                        }
                        bunifuGrid1.DataSource = table;
                        sumlbl.Text = searchSummaValue.ToString();
                        searchSumma.Text = searchSummaValue.ToString();
                        searchSummaValue = 0;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        }

        private void fillGridView()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.maxRowID = 0;
            AddForm ef = new AddForm();
            ef.incomeid = this.btnNomer;
            if (this.status86 == 6060)
                ef.status86 = 6060;
            else
                ef.status86 = 8080;
            ef.ShowDialog();
            if (ef.status)
            {
                this.Obnovit();
                int selectIndex = bunifuGrid1.CurrentCell.RowIndex;
                if (maxRowID > 0 && selectIndex >= 0)
                {
                    bunifuGrid1.Rows[0].Selected = false;
                    bunifuGrid1.Rows[this.maxRowID].Selected = true;
                }
            }
        }


        private void bunifuGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Properties.Settings.Default.logintemp == "gest" || Properties.Settings.Default.logintemp == "none")
            {
                MessageBox.Show("Уруксатыңыз жок!");
                return;
            }
            EditForm ef = new EditForm();
            if (this.status86 == 6060)
                ef.status86 = 6060;
            else
                ef.status86 = 8080;
            int indexRow = e.RowIndex; // get the selected Row Index
            if (indexRow >= 0)
            {
                ef.editid = this.bunifuGrid1.Rows[indexRow].Cells[1].Value.ToString();
                ef.editname1 = this.bunifuGrid1.Rows[indexRow].Cells[2].Value.ToString();
                ef.touser1 = this.bunifuGrid1.Rows[indexRow].Cells[3].Value.ToString();
                ef.onuser1 = this.bunifuGrid1.Rows[indexRow].Cells[4].Value.ToString();
                ef.editdate = this.bunifuGrid1.Rows[indexRow].Cells[5].Value.ToString();
                ef.editsumma1 = this.bunifuGrid1.Rows[indexRow].Cells[6].Value.ToString();
                ef.incomeid = this.btnNomer;
                ef.ShowDialog();
                this.Obnovit();
                //bunifuGrid1.SelectedRows.Clear();
                bunifuGrid1.Rows[0].Selected = false;
                bunifuGrid1.Rows[indexRow].Selected = true;
                //MessageBox.Show(ef.editsumma);
            }
            //MessageBox.Show("Oglum ne yaptin, oldurdun yaa?! :))");
        }

        private void Obnovit()
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
                using (var query = new SQLiteCommand(baglan))
                {
                    if (this.status86 == 6060)
                        query.CommandText = $"SELECT * FROM incomeUsers where incomeid={this.btnNomer}";
                    else
                        query.CommandText = $"SELECT * FROM expenseUsers where expenseid={this.btnNomer}";

                    try
                    {
                        int i = 0;
                        int searchSummaValue = 0;
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
                            searchSummaValue += int.Parse(dtr["summa"].ToString());
                            table.Rows.Add(i, btnDtext[0], btnDtext[1], btnDtext[2], btnDtext[3], btnDtext[4], btnDtext[5]);
                        }
                        bunifuGrid1.DataSource = table;
                        sumlbl.Text = searchSummaValue.ToString();
                        searchSummaValue = 0;
                        this.maxRowID = i-1;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            int qID = bunifuGrid1.CurrentCell.RowIndex;
            int deleteID = Int32.Parse(bunifuGrid1.Rows[qID].Cells[1].Value.ToString());
            string program_dir = Application.StartupPath;
            string DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";
            result = MessageBox.Show("Өчүрүлгөн маалымат кайтарылбайт! " + deleteID, "Өчүрүү", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && deleteID!=0)
            {
                using (var baglan = new SQLiteConnection(DbConst))
                {
                    using (var query = new SQLiteCommand(baglan))
                    {
                        if(this.status86 == 6060)
                            query.CommandText = "DELETE from incomeUsers where id = :qID";
                        else
                            query.CommandText = "DELETE from expenseUsers where id = :qID";
                        query.Parameters.Add("qID", DbType.Int32).Value = deleteID;

                        try
                        {
                            query.Connection.Open();
                            query.ExecuteNonQuery();
                            MessageBox.Show("Ийгиликтуу очурулду!");
                            this.Obnovit();
                            if (qID != 0)
                            {
                                bunifuGrid1.Rows[0].Selected = false;
                                bunifuGrid1.Rows[qID - 1].Selected = true;
                            }             
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("Очурууго маалымат тандалган жок! ");
                        }
                    }
                  
                }
            }
        }

        private void bunifuGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.rowNom = Convert.ToInt32(bunifuGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.rowID = Convert.ToInt32(bunifuGrid1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            int selectedIndex = tandoo1.SelectedIndex;
            searchData(bunifuTextbox1.Text.ToString(), selectedIndex);

        }

        public void searchData(string valueToFind, int selectedItem)
        {
            if(selectedItem<0)
            {
                MessageBox.Show("Издөө тизмегин тандаңыз!");
                return ;
            }
            string program_dir = Application.StartupPath;
            string DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";
            DataTable table = new DataTable();
            // add columns to datatable
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Аты", typeof(string));
            table.Columns.Add("Кимге", typeof(string));
            table.Columns.Add("Кимден", typeof(string));
            table.Columns.Add("Дата", typeof(string));
            table.Columns.Add("Сумма", typeof(double));

            using (var baglan = new SQLiteConnection(DbConst))
            {
                SQLiteCommand query;
                query = new SQLiteCommand(baglan);
         
                try
                {
                    switch (selectedItem)
                    {
                        case 0:
                            {
                                valueToFind = bunifuTextbox1.text;
                                if(this.status86 == 6060)
                                    query.CommandText = "SELECT * FROM incomeUsers WHERE incomeUsers.incomeid = :qID AND incomeUsers.user LIKE '%" + valueToFind + "%'" ;
                                else
                                    query.CommandText = "SELECT * FROM expenseUsers WHERE expenseUser.expenseid = :qID AND expenseUsers.user LIKE '%" + valueToFind + "%'";
                                query.Parameters.Add("qID", DbType.Int32).Value = this.btnNomer;
                                query.Parameters.Add("searchText", DbType.String).Value = valueToFind;                     
                                break;
                            }
                        case 1:
                            {
                                valueToFind = bunifuTextbox1.text;
                                if (this.status86 == 6060)
                                    query.CommandText = "SELECT * FROM incomeUsers WHERE incomeUsers.incomeid = :qID AND incomeUsers.toUser LIKE '%" + valueToFind + "%'";
                                else
                                    query.CommandText = "SELECT * FROM expenseUsers WHERE expenseUsers.expenseid = :qID AND expenseUsers.toUser LIKE '%" + valueToFind + "%'";

                                query.Parameters.Add("qID", DbType.Int32).Value = this.btnNomer;
                                query.Parameters.Add("searchText", DbType.String).Value = valueToFind;
                                break;
                            }
                        case 2:
                            {
                                valueToFind = bunifuTextbox1.text;
                                if(this.status86 == 6060)
                                    query.CommandText = "SELECT * FROM incomeUsers WHERE incomeUsers.incomeid = :qID AND incomeUsers.onUser LIKE '%" + valueToFind + "%'";
                                else
                                    query.CommandText = "SELECT * FROM expenseUsers WHERE expenseUsers.expenseid = :qID AND expenseUsers.onUser LIKE '%" + valueToFind + "%'";
                                query.Parameters.Add("qID", DbType.Int32).Value = this.btnNomer;
                                query.Parameters.Add("searchText", DbType.String).Value = valueToFind;
                                break;
                            }
                        default:
                            {
                                valueToFind = bunifuTextbox1.text;
                                if (this.status86 == 6060)
                                    query.CommandText = "SELECT * FROM incomeUsers WHERE incomeUsers.incomeid = :qID AND incomeUsers.user LIKE '%" + valueToFind + "%'";
                                else
                                    query.CommandText = "SELECT * FROM expenseUsers WHERE expenseUser.expenseid = :qID AND expenseUsers.user LIKE '%" + valueToFind + "%'";
                                query.Parameters.Add("qID", DbType.Int32).Value = this.btnNomer;
                                query.Parameters.Add("searchText", DbType.String).Value = valueToFind;
                                break;
                            }
                    }
                    int i = 0;
                    double searchSummaValue = 0;
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
                        searchSummaValue += int.Parse(dtr["summa"].ToString());
                        table.Rows.Add(i, btnDtext[0], btnDtext[1], btnDtext[2], btnDtext[3], btnDtext[4], btnDtext[5]);
                    }
                    bunifuGrid1.DataSource = table;
                    this.maxRowID = i - 1;
                    searchName.Text = valueToFind;
                    searchSumma.Text = searchSummaValue.ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Connection error!!! : " + error);
                    this.Close();
                }               
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();
            pr.Title = "Кардарлар тууралуу билдирүү"; //Header
            pr.SubTitle = string.Format("Дата: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pr.PageNumbers = true;
            pr.PageNumberInHeader = false;
            pr.PorportionalColumns = true;
            pr.HeaderCellAlignment = StringAlignment.Near;
            pr.Footer = "Үйрөнүү";
            pr.FooterSpacing = 15;
            pr.PrintDataGridView(bunifuGrid1);
        }

        private void btnok_Click(object sender, EventArgs e)
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
                using (var query = new SQLiteCommand(baglan))
                {
                    if (this.status86 == 6060)
                        query.CommandText = "SELECT * FROM incomeUsers where (date BETWEEN  :sDate and :fDate) and incomeid=:dID";
                    else
                        query.CommandText = "SELECT * FROM expenseUsers where expenseid=:dID and ( date BETWEEN  :sDate and :fDate)";
                    query.Parameters.Add("sDate", DbType.String).Value = datestart.Text;
                    query.Parameters.Add("fDate", DbType.String).Value = datefinish.Text;
                    query.Parameters.Add("dID", DbType.Int32).Value = this.btnNomer;
                    try
                    {
                        int i = 0;
                        int searchSummaValue = 0;
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
                            searchSummaValue += int.Parse(dtr["summa"].ToString());
                            table.Rows.Add(i, btnDtext[0], btnDtext[1], btnDtext[2], btnDtext[3], btnDtext[4], btnDtext[5]);
                        }
                        bunifuGrid1.DataSource = table;
                        searchSumma.Text = searchSummaValue.ToString();
                        searchSummaValue = 0;
                        this.maxRowID = i - 1;

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        
    }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.Obnovit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
