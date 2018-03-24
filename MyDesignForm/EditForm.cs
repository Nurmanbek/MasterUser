using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using System.Drawing.Drawing2D;

namespace MyDesignForm
{
    public partial class EditForm : MetroForm
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditForm_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath objGP = new System.Drawing.Drawing2D.GraphicsPath();
            objGP.AddEllipse(new Rectangle(5, 5, this.Width, this.Height));
            this.Region = new Region(objGP);
            this.FormBorderStyle = FormBorderStyle.None;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, 300, 300));
            Region = new Region(path);
        }
    }
}
