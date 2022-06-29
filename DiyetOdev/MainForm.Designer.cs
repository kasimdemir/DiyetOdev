
namespace DiyetOdev
{
    partial class MainForm
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
            this.tspOgunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.vGünlükÖzetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspOgunEkle,
            this.vGünlükÖzetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspOgunEkle
            // 
            this.tspOgunEkle.Name = "tspOgunEkle";
            this.tspOgunEkle.Size = new System.Drawing.Size(90, 24);
            this.tspOgunEkle.Text = "Öğün Ekle";
            this.tspOgunEkle.Click += new System.EventHandler(this.tspOgunEkle_Click);
            // 
            // vGünlükÖzetToolStripMenuItem
            // 
            this.vGünlükÖzetToolStripMenuItem.Name = "vGünlükÖzetToolStripMenuItem";
            this.vGünlükÖzetToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.vGünlükÖzetToolStripMenuItem.Text = "Günlük Özet";
            this.vGünlükÖzetToolStripMenuItem.Click += new System.EventHandler(this.vGünlükÖzetToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspOgunEkle;
        private System.Windows.Forms.ToolStripMenuItem vGünlükÖzetToolStripMenuItem;
    }
}