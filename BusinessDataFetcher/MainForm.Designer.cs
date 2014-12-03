namespace BusinessDataFetcher
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
            this.tb_NIP = new System.Windows.Forms.TextBox();
            this.wb_MAIN = new System.Windows.Forms.WebBrowser();
            this.lb_instruction = new System.Windows.Forms.Label();
            this.bt_serach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NIP
            // 
            this.tb_NIP.Location = new System.Drawing.Point(75, 47);
            this.tb_NIP.Name = "tb_NIP";
            this.tb_NIP.Size = new System.Drawing.Size(270, 20);
            this.tb_NIP.TabIndex = 0;
            this.tb_NIP.Text = "np:80808080";
            // 
            // wb_MAIN
            // 
            this.wb_MAIN.Location = new System.Drawing.Point(12, 124);
            this.wb_MAIN.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_MAIN.Name = "wb_MAIN";
            this.wb_MAIN.Size = new System.Drawing.Size(298, 312);
            this.wb_MAIN.TabIndex = 1;
            // 
            // lb_instruction
            // 
            this.lb_instruction.AutoSize = true;
            this.lb_instruction.Location = new System.Drawing.Point(72, 31);
            this.lb_instruction.Name = "lb_instruction";
            this.lb_instruction.Size = new System.Drawing.Size(195, 13);
            this.lb_instruction.TabIndex = 3;
            this.lb_instruction.Text = "Wprowadz NIP firmy, ktora mam szukac";
            // 
            // bt_serach
            // 
            this.bt_serach.Location = new System.Drawing.Point(352, 43);
            this.bt_serach.Name = "bt_serach";
            this.bt_serach.Size = new System.Drawing.Size(75, 23);
            this.bt_serach.TabIndex = 4;
            this.bt_serach.Text = "DWNLD";
            this.bt_serach.UseVisualStyleBackColor = true;
            this.bt_serach.Click += new System.EventHandler(this.bt_serach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_About,
            this.ts_CloseApp});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.oProgramieToolStripMenuItem.Text = "Program";
            // 
            // ts_CloseApp
            // 
            this.ts_CloseApp.Name = "ts_CloseApp";
            this.ts_CloseApp.Size = new System.Drawing.Size(152, 22);
            this.ts_CloseApp.Text = "Zamknij";
            this.ts_CloseApp.Click += new System.EventHandler(this.ts_CloseApp_Click);
            // 
            // ts_About
            // 
            this.ts_About.Name = "ts_About";
            this.ts_About.Size = new System.Drawing.Size(152, 22);
            this.ts_About.Text = "O programie";
            this.ts_About.Click += new System.EventHandler(this.ts_About_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 463);
            this.Controls.Add(this.bt_serach);
            this.Controls.Add(this.lb_instruction);
            this.Controls.Add(this.wb_MAIN);
            this.Controls.Add(this.tb_NIP);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NIP;
        private System.Windows.Forms.WebBrowser wb_MAIN;
        private System.Windows.Forms.Label lb_instruction;
        private System.Windows.Forms.Button bt_serach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_CloseApp;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
    }
}

