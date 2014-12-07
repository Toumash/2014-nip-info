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
            this.bt_SEARCH = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_OUT = new System.Windows.Forms.TextBox();
            this.lv_MAIN = new System.Windows.Forms.ListView();
            this.H_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_D = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_U = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_CLEAR = new System.Windows.Forms.Button();
            this.lb_NO_ENTRIES = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_NIP
            // 
            this.tb_NIP.Location = new System.Drawing.Point(85, 26);
            this.tb_NIP.Name = "tb_NIP";
            this.tb_NIP.Size = new System.Drawing.Size(270, 20);
            this.tb_NIP.TabIndex = 0;
            this.tb_NIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_NIP_KeyDown);
            // 
            // lb_instruction
            // 
            this.lb_instruction.AutoSize = true;
            this.lb_instruction.Location = new System.Drawing.Point(54, 30);
            this.lb_instruction.Name = "lb_instruction";
            this.lb_instruction.Size = new System.Drawing.Size(25, 13);
            this.lb_instruction.TabIndex = 3;
            this.lb_instruction.Text = "NIP";
            // 
            // bt_SEARCH
            // 
            this.bt_SEARCH.Location = new System.Drawing.Point(361, 24);
            this.bt_SEARCH.Name = "bt_SEARCH";
            this.bt_SEARCH.Size = new System.Drawing.Size(75, 23);
            this.bt_SEARCH.TabIndex = 1;
            this.bt_SEARCH.Text = "Szukaj";
            this.bt_SEARCH.UseVisualStyleBackColor = true;
            this.bt_SEARCH.Click += new System.EventHandler(this.bt_serach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
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
            // tb_OUT
            // 
            this.tb_OUT.Enabled = false;
            this.tb_OUT.Location = new System.Drawing.Point(12, 248);
            this.tb_OUT.Multiline = true;
            this.tb_OUT.Name = "tb_OUT";
            this.tb_OUT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_OUT.Size = new System.Drawing.Size(860, 83);
            this.tb_OUT.TabIndex = 8;
            // 
            // lv_MAIN
            // 
            this.lv_MAIN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.H_Name,
            this.H_D,
            this.H_A,
            this.H_U});
            this.lv_MAIN.FullRowSelect = true;
            this.lv_MAIN.Location = new System.Drawing.Point(12, 54);
            this.lv_MAIN.Name = "lv_MAIN";
            this.lv_MAIN.Size = new System.Drawing.Size(860, 188);
            this.lv_MAIN.TabIndex = 9;
            this.lv_MAIN.UseCompatibleStateImageBehavior = false;
            this.lv_MAIN.View = System.Windows.Forms.View.Details;
            this.lv_MAIN.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // H_Name
            // 
            this.H_Name.Text = "Nazwa";
            this.H_Name.Width = 255;
            // 
            // H_D
            // 
            this.H_D.Text = "Opis";
            this.H_D.Width = 327;
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
            // bt_CLEAR
            // 
            this.bt_CLEAR.Location = new System.Drawing.Point(711, 25);
            this.bt_CLEAR.Name = "bt_CLEAR";
            this.bt_CLEAR.Size = new System.Drawing.Size(161, 23);
            this.bt_CLEAR.TabIndex = 10;
            this.bt_CLEAR.Text = "Wyczyść";
            this.bt_CLEAR.UseVisualStyleBackColor = true;
            this.bt_CLEAR.Click += new System.EventHandler(this.bt_CLEAR_Click);
            // 
            // lb_NO_ENTRIES
            // 
            this.lb_NO_ENTRIES.AutoSize = true;
            this.lb_NO_ENTRIES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_NO_ENTRIES.ForeColor = System.Drawing.Color.Crimson;
            this.lb_NO_ENTRIES.Location = new System.Drawing.Point(493, 26);
            this.lb_NO_ENTRIES.Name = "lb_NO_ENTRIES";
            this.lb_NO_ENTRIES.Size = new System.Drawing.Size(139, 18);
            this.lb_NO_ENTRIES.TabIndex = 11;
            this.lb_NO_ENTRIES.Text = "BRAK WYNIKÓW";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 358);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lb_NO_ENTRIES);
            this.Controls.Add(this.bt_CLEAR);
            this.Controls.Add(this.lv_MAIN);
            this.Controls.Add(this.tb_OUT);
            this.Controls.Add(this.bt_SEARCH);
            this.Controls.Add(this.lb_instruction);
            this.Controls.Add(this.tb_NIP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button bt_SEARCH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_CloseApp;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
        private System.Windows.Forms.TextBox tb_OUT;
        private System.Windows.Forms.ListView lv_MAIN;
        public System.Windows.Forms.ColumnHeader H_Name;
        public System.Windows.Forms.ColumnHeader H_A;
        public System.Windows.Forms.ColumnHeader H_U;
        private System.Windows.Forms.ColumnHeader H_D;
        private System.Windows.Forms.Button bt_CLEAR;
        private System.Windows.Forms.Label lb_NO_ENTRIES;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

