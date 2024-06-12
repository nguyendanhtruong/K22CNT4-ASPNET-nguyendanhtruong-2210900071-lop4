namespace onktra01
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcKhoaToolStripMenuItem,
            this.danhMụcSinhViênToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMụcToolStripMenuItem.Text = "danh mục";
            // 
            // danhMụcKhoaToolStripMenuItem
            // 
            this.danhMụcKhoaToolStripMenuItem.Name = "danhMụcKhoaToolStripMenuItem";
            this.danhMụcKhoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhMụcKhoaToolStripMenuItem.Text = "danh mục khoa";
            // 
            // danhMụcSinhViênToolStripMenuItem
            // 
            this.danhMụcSinhViênToolStripMenuItem.Name = "danhMụcSinhViênToolStripMenuItem";
            this.danhMụcSinhViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhMụcSinhViênToolStripMenuItem.Text = "danh mục sinh viên";
            this.danhMụcSinhViênToolStripMenuItem.Click += new System.EventHandler(this.danhMụcSinhViênToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSinhViênToolStripMenuItem;
    }
}

