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
            this.lb_instruction = new System.Windows.Forms.Label();
            this.bt_SEARCH = new System.Windows.Forms.Button();
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_OUT = new System.Windows.Forms.TextBox();
            this.lv_MAIN = new System.Windows.Forms.ListView();
            this.H_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_D = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.H_U = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_CLEAR = new System.Windows.Forms.Button();
            this.lb_NO_ENTRIES = new System.Windows.Forms.Label();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.mStrip.SuspendLayout();
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
            this.bt_SEARCH.Size = new System.Drawing.Size(126, 23);
            this.bt_SEARCH.TabIndex = 1;
            this.bt_SEARCH.Text = "Szukaj";
            this.bt_SEARCH.UseVisualStyleBackColor = true;
            this.bt_SEARCH.Click += new System.EventHandler(this.bt_serach_Click);
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ts_About});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(871, 24);
            this.mStrip.TabIndex = 6;
            this.mStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.wyczyśćToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz...";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.ts_Clear_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.ts_Close_Click);
            // 
            // ts_About
            // 
            this.ts_About.Name = "ts_About";
            this.ts_About.Size = new System.Drawing.Size(86, 20);
            this.ts_About.Text = "O Programie";
            this.ts_About.Click += new System.EventHandler(this.ts_About_Click);
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
            this.bt_CLEAR.Location = new System.Drawing.Point(667, 25);
            this.bt_CLEAR.Name = "bt_CLEAR";
            this.bt_CLEAR.Size = new System.Drawing.Size(205, 23);
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
            // sStrip
            // 
            this.sStrip.Location = new System.Drawing.Point(0, 336);
            this.sStrip.Name = "sStrip";
            this.sStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sStrip.Size = new System.Drawing.Size(871, 22);
            this.sStrip.SizingGrip = false;
            this.sStrip.TabIndex = 12;
            this.sStrip.Text = "statusStrip1";
            // 
            // sfDialog
            // 
            this.sfDialog.DefaultExt = "csv";
            this.sfDialog.FileName = "plik";
            this.sfDialog.Filter = "Excel CSV|*.csv";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 358);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.lb_NO_ENTRIES);
            this.Controls.Add(this.bt_CLEAR);
            this.Controls.Add(this.lv_MAIN);
            this.Controls.Add(this.tb_OUT);
            this.Controls.Add(this.bt_SEARCH);
            this.Controls.Add(this.lb_instruction);
            this.Controls.Add(this.tb_NIP);
            this.Controls.Add(this.mStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Firm data downloader";
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NIP;
        private System.Windows.Forms.Label lb_instruction;
        private System.Windows.Forms.Button bt_SEARCH;
        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.TextBox tb_OUT;
        private System.Windows.Forms.ListView lv_MAIN;
        public System.Windows.Forms.ColumnHeader H_Name;
        public System.Windows.Forms.ColumnHeader H_A;
        public System.Windows.Forms.ColumnHeader H_U;
        private System.Windows.Forms.ColumnHeader H_D;
        private System.Windows.Forms.Button bt_CLEAR;
        private System.Windows.Forms.Label lb_NO_ENTRIES;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_About;
    }
}

