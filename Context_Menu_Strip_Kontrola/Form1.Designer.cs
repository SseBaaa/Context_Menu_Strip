
namespace Context_Menu_Strip_Kontrola
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxlijevi = new System.Windows.Forms.TextBox();
            this.textBoxdesni = new System.Windows.Forms.TextBox();
            this.lijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoToolStripMenuItem,
            this.desnoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // textBoxlijevi
            // 
            this.textBoxlijevi.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxlijevi.Location = new System.Drawing.Point(154, 170);
            this.textBoxlijevi.Name = "textBoxlijevi";
            this.textBoxlijevi.Size = new System.Drawing.Size(100, 22);
            this.textBoxlijevi.TabIndex = 1;
            // 
            // textBoxdesni
            // 
            this.textBoxdesni.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxdesni.Location = new System.Drawing.Point(496, 170);
            this.textBoxdesni.Name = "textBoxdesni";
            this.textBoxdesni.Size = new System.Drawing.Size(100, 22);
            this.textBoxdesni.TabIndex = 2;
            // 
            // lijevoToolStripMenuItem
            // 
            this.lijevoToolStripMenuItem.Name = "lijevoToolStripMenuItem";
            this.lijevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lijevoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.lijevoToolStripMenuItem.Text = "Lijevo";
            this.lijevoToolStripMenuItem.Click += new System.EventHandler(this.lijevoToolStripMenuItem_Click);
            // 
            // desnoToolStripMenuItem
            // 
            this.desnoToolStripMenuItem.Name = "desnoToolStripMenuItem";
            this.desnoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.desnoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.desnoToolStripMenuItem.Text = "Desno";
            this.desnoToolStripMenuItem.Click += new System.EventHandler(this.desnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxdesni);
            this.Controls.Add(this.textBoxlijevi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxlijevi;
        private System.Windows.Forms.TextBox textBoxdesni;
    }
}

