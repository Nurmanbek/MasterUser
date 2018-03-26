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

namespace MyDesignForm
{
    public partial class EditForm : MetroForm
    {
        public string editid;
        public string editname;
        public string touser;
        public string onuser;
        public string editdate;
        public string editsumma;
        public int incomeid;

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            id.Text = this.editid;
            name.Text = this.editname;
            kimge.Text = this.touser;
            kimden.Text = this.onuser;
            dataa1.Text = this.editdate;
            summa.Text = this.editsumma;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
            string program_dir = Application.StartupPath;
            string DbConst = $"Data source={program_dir}\\testdb.db;Version=3;";

            using (var baglan = new SQLiteConnection(DbConst))
            {
                using (var query = new SQLiteCommand(baglan))
                {
                    query.CommandText = $"Update incomeUsers SET user={name.Text}, toUser={kimge.Text}, onUser={kimden.Text}, date={dataa1.Text}, summa={summa.Text}, incomeid={this.incomeid} where id={id.Text}";
                    try
                    {
                        query.Connection.Open();
                        query.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Connection error!!! : " + error);
                        this.Close();
                    }
                }
            }
        }
    }
}
