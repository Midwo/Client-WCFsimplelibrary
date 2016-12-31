namespace klient_do_WCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeHistoryToolStripMenuItem,
            this.dateReturnToolStripMenuItem,
            this.sendOrderToolStripMenuItem,
            this.readTextToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // welcomeHistoryToolStripMenuItem
            // 
            this.welcomeHistoryToolStripMenuItem.Name = "welcomeHistoryToolStripMenuItem";
            this.welcomeHistoryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.welcomeHistoryToolStripMenuItem.Text = "Welcome History";
            this.welcomeHistoryToolStripMenuItem.Click += new System.EventHandler(this.welcomeHistoryToolStripMenuItem_Click);
            // 
            // dateReturnToolStripMenuItem
            // 
            this.dateReturnToolStripMenuItem.Name = "dateReturnToolStripMenuItem";
            this.dateReturnToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.dateReturnToolStripMenuItem.Text = "Date Return";
            this.dateReturnToolStripMenuItem.Click += new System.EventHandler(this.dateReturnToolStripMenuItem_Click);
            // 
            // sendOrderToolStripMenuItem
            // 
            this.sendOrderToolStripMenuItem.Name = "sendOrderToolStripMenuItem";
            this.sendOrderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sendOrderToolStripMenuItem.Text = "Send  Order";
            // 
            // readTextToolStripMenuItem
            // 
            this.readTextToolStripMenuItem.Name = "readTextToolStripMenuItem";
            this.readTextToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.readTextToolStripMenuItem.Text = "Read Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to test client MD WCFsimpleLibrary";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 117);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 139);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MD client to WCFsimplelibrary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readTextToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

