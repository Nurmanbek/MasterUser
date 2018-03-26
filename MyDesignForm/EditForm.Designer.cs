namespace MyDesignForm
{
    partial class EditForm
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
            this.dataa1 = new MetroFramework.Controls.MetroDateTime();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.editbtn = new MetroFramework.Controls.MetroButton();
            this.id = new System.Windows.Forms.Label();
            this.summa = new MetroFramework.Controls.MetroTextBox();
            this.kimden = new MetroFramework.Controls.MetroTextBox();
            this.kimge = new MetroFramework.Controls.MetroTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataa1
            // 
            this.dataa1.DisplayFocus = true;
            this.dataa1.Location = new System.Drawing.Point(55, 149);
            this.dataa1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dataa1.Name = "dataa1";
            this.dataa1.Size = new System.Drawing.Size(166, 29);
            this.dataa1.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.name.BackColor = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.DisplayIcon = true;
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(55, 43);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PromptText = "Name";
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(166, 23);
            this.name.TabIndex = 4;
            this.name.Tag = "Суммасы";
            this.name.UseSelectable = true;
            this.name.WaterMark = "Name";
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // editbtn
            // 
            this.editbtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.editbtn.Location = new System.Drawing.Point(94, 236);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(90, 25);
            this.editbtn.TabIndex = 5;
            this.editbtn.Text = "Өзгөртүү";
            this.editbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.editbtn.UseSelectable = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(90, 5);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(102, 35);
            this.id.TabIndex = 9;
            this.id.Text = "111111111";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // summa
            // 
            // 
            // 
            // 
            this.summa.CustomButton.Image = null;
            this.summa.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.summa.CustomButton.Name = "";
            this.summa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.summa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.summa.CustomButton.TabIndex = 1;
            this.summa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.summa.CustomButton.UseSelectable = true;
            this.summa.CustomButton.Visible = false;
            this.summa.DisplayIcon = true;
            this.summa.Lines = new string[0];
            this.summa.Location = new System.Drawing.Point(55, 193);
            this.summa.MaxLength = 32767;
            this.summa.Name = "summa";
            this.summa.PasswordChar = '\0';
            this.summa.PromptText = "Summa";
            this.summa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.summa.SelectedText = "";
            this.summa.SelectionLength = 0;
            this.summa.SelectionStart = 0;
            this.summa.ShortcutsEnabled = true;
            this.summa.Size = new System.Drawing.Size(166, 23);
            this.summa.TabIndex = 8;
            this.summa.Tag = "Суммасы";
            this.summa.UseSelectable = true;
            this.summa.WaterMark = "Summa";
            this.summa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.summa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kimden
            // 
            // 
            // 
            // 
            this.kimden.CustomButton.Image = null;
            this.kimden.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.kimden.CustomButton.Name = "";
            this.kimden.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kimden.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kimden.CustomButton.TabIndex = 1;
            this.kimden.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kimden.CustomButton.UseSelectable = true;
            this.kimden.CustomButton.Visible = false;
            this.kimden.DisplayIcon = true;
            this.kimden.Lines = new string[0];
            this.kimden.Location = new System.Drawing.Point(55, 114);
            this.kimden.MaxLength = 32767;
            this.kimden.Name = "kimden";
            this.kimden.PasswordChar = '\0';
            this.kimden.PromptText = "Kimden";
            this.kimden.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kimden.SelectedText = "";
            this.kimden.SelectionLength = 0;
            this.kimden.SelectionStart = 0;
            this.kimden.ShortcutsEnabled = true;
            this.kimden.Size = new System.Drawing.Size(166, 23);
            this.kimden.TabIndex = 7;
            this.kimden.Tag = "Суммасы";
            this.kimden.UseSelectable = true;
            this.kimden.WaterMark = "Kimden";
            this.kimden.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kimden.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // kimge
            // 
            // 
            // 
            // 
            this.kimge.CustomButton.Image = null;
            this.kimge.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.kimge.CustomButton.Name = "";
            this.kimge.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kimge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kimge.CustomButton.TabIndex = 1;
            this.kimge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kimge.CustomButton.UseSelectable = true;
            this.kimge.CustomButton.Visible = false;
            this.kimge.DisplayIcon = true;
            this.kimge.Lines = new string[0];
            this.kimge.Location = new System.Drawing.Point(55, 79);
            this.kimge.MaxLength = 32767;
            this.kimge.Name = "kimge";
            this.kimge.PasswordChar = '\0';
            this.kimge.PromptText = "Kimge";
            this.kimge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kimge.SelectedText = "";
            this.kimge.SelectionLength = 0;
            this.kimge.SelectionStart = 0;
            this.kimge.ShortcutsEnabled = true;
            this.kimge.Size = new System.Drawing.Size(166, 23);
            this.kimge.TabIndex = 6;
            this.kimge.Tag = "Суммасы";
            this.kimge.UseSelectable = true;
            this.kimge.WaterMark = "Kimge";
            this.kimge.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kimge.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(0, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 29);
            this.panel6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ө з г ө р т ү ү";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.editbtn);
            this.panel7.Controls.Add(this.id);
            this.panel7.Controls.Add(this.name);
            this.panel7.Controls.Add(this.summa);
            this.panel7.Controls.Add(this.kimge);
            this.panel7.Controls.Add(this.kimden);
            this.panel7.Controls.Add(this.dataa1);
            this.panel7.Location = new System.Drawing.Point(0, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 285);
            this.panel7.TabIndex = 8;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(268, 344);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(268, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(268, 344);
            this.Name = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditForm_Paint);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dataa1;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroButton editbtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroTextBox summa;
        private MetroFramework.Controls.MetroTextBox kimden;
        private MetroFramework.Controls.MetroTextBox kimge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id;
    }
}