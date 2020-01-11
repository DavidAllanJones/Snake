namespace Snake2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szybkośćGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szybciejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wolniejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pole_gry = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauzaToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.szybkośćGryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauzaToolStripMenuItem
            // 
            this.pauzaToolStripMenuItem.Name = "pauzaToolStripMenuItem";
            this.pauzaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.pauzaToolStripMenuItem.Text = "Pauza";
            this.pauzaToolStripMenuItem.Click += new System.EventHandler(this.pauzaToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // szybkośćGryToolStripMenuItem
            // 
            this.szybkośćGryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szybciejToolStripMenuItem,
            this.wolniejToolStripMenuItem});
            this.szybkośćGryToolStripMenuItem.Name = "szybkośćGryToolStripMenuItem";
            this.szybkośćGryToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.szybkośćGryToolStripMenuItem.Text = "Szybkość Gry";
            // 
            // szybciejToolStripMenuItem
            // 
            this.szybciejToolStripMenuItem.Name = "szybciejToolStripMenuItem";
            this.szybciejToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.szybciejToolStripMenuItem.Text = "Szybciej";
            this.szybciejToolStripMenuItem.Click += new System.EventHandler(this.szybciejToolStripMenuItem_Click);
            // 
            // wolniejToolStripMenuItem
            // 
            this.wolniejToolStripMenuItem.Name = "wolniejToolStripMenuItem";
            this.wolniejToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.wolniejToolStripMenuItem.Text = "Wolniej";
            this.wolniejToolStripMenuItem.Click += new System.EventHandler(this.wolniejToolStripMenuItem_Click);
            // 
            // pole_gry
            // 
            this.pole_gry.BackColor = System.Drawing.SystemColors.Desktop;
            this.pole_gry.Location = new System.Drawing.Point(0, 50);
            this.pole_gry.Name = "pole_gry";
            this.pole_gry.Size = new System.Drawing.Size(280, 280);
            this.pole_gry.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.pole_gry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szybkośćGryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szybciejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wolniejToolStripMenuItem;
        private System.Windows.Forms.Panel pole_gry;
        private System.Windows.Forms.Timer timer1;
    }
}

