using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using System.Drawing.Drawing2D;
using System.Data.SQLite;
using System.Drawing;
using MaterialSkin;

namespace MyDesignForm
{
    public partial class AddForm : MetroForm
    {
        public string editid;
        public int status86;
        public string editname;
        public string touser;
        public string onuser;
        public string editdate;
        public string editsumma;
        public int incomeid;
        public bool status = false;

        public AddForm()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.BlueGrey900, Primary.Blue700, Accent.Orange400, TextShade.WHITE);

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath objGP = new System.Drawing.Drawing2D.GraphicsPath();
            objGP.AddEllipse(new Rectangle(5, 5, this.Width, this.Height));
            this.Region = new Region(objGP);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, 300, 300));
            Region = new Region(path);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string program_dir = Application.StartupPath;
            string DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";

            using (var baglan = new SQLiteConnection(DbConst))
            {
                using (var query = new SQLiteCommand(baglan))
                {
                    if(this.status86 == 6060)
                        query.CommandText = "INSERT into incomeUsers(user, toUser, onUser, date, summa, incomeid) VALUES (:qName, :qKimge, :qKimden, :qDate, :qSumma, :qID )";
                    else
                        query.CommandText = "INSERT into expenseUsers(user, toUser, onUser, date, summa, expenseid) VALUES (:qName, :qKimge, :qKimden, :qDate, :qSumma, :qID )";
                    query.Parameters.Add("qName", DbType.String).Value = name.Text;
                    query.Parameters.Add("qKimge", DbType.String).Value = kimge.Text;
                    query.Parameters.Add("qKimden", DbType.String).Value = kimden.Text;
                    query.Parameters.Add("qDate", DbType.String).Value = dataa1.Text;
                    query.Parameters.Add("qSumma", DbType.Int32).Value = summa.Text;
                    query.Parameters.Add("qID", DbType.Int32).Value = this.incomeid;

                    try
                    {
                        query.Connection.Open();
                        query.ExecuteNonQuery();
                        this.editsumma = summa.Text;
                        this.status = true;
                        this.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Маалымат толтурууда ката бар!");
                        this.Close();
                    }
                    
                }
            }
        }

        private void AddForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
