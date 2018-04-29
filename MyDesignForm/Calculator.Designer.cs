namespace MyDesignForm
{
    partial class Calculator
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
            this.first = new System.Windows.Forms.RichTextBox();
            this.second = new System.Windows.Forms.RichTextBox();
            this.progress = new System.Windows.Forms.Panel();
            this.select = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(10, 14);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(118, 28);
            this.first.TabIndex = 15;
            this.first.Text = "";
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(206, 14);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(118, 28);
            this.second.TabIndex = 16;
            this.second.Text = "";
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.DimGray;
            this.progress.Location = new System.Drawing.Point(57, 55);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(220, 28);
            this.progress.TabIndex = 17;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.Transparent;
            this.select.BorderRadius = 3;
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select.ForeColor = System.Drawing.Color.White;
            this.select.Items = new string[] {
        "+",
        "-",
        "*",
        "/"};
            this.select.Location = new System.Drawing.Point(135, 14);
            this.select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.select.Name = "select";
            this.select.NomalColor = System.Drawing.Color.Silver;
            this.select.onHoverColor = System.Drawing.Color.Silver;
            this.select.selectedIndex = 0;
            this.select.Size = new System.Drawing.Size(64, 28);
            this.select.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.select);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.first);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 105);
            this.panel1.TabIndex = 18;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 185);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox first;
        private System.Windows.Forms.RichTextBox second;
        private System.Windows.Forms.Panel progress;
        private Bunifu.Framework.UI.BunifuDropdown select;
        private System.Windows.Forms.Panel panel1;
    }
}