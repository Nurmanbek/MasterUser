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
    public partial class EditForm : MetroForm
    {
        public string editid;
        public string editname1;
        public int status86;
        public string touser1;
        
        public string onuser1;

        public string editdate;
        public string editcategories;
        public string editsumma1;
        public int incomeid;

        public EditForm()
        {
            InitializeComponent();
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.BlueGrey900, Primary.Blue700, Accent.Orange400, TextShade.WHITE);

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
            id.Text = this.editid;
            name1.Text = this.editname1;
            
            kimge1.Text = this.touser1;
            
            kimden1.Text = this.onuser1;

            dataa1.Text = this.editdate;

            categories.Text = this.editcategories;

            summa1.Text = this.editsumma1;
            
        }

        private void EditForm_Paint(object sender, PaintEventArgs e)
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
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string dateValue = dataa1.Text;
            string program_dir = Application.StartupPath;
            string DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";

            using (var baglan = new SQLiteConnection(DbConst))
            {
                using (var query = new SQLiteCommand(baglan))
                {
                    if (this.status86 == 6060)
                        query.CommandText = "UPDATE incomeUsers SET user = :qName ,  toUser = :qKimge, onUser = :qKimden, date = :qDate, categories = :qCategories, summa = :qSumma where id = :qID";
                    else
                        query.CommandText = "UPDATE expenseUsers SET user = :qName ,  toUser = :qKimge, onUser = :qKimden, date = :qDate, categories = :qCategories, summa = :qSumma where id = :qID";
                    query.Parameters.Add("qName", DbType.String).Value = name1.Text;
                    query.Parameters.Add("qKimge", DbType.String).Value = kimge1.Text;
                    query.Parameters.Add("qKimden", DbType.String).Value = kimden1.Text;
                    query.Parameters.Add("qDate", DbType.String).Value = dateValue;
                    query.Parameters.Add("qSumma", DbType.Int32).Value = summa1.Text;
                    query.Parameters.Add("qCategories", DbType.String).Value = categories.Text;
                    query.Parameters.Add("qID", DbType.Int32).Value = id.Text;


                    try
                    {
                        query.Connection.Open();
                        query.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Маалымат толтурууда ката бар!");
                        this.Close();
                    }
                    this.editsumma1 = summa1.Text;
                    this.Close();
                }
            }
        }
    }
}
