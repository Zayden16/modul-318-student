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
            this.Lv_Connections = new System.Windows.Forms.ListView();
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDepartureStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Time = new System.Windows.Forms.TextBox();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Cb_ConnectionTo = new System.Windows.Forms.ComboBox();
            this.Lbl_ConnectionTo = new System.Windows.Forms.Label();
            this.Lbl_ConnectionFrom = new System.Windows.Forms.Label();
            this.Cb_ConnectionFrom = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Search_DepBoard = new System.Windows.Forms.Button();
            this.lv_DepartureBoard = new System.Windows.Forms.ListView();
            this.cDepTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lbl_ConectionsFromDepBoard = new System.Windows.Forms.Label();
            this.Cb_ConnectionsFromDepBoard = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Lbl_Uhr = new System.Windows.Forms.Label();
            this.Tmr_Uhr = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(2077, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(105, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connections";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 142);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2077, 1008);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lv_Connections);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(2069, 971);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search for a Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lv_Connections
            // 
            this.Lv_Connections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDate,
            this.cDepartureTime,
            this.cDepartureStation,
            this.cArrivalStation,
            this.cArrivalTime,
            this.cDuration,
            this.cPlatform});
            this.Lv_Connections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Connections.HideSelection = false;
            this.Lv_Connections.Location = new System.Drawing.Point(439, 8);
            this.Lv_Connections.Margin = new System.Windows.Forms.Padding(4);
            this.Lv_Connections.Name = "Lv_Connections";
            this.Lv_Connections.Size = new System.Drawing.Size(1608, 952);
            this.Lv_Connections.TabIndex = 8;
            this.Lv_Connections.TabStop = false;
            this.Lv_Connections.UseCompatibleStateImageBehavior = false;
            this.Lv_Connections.View = System.Windows.Forms.View.Details;
            // 
            // cDate
            // 
            this.cDate.Text = "Date";
            this.cDate.Width = 100;
            // 
            // cDepartureTime
            // 
            this.cDepartureTime.Text = "Departure Time";
            this.cDepartureTime.Width = 80;
            // 
            // cDepartureStation
            // 
            this.cDepartureStation.Text = "Departure Station";
            this.cDepartureStation.Width = 200;
            // 
            // cArrivalStation
            // 
            this.cArrivalStation.Text = "Arrival Station";
            this.cArrivalStation.Width = 200;
            // 
            // cArrivalTime
            // 
            this.cArrivalTime.Text = "Arrival Time";
            this.cArrivalTime.Width = 80;
            // 
            // cDuration
            // 
            this.cDuration.Text = "Duration";
            this.cDuration.Width = 50;
            // 
            // cPlatform
            // 
            this.cPlatform.Text = "Platform";
            this.cPlatform.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Time);
            this.groupBox2.Controls.Add(this.Lbl_Time);
            this.groupBox2.Controls.Add(this.Lbl_Date);
            this.groupBox2.Controls.Add(this.Dtp_Date);
            this.groupBox2.Location = new System.Drawing.Point(6, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(425, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detailed Options";
            // 
            // Txt_Time
            // 
            this.Txt_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Time.Location = new System.Drawing.Point(40, 215);
            this.Txt_Time.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Time.Name = "Txt_Time";
            this.Txt_Time.Size = new System.Drawing.Size(162, 34);
            this.Txt_Time.TabIndex = 7;
            this.Txt_Time.Text = "HH:mm";
            this.Txt_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Location = new System.Drawing.Point(35, 186);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(62, 25);
            this.Lbl_Time.TabIndex = 6;
            this.Lbl_Time.Text = "Time:";
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(35, 68);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(59, 25);
            this.Lbl_Date.TabIndex = 5;
            this.Lbl_Date.Text = "Date:";
            // 
            // Dtp_Date
            // 
            this.Dtp_Date.Location = new System.Drawing.Point(40, 98);
            this.Dtp_Date.Margin = new System.Windows.Forms.Padding(6);
            this.Dtp_Date.Name = "Dtp_Date";
            this.Dtp_Date.Size = new System.Drawing.Size(334, 29);
            this.Dtp_Date.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Cb_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionTo);
            this.groupBox1.Controls.Add(this.Lbl_ConnectionFrom);
            this.groupBox1.Controls.Add(this.Cb_ConnectionFrom);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(425, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for a Connection";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(40, 246);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(337, 42);
            this.Btn_Search.TabIndex = 4;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Cb_ConnectionTo
            // 
            this.Cb_ConnectionTo.FormattingEnabled = true;
            this.Cb_ConnectionTo.Location = new System.Drawing.Point(40, 172);
            this.Cb_ConnectionTo.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_ConnectionTo.Name = "Cb_ConnectionTo";
            this.Cb_ConnectionTo.Size = new System.Drawing.Size(334, 32);
            this.Cb_ConnectionTo.TabIndex = 3;
            this.Cb_ConnectionTo.TextUpdate += new System.EventHandler(this.Cb_ConnectionTo_TextUpdate);
            // 
            // Lbl_ConnectionTo
            // 
            this.Lbl_ConnectionTo.AutoSize = true;
            this.Lbl_ConnectionTo.Location = new System.Drawing.Point(35, 144);
            this.Lbl_ConnectionTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConnectionTo.Name = "Lbl_ConnectionTo";
            this.Lbl_ConnectionTo.Size = new System.Drawing.Size(147, 25);
            this.Lbl_ConnectionTo.TabIndex = 2;
            this.Lbl_ConnectionTo.Text = "Connection To:";
            // 
            // Lbl_ConnectionFrom
            // 
            this.Lbl_ConnectionFrom.AutoSize = true;
            this.Lbl_ConnectionFrom.Location = new System.Drawing.Point(35, 46);
            this.Lbl_ConnectionFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConnectionFrom.Name = "Lbl_ConnectionFrom";
            this.Lbl_ConnectionFrom.Size = new System.Drawing.Size(168, 25);
            this.Lbl_ConnectionFrom.TabIndex = 1;
            this.Lbl_ConnectionFrom.Text = "Connection From:";
            // 
            // Cb_ConnectionFrom
            // 
            this.Cb_ConnectionFrom.FormattingEnabled = true;
            this.Cb_ConnectionFrom.Location = new System.Drawing.Point(40, 74);
            this.Cb_ConnectionFrom.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_ConnectionFrom.Name = "Cb_ConnectionFrom";
            this.Cb_ConnectionFrom.Size = new System.Drawing.Size(334, 32);
            this.Cb_ConnectionFrom.TabIndex = 0;
            this.Cb_ConnectionFrom.TextUpdate += new System.EventHandler(this.Cb_ConnectionFrom_TextUpdate);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Search_DepBoard);
            this.tabPage2.Controls.Add(this.lv_DepartureBoard);
            this.tabPage2.Controls.Add(this.Lbl_ConectionsFromDepBoard);
            this.tabPage2.Controls.Add(this.Cb_ConnectionsFromDepBoard);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(2069, 971);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departure Board";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Search_DepBoard
            // 
            this.Btn_Search_DepBoard.Location = new System.Drawing.Point(386, 26);
            this.Btn_Search_DepBoard.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_Search_DepBoard.Name = "Btn_Search_DepBoard";
            this.Btn_Search_DepBoard.Size = new System.Drawing.Size(337, 42);
            this.Btn_Search_DepBoard.TabIndex = 10;
            this.Btn_Search_DepBoard.Text = "Search";
            this.Btn_Search_DepBoard.UseVisualStyleBackColor = true;
            this.Btn_Search_DepBoard.Click += new System.EventHandler(this.Btn_Search_DepBoard_Click);
            // 
            // lv_DepartureBoard
            // 
            this.lv_DepartureBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cDepTime,
            this.cDestination,
            this.cDesignation});
            this.lv_DepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DepartureBoard.HideSelection = false;
            this.lv_DepartureBoard.Location = new System.Drawing.Point(12, 72);
            this.lv_DepartureBoard.Margin = new System.Windows.Forms.Padding(4);
            this.lv_DepartureBoard.Name = "lv_DepartureBoard";
            this.lv_DepartureBoard.Size = new System.Drawing.Size(2035, 888);
            this.lv_DepartureBoard.TabIndex = 9;
            this.lv_DepartureBoard.TabStop = false;
            this.lv_DepartureBoard.UseCompatibleStateImageBehavior = false;
            this.lv_DepartureBoard.View = System.Windows.Forms.View.Details;
            // 
            // cDepTime
            // 
            this.cDepTime.Text = "Departure";
            this.cDepTime.Width = 150;
            // 
            // cDestination
            // 
            this.cDestination.Text = "Destination";
            this.cDestination.Width = 200;
            // 
            // cDesignation
            // 
            this.cDesignation.Text = "Designation";
            this.cDesignation.Width = 150;
            // 
            // Lbl_ConectionsFromDepBoard
            // 
            this.Lbl_ConectionsFromDepBoard.AutoSize = true;
            this.Lbl_ConectionsFromDepBoard.Location = new System.Drawing.Point(8, 4);
            this.Lbl_ConectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ConectionsFromDepBoard.Name = "Lbl_ConectionsFromDepBoard";
            this.Lbl_ConectionsFromDepBoard.Size = new System.Drawing.Size(168, 25);
            this.Lbl_ConectionsFromDepBoard.TabIndex = 3;
            this.Lbl_ConectionsFromDepBoard.Text = "Connection From:";
            // 
            // Cb_ConnectionsFromDepBoard
            // 
            this.Cb_ConnectionsFromDepBoard.FormattingEnabled = true;
            this.Cb_ConnectionsFromDepBoard.Location = new System.Drawing.Point(13, 32);
            this.Cb_ConnectionsFromDepBoard.Margin = new System.Windows.Forms.Padding(4);
            this.Cb_ConnectionsFromDepBoard.Name = "Cb_ConnectionsFromDepBoard";
            this.Cb_ConnectionsFromDepBoard.Size = new System.Drawing.Size(334, 32);
            this.Cb_ConnectionsFromDepBoard.TabIndex = 2;
            this.Cb_ConnectionsFromDepBoard.TextUpdate += new System.EventHandler(this.Cb_ConnectionsFromDepBoard_TextUpdate);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(2069, 971);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Station Map";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Lbl_Uhr
            // 
            this.Lbl_Uhr.AutoSize = true;
            this.Lbl_Uhr.Font = new System.Drawing.Font("Raleway", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Uhr.Location = new System.Drawing.Point(1852, 61);
            this.Lbl_Uhr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Uhr.Name = "Lbl_Uhr";
            this.Lbl_Uhr.Size = new System.Drawing.Size(172, 44);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2077, 1148);
            this.Controls.Add(this.Lbl_Uhr);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.DateTimePicker Dtp_Date;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_Uhr;
        private System.Windows.Forms.Timer Tmr_Uhr;
        private System.Windows.Forms.Label Lbl_ConectionsFromDepBoard;
        private System.Windows.Forms.ComboBox Cb_ConnectionsFromDepBoard;
        private System.Windows.Forms.ListView Lv_Connections;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ColumnHeader cDepartureTime;
        private System.Windows.Forms.ColumnHeader cDepartureStation;
        private System.Windows.Forms.ColumnHeader cArrivalStation;
        private System.Windows.Forms.ColumnHeader cArrivalTime;
        private System.Windows.Forms.ColumnHeader cDuration;
        private System.Windows.Forms.ColumnHeader cPlatform;
        private System.Windows.Forms.TextBox Txt_Time;
        private System.Windows.Forms.ListView lv_DepartureBoard;
        private System.Windows.Forms.ColumnHeader cDepTime;
        private System.Windows.Forms.ColumnHeader cDestination;
        private System.Windows.Forms.Button Btn_Search_DepBoard;
        private System.Windows.Forms.ColumnHeader cDesignation;
    }
}

