namespace OnlineStoreScrappper
{
    partial class frmMain
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restartAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.restartBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.restartSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoBuyToolStripMenuItem,
            this.toolStripSeparator1,
            this.restartAllToolStripMenuItem,
            this.stopAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.restartBuyToolStripMenuItem,
            this.stopBuyToolStripMenuItem,
            this.toolStripSeparator3,
            this.restartSearchToolStripMenuItem,
            this.stopSearchToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // autoBuyToolStripMenuItem
            // 
            this.autoBuyToolStripMenuItem.Name = "autoBuyToolStripMenuItem";
            this.autoBuyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.autoBuyToolStripMenuItem.Text = "Auto Buy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // restartAllToolStripMenuItem
            // 
            this.restartAllToolStripMenuItem.Name = "restartAllToolStripMenuItem";
            this.restartAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.restartAllToolStripMenuItem.Text = "Restart All";
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopAllToolStripMenuItem.Text = "Stop All";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // restartBuyToolStripMenuItem
            // 
            this.restartBuyToolStripMenuItem.Name = "restartBuyToolStripMenuItem";
            this.restartBuyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.restartBuyToolStripMenuItem.Text = "Restart Buy";
            // 
            // stopBuyToolStripMenuItem
            // 
            this.stopBuyToolStripMenuItem.Name = "stopBuyToolStripMenuItem";
            this.stopBuyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopBuyToolStripMenuItem.Text = "Stop Buy";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // restartSearchToolStripMenuItem
            // 
            this.restartSearchToolStripMenuItem.Name = "restartSearchToolStripMenuItem";
            this.restartSearchToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.restartSearchToolStripMenuItem.Text = "Restart Search";
            // 
            // stopSearchToolStripMenuItem
            // 
            this.stopSearchToolStripMenuItem.Name = "stopSearchToolStripMenuItem";
            this.stopSearchToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.stopSearchToolStripMenuItem.Text = "Stop Search";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtInterval);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(154, 55);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "minutes";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(73, 55);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interval";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(75, 19);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(154, 20);
            this.txtInterval.TabIndex = 0;
            this.txtInterval.Text = "1";
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "OnlineStore Scraper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restartAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem restartBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem restartSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterval;
    }
}

