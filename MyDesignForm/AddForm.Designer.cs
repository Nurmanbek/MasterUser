namespace MyDesignForm
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.dataa1 = new MetroFramework.Controls.MetroDateTime();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.addbtn = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.summa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kimden = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kimge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.addbtn_elips = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataa1
            // 
            this.dataa1.DisplayFocus = true;
            this.dataa1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataa1.Location = new System.Drawing.Point(34, 191);
            this.dataa1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataa1.Name = "dataa1";
            this.dataa1.Size = new System.Drawing.Size(183, 29);
            this.dataa1.TabIndex = 2;
            this.dataa1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // addbtn
            // 
            this.addbtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.addbtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.addbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addbtn.Location = new System.Drawing.Point(83, 287);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(97, 30);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "САКТОО";
            this.addbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addbtn.UseSelectable = true;
            this.addbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.summa);
            this.panel2.Controls.Add(this.addbtn);
            this.panel2.Controls.Add(this.kimden);
            this.panel2.Controls.Add(this.kimge);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.dataa1);
            this.panel2.Location = new System.Drawing.Point(-1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 341);
            this.panel2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(30, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Дата";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(30, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Сумма";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(30, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Кимден";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(30, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Кимге";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Аты";
            // 
            // summa
            // 
            this.summa.Depth = 0;
            this.summa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.summa.Hint = "";
            this.summa.Location = new System.Drawing.Point(34, 242);
            this.summa.MouseState = MaterialSkin.MouseState.HOVER;
            this.summa.Name = "summa";
            this.summa.PasswordChar = '\0';
            this.summa.SelectedText = "";
            this.summa.SelectionLength = 0;
            this.summa.SelectionStart = 0;
            this.summa.Size = new System.Drawing.Size(181, 23);
            this.summa.TabIndex = 3;
            this.summa.UseSystemPasswordChar = false;
            // 
            // kimden
            // 
            this.kimden.Depth = 0;
            this.kimden.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.kimden.Hint = "";
            this.kimden.Location = new System.Drawing.Point(34, 137);
            this.kimden.MouseState = MaterialSkin.MouseState.HOVER;
            this.kimden.Name = "kimden";
            this.kimden.PasswordChar = '\0';
            this.kimden.SelectedText = "";
            this.kimden.SelectionLength = 0;
            this.kimden.SelectionStart = 0;
            this.kimden.Size = new System.Drawing.Size(181, 23);
            this.kimden.TabIndex = 2;
            this.kimden.UseSystemPasswordChar = false;
            // 
            // kimge
            // 
            this.kimge.Depth = 0;
            this.kimge.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.kimge.Hint = "";
            this.kimge.Location = new System.Drawing.Point(36, 88);
            this.kimge.MouseState = MaterialSkin.MouseState.HOVER;
            this.kimge.Name = "kimge";
            this.kimge.PasswordChar = '\0';
            this.kimge.SelectedText = "";
            this.kimge.SelectionLength = 0;
            this.kimge.SelectionStart = 0;
            this.kimge.Size = new System.Drawing.Size(181, 23);
            this.kimge.TabIndex = 1;
            this.kimge.UseSystemPasswordChar = false;
            // 
            // name
            // 
            this.name.Depth = 0;
            this.name.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.name.Hint = "";
            this.name.Location = new System.Drawing.Point(36, 39);
            this.name.MouseState = MaterialSkin.MouseState.HOVER;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(181, 23);
            this.name.TabIndex = 0;
            this.name.UseSystemPasswordChar = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // addbtn_elips
            // 
            this.addbtn_elips.ElipseRadius = 4;
            this.addbtn_elips.TargetControl = this.addbtn;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(-1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 56);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(254, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddForm_Paint);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dataa1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MetroFramework.Controls.MetroButton addbtn;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField summa;
        private MaterialSkin.Controls.MaterialSingleLineTextField kimden;
        private MaterialSkin.Controls.MaterialSingleLineTextField kimge;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse addbtn_elips;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}