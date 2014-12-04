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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_NIP = new System.Windows.Forms.TextBox();
            this.lb_instruction = new System.Windows.Forms.Label();
            this.bt_serach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.H_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_D = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_U = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NIP
            // 
            this.tb_NIP.Location = new System.Drawing.Point(106, 27);
            this.tb_NIP.Name = "tb_NIP";
            this.tb_NIP.Size = new System.Drawing.Size(270, 20);
            this.tb_NIP.TabIndex = 0;
            this.tb_NIP.Text = "np:80808080";
            // 
            // lb_instruction
            // 
            this.lb_instruction.AutoSize = true;
            this.lb_instruction.Location = new System.Drawing.Point(12, 31);
            this.lb_instruction.Name = "lb_instruction";
            this.lb_instruction.Size = new System.Drawing.Size(88, 13);
            this.lb_instruction.TabIndex = 3;
            this.lb_instruction.Text = "Nip/Nazwa Firmy";
            // 
            // bt_serach
            // 
            this.bt_serach.Location = new System.Drawing.Point(382, 25);
            this.bt_serach.Name = "bt_serach";
            this.bt_serach.Size = new System.Drawing.Size(75, 23);
            this.bt_serach.TabIndex = 4;
            this.bt_serach.Text = "Szukaj";
            this.bt_serach.UseVisualStyleBackColor = true;
            this.bt_serach.Click += new System.EventHandler(this.bt_serach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
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
            // ts_About
            // 
            this.ts_About.Name = "ts_About";
            this.ts_About.Size = new System.Drawing.Size(141, 22);
            this.ts_About.Text = "O programie";
            this.ts_About.Click += new System.EventHandler(this.ts_About_Click);
            // 
            // ts_CloseApp
            // 
            this.ts_CloseApp.Name = "ts_CloseApp";
            this.ts_CloseApp.Size = new System.Drawing.Size(141, 22);
            this.ts_CloseApp.Text = "Zamknij";
            this.ts_CloseApp.Click += new System.EventHandler(this.ts_CloseApp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(860, 83);
            this.textBox1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.H_Name,
            this.H_D,
            this.H_A,
            this.H_U});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(860, 188);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // H_Name
            // 
            this.H_Name.Text = "Nazwa";
            this.H_Name.Width = 248;
            // 
            // H_D
            // 
            this.H_D.Text = "Opis";
            this.H_D.Width = 237;
            // 
            // H_A
            // 
            this.H_A.Text = "Adres";
            this.H_A.Width = 208;
            // 
            // H_U
            // 
            this.H_U.Text = "Url";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 341);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_serach);
            this.Controls.Add(this.lb_instruction);
            this.Controls.Add(this.tb_NIP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Firm data downloader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NIP;
        private System.Windows.Forms.Label lb_instruction;
        private System.Windows.Forms.Button bt_serach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_CloseApp;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader H_Name;
        public System.Windows.Forms.ColumnHeader H_A;
        public System.Windows.Forms.ColumnHeader H_U;
        private System.Windows.Forms.ColumnHeader H_D;
    }
}

