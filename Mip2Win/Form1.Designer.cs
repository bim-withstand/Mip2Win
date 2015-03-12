namespace Mip2Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.noDuplicatesIn = new System.Windows.Forms.TextBox();
            this.restrictDuplicates = new System.Windows.Forms.CheckBox();
            this.genrePanel = new System.Windows.Forms.TableLayoutPanel();
            this.getGenreList = new System.Windows.Forms.Button();
            this.build = new System.Windows.Forms.Button();
            this.lockGenre = new System.Windows.Forms.CheckBox();
            this.seedLast = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PartialTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.musicipRunning = new System.Windows.Forms.Label();
            this.winampRunning = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.winampFolder = new System.Windows.Forms.TextBox();
            this.plName = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.serverAddress = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.autoStop_sun = new System.Windows.Forms.DateTimePicker();
            this.autoStart_sun = new System.Windows.Forms.DateTimePicker();
            this.autoStop_sat = new System.Windows.Forms.DateTimePicker();
            this.autoStart_sat = new System.Windows.Forms.DateTimePicker();
            this.autoStop_fri = new System.Windows.Forms.DateTimePicker();
            this.autoStart_fri = new System.Windows.Forms.DateTimePicker();
            this.autoStop_thu = new System.Windows.Forms.DateTimePicker();
            this.autoStart_thu = new System.Windows.Forms.DateTimePicker();
            this.autoStop_wed = new System.Windows.Forms.DateTimePicker();
            this.autoStart_wed = new System.Windows.Forms.DateTimePicker();
            this.autoStop_mon = new System.Windows.Forms.DateTimePicker();
            this.autoStart_mon = new System.Windows.Forms.DateTimePicker();
            this.autoStop_tue = new System.Windows.Forms.DateTimePicker();
            this.autoStart_tue = new System.Windows.Forms.DateTimePicker();
            this.addCount_sun = new System.Windows.Forms.CheckBox();
            this.addCount_sat = new System.Windows.Forms.CheckBox();
            this.addCount_fri = new System.Windows.Forms.CheckBox();
            this.addCount_thu = new System.Windows.Forms.CheckBox();
            this.addCount_wed = new System.Windows.Forms.CheckBox();
            this.addCount_tue = new System.Windows.Forms.CheckBox();
            this.addCount_mon = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.feedProgress = new System.Windows.Forms.ProgressBar();
            this.resetCount = new System.Windows.Forms.Button();
            this.addCount = new System.Windows.Forms.CheckBox();
            this.feedWinamp = new System.Windows.Forms.Button();
            this.rtbPlayList = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.helpAbout = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Mip2WinNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Controls.Add(this.tabPage5);
            this.tabs.ItemSize = new System.Drawing.Size(70, 20);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(0, 0);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(286, 263);
            this.tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.noDuplicatesIn);
            this.tabPage1.Controls.Add(this.restrictDuplicates);
            this.tabPage1.Controls.Add(this.genrePanel);
            this.tabPage1.Controls.Add(this.getGenreList);
            this.tabPage1.Controls.Add(this.build);
            this.tabPage1.Controls.Add(this.lockGenre);
            this.tabPage1.Controls.Add(this.seedLast);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.PartialTimePicker);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TotalTimePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "preferences";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // noDuplicatesIn
            // 
            this.noDuplicatesIn.BackColor = System.Drawing.SystemColors.Control;
            this.noDuplicatesIn.Enabled = false;
            this.noDuplicatesIn.Location = new System.Drawing.Point(180, 104);
            this.noDuplicatesIn.Name = "noDuplicatesIn";
            this.noDuplicatesIn.Size = new System.Drawing.Size(44, 20);
            this.noDuplicatesIn.TabIndex = 7;
            // 
            // restrictDuplicates
            // 
            this.restrictDuplicates.AutoSize = true;
            this.restrictDuplicates.Location = new System.Drawing.Point(11, 107);
            this.restrictDuplicates.Name = "restrictDuplicates";
            this.restrictDuplicates.Size = new System.Drawing.Size(260, 17);
            this.restrictDuplicates.TabIndex = 6;
            this.restrictDuplicates.Text = "Restrict duplicate artists within                    tracks.";
            this.restrictDuplicates.UseVisualStyleBackColor = true;
            this.restrictDuplicates.CheckedChanged += new System.EventHandler(this.restrictDuplicates_CheckedChanged);
            // 
            // genrePanel
            // 
            this.genrePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genrePanel.AutoScroll = true;
            this.genrePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.genrePanel.ColumnCount = 4;
            this.genrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.genrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.genrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.genrePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.genrePanel.Location = new System.Drawing.Point(11, 131);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.genrePanel.RowCount = 1;
            this.genrePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.genrePanel.Size = new System.Drawing.Size(260, 104);
            this.genrePanel.TabIndex = 5;
            this.genrePanel.Tag = "Existing genres";
            // 
            // getGenreList
            // 
            this.getGenreList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getGenreList.Location = new System.Drawing.Point(180, 6);
            this.getGenreList.Name = "getGenreList";
            this.getGenreList.Size = new System.Drawing.Size(91, 23);
            this.getGenreList.TabIndex = 4;
            this.getGenreList.Text = "Get Genres";
            this.getGenreList.UseVisualStyleBackColor = true;
            this.getGenreList.Click += new System.EventHandler(this.getGenreList_Click);
            // 
            // build
            // 
            this.build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.build.Location = new System.Drawing.Point(180, 32);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(91, 23);
            this.build.TabIndex = 4;
            this.build.Text = "Build PlayList";
            this.build.UseVisualStyleBackColor = true;
            this.build.Click += new System.EventHandler(this.build_Click);
            // 
            // lockGenre
            // 
            this.lockGenre.AutoSize = true;
            this.lockGenre.Location = new System.Drawing.Point(11, 84);
            this.lockGenre.Name = "lockGenre";
            this.lockGenre.Size = new System.Drawing.Size(161, 17);
            this.lockGenre.TabIndex = 2;
            this.lockGenre.Text = "Lock genre in partial playlists";
            this.lockGenre.UseVisualStyleBackColor = true;
            // 
            // seedLast
            // 
            this.seedLast.AutoSize = true;
            this.seedLast.Location = new System.Drawing.Point(11, 61);
            this.seedLast.Name = "seedLast";
            this.seedLast.Size = new System.Drawing.Size(161, 17);
            this.seedLast.TabIndex = 2;
            this.seedLast.Text = "Seed last song to next genre";
            this.seedLast.UseVisualStyleBackColor = true;
            this.seedLast.CheckedChanged += new System.EventHandler(this.seedLast_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Partial play time";
            // 
            // PartialTimePicker
            // 
            this.PartialTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PartialTimePicker.Location = new System.Drawing.Point(91, 32);
            this.PartialTimePicker.Name = "PartialTimePicker";
            this.PartialTimePicker.ShowUpDown = true;
            this.PartialTimePicker.Size = new System.Drawing.Size(66, 20);
            this.PartialTimePicker.TabIndex = 0;
            this.PartialTimePicker.Tag = "";
            this.PartialTimePicker.Value = new System.DateTime(2015, 1, 1, 1, 0, 0, 0);
            this.PartialTimePicker.ValueChanged += new System.EventHandler(this.PartialTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total play time";
            // 
            // TotalTimePicker
            // 
            this.TotalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TotalTimePicker.Location = new System.Drawing.Point(91, 6);
            this.TotalTimePicker.Name = "TotalTimePicker";
            this.TotalTimePicker.ShowUpDown = true;
            this.TotalTimePicker.Size = new System.Drawing.Size(66, 20);
            this.TotalTimePicker.TabIndex = 0;
            this.TotalTimePicker.Tag = "";
            this.TotalTimePicker.Value = new System.DateTime(2015, 1, 1, 12, 0, 0, 0);
            this.TotalTimePicker.ValueChanged += new System.EventHandler(this.TotalTimePicker_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.musicipRunning);
            this.tabPage2.Controls.Add(this.winampRunning);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.winampFolder);
            this.tabPage2.Controls.Add(this.plName);
            this.tabPage2.Controls.Add(this.serverPort);
            this.tabPage2.Controls.Add(this.serverAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(278, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // musicipRunning
            // 
            this.musicipRunning.AutoSize = true;
            this.musicipRunning.Location = new System.Drawing.Point(8, 112);
            this.musicipRunning.Name = "musicipRunning";
            this.musicipRunning.Size = new System.Drawing.Size(73, 13);
            this.musicipRunning.TabIndex = 1;
            this.musicipRunning.Text = "MusicIP Mixer";
            // 
            // winampRunning
            // 
            this.winampRunning.AutoSize = true;
            this.winampRunning.Location = new System.Drawing.Point(8, 86);
            this.winampRunning.Name = "winampRunning";
            this.winampRunning.Size = new System.Drawing.Size(46, 13);
            this.winampRunning.TabIndex = 1;
            this.winampRunning.Text = "Winamp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Winamp folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Playlist name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server :";
            // 
            // winampFolder
            // 
            this.winampFolder.Location = new System.Drawing.Point(87, 57);
            this.winampFolder.Name = "winampFolder";
            this.winampFolder.Size = new System.Drawing.Size(181, 20);
            this.winampFolder.TabIndex = 0;
            // 
            // plName
            // 
            this.plName.Location = new System.Drawing.Point(87, 31);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(181, 20);
            this.plName.TabIndex = 0;
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(217, 5);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(51, 20);
            this.serverPort.TabIndex = 0;
            // 
            // serverAddress
            // 
            this.serverAddress.Location = new System.Drawing.Point(50, 5);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(131, 20);
            this.serverAddress.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lbl_time);
            this.tabPage3.Controls.Add(this.autoStop_sun);
            this.tabPage3.Controls.Add(this.autoStart_sun);
            this.tabPage3.Controls.Add(this.autoStop_sat);
            this.tabPage3.Controls.Add(this.autoStart_sat);
            this.tabPage3.Controls.Add(this.autoStop_fri);
            this.tabPage3.Controls.Add(this.autoStart_fri);
            this.tabPage3.Controls.Add(this.autoStop_thu);
            this.tabPage3.Controls.Add(this.autoStart_thu);
            this.tabPage3.Controls.Add(this.autoStop_wed);
            this.tabPage3.Controls.Add(this.autoStart_wed);
            this.tabPage3.Controls.Add(this.autoStop_mon);
            this.tabPage3.Controls.Add(this.autoStart_mon);
            this.tabPage3.Controls.Add(this.autoStop_tue);
            this.tabPage3.Controls.Add(this.autoStart_tue);
            this.tabPage3.Controls.Add(this.addCount_sun);
            this.tabPage3.Controls.Add(this.addCount_sat);
            this.tabPage3.Controls.Add(this.addCount_fri);
            this.tabPage3.Controls.Add(this.addCount_thu);
            this.tabPage3.Controls.Add(this.addCount_wed);
            this.tabPage3.Controls.Add(this.addCount_tue);
            this.tabPage3.Controls.Add(this.addCount_mon);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(278, 235);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Sun.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sat.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Fri.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thu.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Wed.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tue.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mon.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(217, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Add Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Autostop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Autostart";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time.Location = new System.Drawing.Point(29, 3);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(62, 24);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Clock";
            // 
            // autoStop_sun
            // 
            this.autoStop_sun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_sun.Location = new System.Drawing.Point(125, 206);
            this.autoStop_sun.Name = "autoStop_sun";
            this.autoStop_sun.ShowCheckBox = true;
            this.autoStop_sun.ShowUpDown = true;
            this.autoStop_sun.Size = new System.Drawing.Size(85, 20);
            this.autoStop_sun.TabIndex = 14;
            this.autoStop_sun.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_sun
            // 
            this.autoStart_sun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_sun.Location = new System.Drawing.Point(33, 206);
            this.autoStart_sun.Name = "autoStart_sun";
            this.autoStart_sun.ShowCheckBox = true;
            this.autoStart_sun.ShowUpDown = true;
            this.autoStart_sun.Size = new System.Drawing.Size(85, 20);
            this.autoStart_sun.TabIndex = 13;
            this.autoStart_sun.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_sat
            // 
            this.autoStop_sat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_sat.Location = new System.Drawing.Point(125, 180);
            this.autoStop_sat.Name = "autoStop_sat";
            this.autoStop_sat.ShowCheckBox = true;
            this.autoStop_sat.ShowUpDown = true;
            this.autoStop_sat.Size = new System.Drawing.Size(85, 20);
            this.autoStop_sat.TabIndex = 12;
            this.autoStop_sat.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_sat
            // 
            this.autoStart_sat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_sat.Location = new System.Drawing.Point(33, 180);
            this.autoStart_sat.Name = "autoStart_sat";
            this.autoStart_sat.ShowCheckBox = true;
            this.autoStart_sat.ShowUpDown = true;
            this.autoStart_sat.Size = new System.Drawing.Size(85, 20);
            this.autoStart_sat.TabIndex = 11;
            this.autoStart_sat.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_fri
            // 
            this.autoStop_fri.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_fri.Location = new System.Drawing.Point(125, 154);
            this.autoStop_fri.Name = "autoStop_fri";
            this.autoStop_fri.ShowCheckBox = true;
            this.autoStop_fri.ShowUpDown = true;
            this.autoStop_fri.Size = new System.Drawing.Size(85, 20);
            this.autoStop_fri.TabIndex = 10;
            this.autoStop_fri.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_fri
            // 
            this.autoStart_fri.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_fri.Location = new System.Drawing.Point(33, 154);
            this.autoStart_fri.Name = "autoStart_fri";
            this.autoStart_fri.ShowCheckBox = true;
            this.autoStart_fri.ShowUpDown = true;
            this.autoStart_fri.Size = new System.Drawing.Size(85, 20);
            this.autoStart_fri.TabIndex = 9;
            this.autoStart_fri.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_thu
            // 
            this.autoStop_thu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_thu.Location = new System.Drawing.Point(125, 128);
            this.autoStop_thu.Name = "autoStop_thu";
            this.autoStop_thu.ShowCheckBox = true;
            this.autoStop_thu.ShowUpDown = true;
            this.autoStop_thu.Size = new System.Drawing.Size(85, 20);
            this.autoStop_thu.TabIndex = 8;
            this.autoStop_thu.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_thu
            // 
            this.autoStart_thu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_thu.Location = new System.Drawing.Point(33, 128);
            this.autoStart_thu.Name = "autoStart_thu";
            this.autoStart_thu.ShowCheckBox = true;
            this.autoStart_thu.ShowUpDown = true;
            this.autoStart_thu.Size = new System.Drawing.Size(85, 20);
            this.autoStart_thu.TabIndex = 7;
            this.autoStart_thu.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_wed
            // 
            this.autoStop_wed.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_wed.Location = new System.Drawing.Point(125, 102);
            this.autoStop_wed.Name = "autoStop_wed";
            this.autoStop_wed.ShowCheckBox = true;
            this.autoStop_wed.ShowUpDown = true;
            this.autoStop_wed.Size = new System.Drawing.Size(85, 20);
            this.autoStop_wed.TabIndex = 6;
            this.autoStop_wed.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_wed
            // 
            this.autoStart_wed.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_wed.Location = new System.Drawing.Point(33, 102);
            this.autoStart_wed.Name = "autoStart_wed";
            this.autoStart_wed.ShowCheckBox = true;
            this.autoStart_wed.ShowUpDown = true;
            this.autoStart_wed.Size = new System.Drawing.Size(85, 20);
            this.autoStart_wed.TabIndex = 5;
            this.autoStart_wed.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_mon
            // 
            this.autoStop_mon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_mon.Location = new System.Drawing.Point(125, 50);
            this.autoStop_mon.Name = "autoStop_mon";
            this.autoStop_mon.ShowCheckBox = true;
            this.autoStop_mon.ShowUpDown = true;
            this.autoStop_mon.Size = new System.Drawing.Size(85, 20);
            this.autoStop_mon.TabIndex = 2;
            this.autoStop_mon.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_mon
            // 
            this.autoStart_mon.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_mon.Location = new System.Drawing.Point(33, 50);
            this.autoStart_mon.Name = "autoStart_mon";
            this.autoStart_mon.ShowCheckBox = true;
            this.autoStart_mon.ShowUpDown = true;
            this.autoStart_mon.Size = new System.Drawing.Size(85, 20);
            this.autoStart_mon.TabIndex = 1;
            this.autoStart_mon.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStop_tue
            // 
            this.autoStop_tue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStop_tue.Location = new System.Drawing.Point(125, 76);
            this.autoStop_tue.Name = "autoStop_tue";
            this.autoStop_tue.ShowCheckBox = true;
            this.autoStop_tue.ShowUpDown = true;
            this.autoStop_tue.Size = new System.Drawing.Size(85, 20);
            this.autoStop_tue.TabIndex = 4;
            this.autoStop_tue.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // autoStart_tue
            // 
            this.autoStart_tue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.autoStart_tue.Location = new System.Drawing.Point(33, 76);
            this.autoStart_tue.Name = "autoStart_tue";
            this.autoStart_tue.ShowCheckBox = true;
            this.autoStart_tue.ShowUpDown = true;
            this.autoStart_tue.Size = new System.Drawing.Size(85, 20);
            this.autoStart_tue.TabIndex = 3;
            this.autoStart_tue.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // addCount_sun
            // 
            this.addCount_sun.AutoSize = true;
            this.addCount_sun.Location = new System.Drawing.Point(220, 208);
            this.addCount_sun.Name = "addCount_sun";
            this.addCount_sun.Size = new System.Drawing.Size(15, 14);
            this.addCount_sun.TabIndex = 21;
            this.addCount_sun.UseVisualStyleBackColor = true;
            // 
            // addCount_sat
            // 
            this.addCount_sat.AutoSize = true;
            this.addCount_sat.Location = new System.Drawing.Point(220, 182);
            this.addCount_sat.Name = "addCount_sat";
            this.addCount_sat.Size = new System.Drawing.Size(15, 14);
            this.addCount_sat.TabIndex = 20;
            this.addCount_sat.UseVisualStyleBackColor = true;
            // 
            // addCount_fri
            // 
            this.addCount_fri.AutoSize = true;
            this.addCount_fri.Location = new System.Drawing.Point(220, 156);
            this.addCount_fri.Name = "addCount_fri";
            this.addCount_fri.Size = new System.Drawing.Size(15, 14);
            this.addCount_fri.TabIndex = 19;
            this.addCount_fri.UseVisualStyleBackColor = true;
            // 
            // addCount_thu
            // 
            this.addCount_thu.AutoSize = true;
            this.addCount_thu.Location = new System.Drawing.Point(220, 130);
            this.addCount_thu.Name = "addCount_thu";
            this.addCount_thu.Size = new System.Drawing.Size(15, 14);
            this.addCount_thu.TabIndex = 18;
            this.addCount_thu.UseVisualStyleBackColor = true;
            // 
            // addCount_wed
            // 
            this.addCount_wed.AutoSize = true;
            this.addCount_wed.Location = new System.Drawing.Point(220, 104);
            this.addCount_wed.Name = "addCount_wed";
            this.addCount_wed.Size = new System.Drawing.Size(15, 14);
            this.addCount_wed.TabIndex = 17;
            this.addCount_wed.UseVisualStyleBackColor = true;
            // 
            // addCount_tue
            // 
            this.addCount_tue.AutoSize = true;
            this.addCount_tue.Location = new System.Drawing.Point(220, 78);
            this.addCount_tue.Name = "addCount_tue";
            this.addCount_tue.Size = new System.Drawing.Size(15, 14);
            this.addCount_tue.TabIndex = 16;
            this.addCount_tue.UseVisualStyleBackColor = true;
            // 
            // addCount_mon
            // 
            this.addCount_mon.AutoSize = true;
            this.addCount_mon.Location = new System.Drawing.Point(220, 52);
            this.addCount_mon.Name = "addCount_mon";
            this.addCount_mon.Size = new System.Drawing.Size(15, 14);
            this.addCount_mon.TabIndex = 15;
            this.addCount_mon.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.feedProgress);
            this.tabPage4.Controls.Add(this.resetCount);
            this.tabPage4.Controls.Add(this.addCount);
            this.tabPage4.Controls.Add(this.feedWinamp);
            this.tabPage4.Controls.Add(this.rtbPlayList);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(278, 235);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "playlist";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // feedProgress
            // 
            this.feedProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedProgress.Location = new System.Drawing.Point(6, 162);
            this.feedProgress.Name = "feedProgress";
            this.feedProgress.Size = new System.Drawing.Size(250, 23);
            this.feedProgress.TabIndex = 8;
            this.feedProgress.Visible = false;
            // 
            // resetCount
            // 
            this.resetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resetCount.Location = new System.Drawing.Point(139, 209);
            this.resetCount.Margin = new System.Windows.Forms.Padding(0);
            this.resetCount.Name = "resetCount";
            this.resetCount.Size = new System.Drawing.Size(40, 23);
            this.resetCount.TabIndex = 7;
            this.resetCount.Text = "reset";
            this.resetCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetCount.UseVisualStyleBackColor = true;
            this.resetCount.Click += new System.EventHandler(this.resetCount_Click);
            // 
            // addCount
            // 
            this.addCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCount.AutoSize = true;
            this.addCount.Location = new System.Drawing.Point(8, 215);
            this.addCount.Name = "addCount";
            this.addCount.Size = new System.Drawing.Size(94, 17);
            this.addCount.TabIndex = 6;
            this.addCount.Text = "Add playcount";
            this.addCount.UseVisualStyleBackColor = true;
            // 
            // feedWinamp
            // 
            this.feedWinamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.feedWinamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedWinamp.Location = new System.Drawing.Point(190, 209);
            this.feedWinamp.Margin = new System.Windows.Forms.Padding(0);
            this.feedWinamp.Name = "feedWinamp";
            this.feedWinamp.Size = new System.Drawing.Size(83, 23);
            this.feedWinamp.TabIndex = 5;
            this.feedWinamp.Text = "Feed Winamp";
            this.feedWinamp.UseVisualStyleBackColor = true;
            this.feedWinamp.Click += new System.EventHandler(this.feedWinamp_Click);
            // 
            // rtbPlayList
            // 
            this.rtbPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbPlayList.Location = new System.Drawing.Point(3, 3);
            this.rtbPlayList.Name = "rtbPlayList";
            this.rtbPlayList.ReadOnly = true;
            this.rtbPlayList.Size = new System.Drawing.Size(270, 200);
            this.rtbPlayList.TabIndex = 0;
            this.rtbPlayList.Text = "";
            this.rtbPlayList.WordWrap = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.helpAbout);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(278, 235);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "help/about";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // helpAbout
            // 
            this.helpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpAbout.Location = new System.Drawing.Point(0, 0);
            this.helpAbout.MinimumSize = new System.Drawing.Size(20, 20);
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(278, 235);
            this.helpAbout.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mip2WinNotify
            // 
            this.Mip2WinNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("Mip2WinNotify.Icon")));
            this.Mip2WinNotify.Text = "Mip2Win";
            this.Mip2WinNotify.Visible = true;
            this.Mip2WinNotify.Click += new System.EventHandler(this.Mip2Win_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Mip2Win";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox serverAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox winampFolder;
        private System.Windows.Forms.TextBox plName;
        private System.Windows.Forms.Label musicipRunning;
        private System.Windows.Forms.Label winampRunning;
        private System.Windows.Forms.CheckBox lockGenre;
        private System.Windows.Forms.CheckBox seedLast;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker PartialTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TotalTimePicker;
        private System.Windows.Forms.Button build;
        private System.Windows.Forms.TableLayoutPanel genrePanel;
        private System.Windows.Forms.Button getGenreList;
        private System.Windows.Forms.RichTextBox rtbPlayList;
        private System.Windows.Forms.Button feedWinamp;
        private System.Windows.Forms.CheckBox addCount;
        private System.Windows.Forms.TextBox noDuplicatesIn;
        private System.Windows.Forms.CheckBox restrictDuplicates;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button resetCount;
        private System.Windows.Forms.ProgressBar feedProgress;
        private System.Windows.Forms.DateTimePicker autoStart_sun;
        private System.Windows.Forms.DateTimePicker autoStart_sat;
        private System.Windows.Forms.DateTimePicker autoStart_fri;
        private System.Windows.Forms.DateTimePicker autoStart_thu;
        private System.Windows.Forms.DateTimePicker autoStart_wed;
        private System.Windows.Forms.DateTimePicker autoStart_tue;
        private System.Windows.Forms.CheckBox addCount_mon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker autoStop_sun;
        private System.Windows.Forms.DateTimePicker autoStop_sat;
        private System.Windows.Forms.DateTimePicker autoStop_fri;
        private System.Windows.Forms.DateTimePicker autoStop_thu;
        private System.Windows.Forms.DateTimePicker autoStop_wed;
        private System.Windows.Forms.DateTimePicker autoStop_tue;
        private System.Windows.Forms.CheckBox addCount_sun;
        private System.Windows.Forms.CheckBox addCount_sat;
        private System.Windows.Forms.CheckBox addCount_fri;
        private System.Windows.Forms.CheckBox addCount_thu;
        private System.Windows.Forms.CheckBox addCount_wed;
        private System.Windows.Forms.CheckBox addCount_tue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker autoStop_mon;
        private System.Windows.Forms.DateTimePicker autoStart_mon;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.WebBrowser helpAbout;
        private System.Windows.Forms.NotifyIcon Mip2WinNotify;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

