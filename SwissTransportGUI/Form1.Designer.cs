namespace SwissTransportGUI
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpConnectionSearchTime = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.Lv_Connections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Cb_ConnectionTo = new System.Windows.Forms.ComboBox();
            this.Lbl_ConnectionTo = new System.Windows.Forms.Label();
            this.Lbl_ConnectionFrom = new System.Windows.Forms.Label();
            this.Cb_ConnectionFrom = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Lbl_Uhr = new System.Windows.Forms.Label();
            this.Tmr_Uhr = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connections";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 77);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 546);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Lv_Connections);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1125, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search for a Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpConnectionSearchTime);
            this.groupBox2.Controls.Add(this.Lbl_Time);
            this.groupBox2.Controls.Add(this.Lbl_Date);
            this.groupBox2.Controls.Add(this.Dtp_Date);
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Options";
            // 
            // dtpConnectionSearchTime
            // 
            this.dtpConnectionSearchTime.CustomFormat = "HH:mm";
            this.dtpConnectionSearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConnectionSearchTime.Location = new System.Drawing.Point(22, 117);
            this.dtpConnectionSearchTime.Name = "dtpConnectionSearchTime";
            this.dtpConnectionSearchTime.ShowUpDown = true;
            this.dtpConnectionSearchTime.Size = new System.Drawing.Size(184, 20);
            this.dtpConnectionSearchTime.TabIndex = 7;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(19, 101);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Time.TabIndex = 6;
            this.Lbl_Time.Text = "Time:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(19, 37);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(33, 13);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Date:";
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Location = new System.Drawing.Point(22, 53);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(184, 20);
            this.Dtp_Date.TabIndex = 0;
            // 
            // Lv_Connections
            // 
            this.Lv_Connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Lv_Connections.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lv_Connections.HideSelection = false;
            this.Lv_Connections.Location = new System.Drawing.Point(251, 4);
            this.Lv_Connections.Margin = new System.Windows.Forms.Padding(2);
            this.Lv_Connections.Name = "Lv_Connections";
            this.Lv_Connections.Size = new System.Drawing.Size(870, 512);
            this.Lv_Connections.TabIndex = 1;
            this.Lv_Connections.UseCompatibleStateImageBehavior = false;
            this.Lv_Connections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "To";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Departure";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Arrival";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Operator";
            this.columnHeader5.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Cb_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionFrom);
            this.groupBox1.Controls.Add(this.Cb_ConnectionFrom);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(232, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for a Connection";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(22, 133);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(184, 23);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cb_ConnectionTo
            // 
            this.Cb_ConnectionTo.FormattingEnabled = true;
            this.Cb_ConnectionTo.Location = new System.Drawing.Point(22, 93);
            this.Cb_ConnectionTo.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_ConnectionTo.Name = "Cb_ConnectionTo";
            this.Cb_ConnectionTo.Size = new System.Drawing.Size(184, 21);
            this.Cb_ConnectionTo.TabIndex = 3;
            this.Cb_ConnectionTo.TextChanged += new System.EventHandler(this.Cb_ConnectionTo_TextChanged);
            // 
            // Lbl_ConnectionTo
            // 
            this.Lbl_ConnectionTo.AutoSize = true;
            this.Lbl_ConnectionTo.Location = new System.Drawing.Point(19, 78);
            this.Lbl_ConnectionTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ConnectionTo.Name = "Lbl_ConnectionTo";
            this.Lbl_ConnectionTo.Size = new System.Drawing.Size(80, 13);
            this.Lbl_ConnectionTo.TabIndex = 2;
            this.Lbl_ConnectionTo.Text = "Connection To:";
            // 
            // Lbl_ConnectionFrom
            // 
            this.Lbl_ConnectionFrom.AutoSize = true;
            this.Lbl_ConnectionFrom.Location = new System.Drawing.Point(19, 25);
            this.Lbl_ConnectionFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ConnectionFrom.Name = "Lbl_ConnectionFrom";
            this.Lbl_ConnectionFrom.Size = new System.Drawing.Size(90, 13);
            this.Lbl_ConnectionFrom.TabIndex = 1;
            this.Lbl_ConnectionFrom.Text = "Connection From:";
            // 
            // Cb_ConnectionFrom
            // 
            this.Cb_ConnectionFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cb_ConnectionFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cb_ConnectionFrom.FormattingEnabled = true;
            this.Cb_ConnectionFrom.Location = new System.Drawing.Point(22, 40);
            this.Cb_ConnectionFrom.Margin = new System.Windows.Forms.Padding(2);
            this.Cb_ConnectionFrom.Name = "Cb_ConnectionFrom";
            this.Cb_ConnectionFrom.Size = new System.Drawing.Size(184, 21);
            this.Cb_ConnectionFrom.TabIndex = 0;
            this.Cb_ConnectionFrom.TextChanged += new System.EventHandler(this.Cb_ConnectionFrom_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1125, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departure Board";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1125, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Station Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Lbl_Uhr
            // 
            this.Lbl_Uhr.AutoSize = true;
            this.Lbl_Uhr.Font = new System.Drawing.Font("Raleway", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Uhr.Location = new System.Drawing.Point(1010, 33);
            this.Lbl_Uhr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Uhr.Name = "Lbl_Uhr";
            this.Lbl_Uhr.Size = new System.Drawing.Size(98, 26);
            this.Lbl_Uhr.TabIndex = 3;
            this.Lbl_Uhr.Text = "00:00:00";
            this.Lbl_Uhr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Tmr_Uhr
            // 
            this.Tmr_Uhr.Enabled = true;
            this.Tmr_Uhr.Interval = 1000;
            this.Tmr_Uhr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 622);
            this.Controls.Add(this.Lbl_Uhr);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionTo;
        private System.Windows.Forms.Label Lbl_ConnectionFrom;
        private System.Windows.Forms.ComboBox Cb_ConnectionFrom;
        private System.Windows.Forms.ListView Lv_Connections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.DateTimePicker dtpConnectionSearchTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_Uhr;
        private System.Windows.Forms.Timer Tmr_Uhr;
    }
}

