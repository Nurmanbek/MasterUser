using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesignForm.Control
{
    public partial class Controller : UserControl
    {
        public Controller()
        {
            InitializeComponent();
        }

        public Image MyProperty
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string txtName
        {
            get { return labelName.Text; }
            set { labelName.Text = value; }
        }
        private void Controller_Load(object sender, EventArgs e)
        {

        }
    }
}
