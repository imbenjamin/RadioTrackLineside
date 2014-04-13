namespace RadioTrack_ReaderClient
{
    partial class form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status_statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_readerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_databaseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_dateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.tbllayout_wholeWindow = new System.Windows.Forms.TableLayoutPanel();
            this.tbllayout_leftHalfWindow = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_thisStationLabel = new System.Windows.Forms.Label();
            this.lbl_timestampLabel = new System.Windows.Forms.Label();
            this.lbl_taktTimeLabel = new System.Windows.Forms.Label();
            this.lbl_scanTime = new System.Windows.Forms.Label();
            this.lbl_taktTime = new System.Windows.Forms.Label();
            this.cb_stationPicker = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblLayout_rightHalfWindow = new System.Windows.Forms.TableLayoutPanel();
            this.tbllayout_rightVinOrderContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_vin = new System.Windows.Forms.Label();
            this.lbl_orderNo = new System.Windows.Forms.Label();
            this.lbl_modelCode = new System.Windows.Forms.Label();
            this.textbox_buildCard = new System.Windows.Forms.RichTextBox();
            this.notifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifIconMenu_title = new System.Windows.Forms.ToolStripMenuItem();
            this.notifIconMenu_thisStation = new System.Windows.Forms.ToolStripMenuItem();
            this.notifIconMenu_sep01 = new System.Windows.Forms.ToolStripSeparator();
            this.notifIconMenu_database = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseMenu_primary = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMenu_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMenu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifIconMenu_language = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.langMenu_en = new System.Windows.Forms.ToolStripMenuItem();
            this.langMenu_de = new System.Windows.Forms.ToolStripMenuItem();
            this.notifIconMenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.notifIconMenu_sep02 = new System.Windows.Forms.ToolStripSeparator();
            this.notifIconMenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.scanTimer = new System.Windows.Forms.Timer(this.components);
            this.taktTimer = new System.Windows.Forms.Timer(this.components);
            this.usbConnCheckWorker = new System.ComponentModel.BackgroundWorker();
            this.dbConnCheckWorker = new System.ComponentModel.BackgroundWorker();
            this.rfidtrackDataSet = new RadioTrack_ReaderClient.rfidtrackDataSet();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip.SuspendLayout();
            this.tbllayout_wholeWindow.SuspendLayout();
            this.tbllayout_leftHalfWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tblLayout_rightHalfWindow.SuspendLayout();
            this.tbllayout_rightVinOrderContainer.SuspendLayout();
            this.notifIconMenu.SuspendLayout();
            this.databaseMenu.SuspendLayout();
            this.languageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rfidtrackDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_statusLabel,
            this.status_spring,
            this.status_readerStatus,
            this.status_databaseStatus,
            this.status_dateLabel,
            this.status_timeLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 706);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(1008, 24);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // status_statusLabel
            // 
            this.status_statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_statusLabel.Name = "status_statusLabel";
            this.status_statusLabel.Size = new System.Drawing.Size(143, 19);
            this.status_statusLabel.Text = "Waiting for connections...";
            // 
            // status_spring
            // 
            this.status_spring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.status_spring.Name = "status_spring";
            this.status_spring.Size = new System.Drawing.Size(487, 19);
            this.status_spring.Spring = true;
            // 
            // status_readerStatus
            // 
            this.status_readerStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.status_readerStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_readerStatus.Name = "status_readerStatus";
            this.status_readerStatus.Size = new System.Drawing.Size(135, 19);
            this.status_readerStatus.Text = "Connecting to Reader...";
            // 
            // status_databaseStatus
            // 
            this.status_databaseStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.status_databaseStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_databaseStatus.Name = "status_databaseStatus";
            this.status_databaseStatus.Size = new System.Drawing.Size(147, 19);
            this.status_databaseStatus.Text = "Connecting to Database...";
            // 
            // status_dateLabel
            // 
            this.status_dateLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.status_dateLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_dateLabel.Name = "status_dateLabel";
            this.status_dateLabel.Size = new System.Drawing.Size(42, 19);
            this.status_dateLabel.Text = "[date]";
            // 
            // status_timeLabel
            // 
            this.status_timeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_timeLabel.Name = "status_timeLabel";
            this.status_timeLabel.Size = new System.Drawing.Size(39, 19);
            this.status_timeLabel.Text = "[time]";
            this.status_timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // tbllayout_wholeWindow
            // 
            this.tbllayout_wholeWindow.ColumnCount = 2;
            this.tbllayout_wholeWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbllayout_wholeWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbllayout_wholeWindow.Controls.Add(this.tbllayout_leftHalfWindow, 0, 0);
            this.tbllayout_wholeWindow.Controls.Add(this.tblLayout_rightHalfWindow, 1, 0);
            this.tbllayout_wholeWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayout_wholeWindow.Location = new System.Drawing.Point(0, 0);
            this.tbllayout_wholeWindow.Name = "tbllayout_wholeWindow";
            this.tbllayout_wholeWindow.RowCount = 1;
            this.tbllayout_wholeWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllayout_wholeWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.tbllayout_wholeWindow.Size = new System.Drawing.Size(1008, 706);
            this.tbllayout_wholeWindow.TabIndex = 1;
            // 
            // tbllayout_leftHalfWindow
            // 
            this.tbllayout_leftHalfWindow.ColumnCount = 1;
            this.tbllayout_leftHalfWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllayout_leftHalfWindow.Controls.Add(this.lbl_thisStationLabel, 0, 0);
            this.tbllayout_leftHalfWindow.Controls.Add(this.lbl_timestampLabel, 0, 2);
            this.tbllayout_leftHalfWindow.Controls.Add(this.lbl_taktTimeLabel, 0, 4);
            this.tbllayout_leftHalfWindow.Controls.Add(this.lbl_scanTime, 0, 3);
            this.tbllayout_leftHalfWindow.Controls.Add(this.lbl_taktTime, 0, 5);
            this.tbllayout_leftHalfWindow.Controls.Add(this.cb_stationPicker, 0, 1);
            this.tbllayout_leftHalfWindow.Controls.Add(this.pictureBox1, 0, 6);
            this.tbllayout_leftHalfWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayout_leftHalfWindow.Location = new System.Drawing.Point(3, 3);
            this.tbllayout_leftHalfWindow.Name = "tbllayout_leftHalfWindow";
            this.tbllayout_leftHalfWindow.RowCount = 7;
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.473683F));
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.473683F));
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tbllayout_leftHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tbllayout_leftHalfWindow.Size = new System.Drawing.Size(397, 700);
            this.tbllayout_leftHalfWindow.TabIndex = 0;
            // 
            // lbl_thisStationLabel
            // 
            this.lbl_thisStationLabel.AutoSize = true;
            this.lbl_thisStationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thisStationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thisStationLabel.Location = new System.Drawing.Point(3, 0);
            this.lbl_thisStationLabel.Name = "lbl_thisStationLabel";
            this.lbl_thisStationLabel.Size = new System.Drawing.Size(391, 20);
            this.lbl_thisStationLabel.TabIndex = 0;
            this.lbl_thisStationLabel.Text = "This Station:";
            this.lbl_thisStationLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_timestampLabel
            // 
            this.lbl_timestampLabel.AutoSize = true;
            this.lbl_timestampLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_timestampLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timestampLabel.Location = new System.Drawing.Point(3, 59);
            this.lbl_timestampLabel.Name = "lbl_timestampLabel";
            this.lbl_timestampLabel.Size = new System.Drawing.Size(391, 60);
            this.lbl_timestampLabel.TabIndex = 1;
            this.lbl_timestampLabel.Text = "Vehicle Registered at:";
            this.lbl_timestampLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_taktTimeLabel
            // 
            this.lbl_taktTimeLabel.AutoSize = true;
            this.lbl_taktTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_taktTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taktTimeLabel.Location = new System.Drawing.Point(3, 199);
            this.lbl_taktTimeLabel.Name = "lbl_taktTimeLabel";
            this.lbl_taktTimeLabel.Size = new System.Drawing.Size(391, 60);
            this.lbl_taktTimeLabel.TabIndex = 2;
            this.lbl_taktTimeLabel.Text = "This Takt:";
            this.lbl_taktTimeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_scanTime
            // 
            this.lbl_scanTime.AutoSize = true;
            this.lbl_scanTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_scanTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_scanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scanTime.Location = new System.Drawing.Point(3, 119);
            this.lbl_scanTime.Name = "lbl_scanTime";
            this.lbl_scanTime.Size = new System.Drawing.Size(391, 80);
            this.lbl_scanTime.TabIndex = 4;
            this.lbl_scanTime.Text = "00:00:00";
            this.lbl_scanTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_taktTime
            // 
            this.lbl_taktTime.AutoSize = true;
            this.lbl_taktTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_taktTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_taktTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taktTime.Location = new System.Drawing.Point(3, 259);
            this.lbl_taktTime.Name = "lbl_taktTime";
            this.lbl_taktTime.Size = new System.Drawing.Size(391, 101);
            this.lbl_taktTime.TabIndex = 5;
            this.lbl_taktTime.Text = "00:00:00";
            this.lbl_taktTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_stationPicker
            // 
            this.cb_stationPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_stationPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_stationPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stationPicker.FormattingEnabled = true;
            this.cb_stationPicker.Location = new System.Drawing.Point(3, 23);
            this.cb_stationPicker.Name = "cb_stationPicker";
            this.cb_stationPicker.Size = new System.Drawing.Size(391, 33);
            this.cb_stationPicker.TabIndex = 6;
            this.cb_stationPicker.SelectionChangeCommitted += new System.EventHandler(this.cb_stationPicker_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RadioTrack_ReaderClient.Properties.Resources.lcl_logo_full_light;
            this.pictureBox1.Location = new System.Drawing.Point(50, 410);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tblLayout_rightHalfWindow
            // 
            this.tblLayout_rightHalfWindow.ColumnCount = 1;
            this.tblLayout_rightHalfWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout_rightHalfWindow.Controls.Add(this.tbllayout_rightVinOrderContainer, 0, 0);
            this.tblLayout_rightHalfWindow.Controls.Add(this.lbl_modelCode, 0, 1);
            this.tblLayout_rightHalfWindow.Controls.Add(this.textbox_buildCard, 0, 2);
            this.tblLayout_rightHalfWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout_rightHalfWindow.Location = new System.Drawing.Point(406, 3);
            this.tblLayout_rightHalfWindow.Name = "tblLayout_rightHalfWindow";
            this.tblLayout_rightHalfWindow.RowCount = 3;
            this.tblLayout_rightHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayout_rightHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout_rightHalfWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLayout_rightHalfWindow.Size = new System.Drawing.Size(599, 700);
            this.tblLayout_rightHalfWindow.TabIndex = 1;
            // 
            // tbllayout_rightVinOrderContainer
            // 
            this.tbllayout_rightVinOrderContainer.ColumnCount = 2;
            this.tbllayout_rightVinOrderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayout_rightVinOrderContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllayout_rightVinOrderContainer.Controls.Add(this.lbl_vin, 0, 0);
            this.tbllayout_rightVinOrderContainer.Controls.Add(this.lbl_orderNo, 1, 0);
            this.tbllayout_rightVinOrderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbllayout_rightVinOrderContainer.Location = new System.Drawing.Point(3, 3);
            this.tbllayout_rightVinOrderContainer.Name = "tbllayout_rightVinOrderContainer";
            this.tbllayout_rightVinOrderContainer.RowCount = 1;
            this.tbllayout_rightVinOrderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllayout_rightVinOrderContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tbllayout_rightVinOrderContainer.Size = new System.Drawing.Size(593, 134);
            this.tbllayout_rightVinOrderContainer.TabIndex = 0;
            // 
            // lbl_vin
            // 
            this.lbl_vin.AutoSize = true;
            this.lbl_vin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_vin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_vin.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.lbl_vin.ForeColor = System.Drawing.Color.White;
            this.lbl_vin.Location = new System.Drawing.Point(3, 0);
            this.lbl_vin.Name = "lbl_vin";
            this.lbl_vin.Size = new System.Drawing.Size(290, 134);
            this.lbl_vin.TabIndex = 0;
            this.lbl_vin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_orderNo
            // 
            this.lbl_orderNo.AutoSize = true;
            this.lbl_orderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_orderNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_orderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.lbl_orderNo.ForeColor = System.Drawing.Color.White;
            this.lbl_orderNo.Location = new System.Drawing.Point(299, 0);
            this.lbl_orderNo.Name = "lbl_orderNo";
            this.lbl_orderNo.Size = new System.Drawing.Size(291, 134);
            this.lbl_orderNo.TabIndex = 1;
            this.lbl_orderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_modelCode
            // 
            this.lbl_modelCode.AutoSize = true;
            this.lbl_modelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_modelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modelCode.Location = new System.Drawing.Point(3, 140);
            this.lbl_modelCode.Name = "lbl_modelCode";
            this.lbl_modelCode.Size = new System.Drawing.Size(593, 70);
            this.lbl_modelCode.TabIndex = 1;
            this.lbl_modelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_buildCard
            // 
            this.textbox_buildCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            this.textbox_buildCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_buildCard.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbox_buildCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_buildCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_buildCard.Location = new System.Drawing.Point(3, 213);
            this.textbox_buildCard.Name = "textbox_buildCard";
            this.textbox_buildCard.ReadOnly = true;
            this.textbox_buildCard.Size = new System.Drawing.Size(593, 484);
            this.textbox_buildCard.TabIndex = 2;
            this.textbox_buildCard.Text = "";
            this.textbox_buildCard.ZoomFactor = 1.5F;
            // 
            // notifIcon
            // 
            this.notifIcon.ContextMenuStrip = this.notifIconMenu;
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "RadioTrack Lineside";
            this.notifIcon.Visible = true;
            this.notifIcon.Click += new System.EventHandler(this.notifIcon_Click);
            this.notifIcon.DoubleClick += new System.EventHandler(this.notifIcon_DoubleClick);
            // 
            // notifIconMenu
            // 
            this.notifIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifIconMenu_title,
            this.notifIconMenu_thisStation,
            this.notifIconMenu_sep01,
            this.notifIconMenu_database,
            this.notifIconMenu_language,
            this.notifIconMenu_about,
            this.notifIconMenu_sep02,
            this.notifIconMenu_exit});
            this.notifIconMenu.Name = "contextMenuStrip1";
            this.notifIconMenu.Size = new System.Drawing.Size(185, 148);
            // 
            // notifIconMenu_title
            // 
            this.notifIconMenu_title.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.notifIconMenu_title.Enabled = false;
            this.notifIconMenu_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifIconMenu_title.Name = "notifIconMenu_title";
            this.notifIconMenu_title.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_title.Text = "RadioTrack Lineside";
            // 
            // notifIconMenu_thisStation
            // 
            this.notifIconMenu_thisStation.Enabled = false;
            this.notifIconMenu_thisStation.Name = "notifIconMenu_thisStation";
            this.notifIconMenu_thisStation.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_thisStation.Text = "Station:";
            // 
            // notifIconMenu_sep01
            // 
            this.notifIconMenu_sep01.Name = "notifIconMenu_sep01";
            this.notifIconMenu_sep01.Size = new System.Drawing.Size(181, 6);
            // 
            // notifIconMenu_database
            // 
            this.notifIconMenu_database.DropDown = this.databaseMenu;
            this.notifIconMenu_database.Name = "notifIconMenu_database";
            this.notifIconMenu_database.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_database.Text = "Database";
            // 
            // databaseMenu
            // 
            this.databaseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMenu_primary,
            this.databaseMenu_backup,
            this.toolStripSeparator1,
            this.databaseMenu_edit});
            this.databaseMenu.Name = "databaseMenu";
            this.databaseMenu.Size = new System.Drawing.Size(222, 98);
            this.databaseMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.databaseMenu_ItemClicked);
            // 
            // databaseMenu_primary
            // 
            this.databaseMenu_primary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.databaseMenu_primary.Name = "databaseMenu_primary";
            this.databaseMenu_primary.Size = new System.Drawing.Size(221, 22);
            this.databaseMenu_primary.Tag = "primary";
            this.databaseMenu_primary.Text = "Use Primary Database";
            // 
            // databaseMenu_backup
            // 
            this.databaseMenu_backup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.databaseMenu_backup.Name = "databaseMenu_backup";
            this.databaseMenu_backup.Size = new System.Drawing.Size(221, 22);
            this.databaseMenu_backup.Tag = "backup";
            this.databaseMenu_backup.Text = "Use Backup Database";
            // 
            // databaseMenu_edit
            // 
            this.databaseMenu_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.databaseMenu_edit.Name = "databaseMenu_edit";
            this.databaseMenu_edit.Size = new System.Drawing.Size(221, 22);
            this.databaseMenu_edit.Tag = "edit";
            this.databaseMenu_edit.Text = "Edit database connections...";
            // 
            // notifIconMenu_language
            // 
            this.notifIconMenu_language.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.notifIconMenu_language.DropDown = this.languageMenu;
            this.notifIconMenu_language.Name = "notifIconMenu_language";
            this.notifIconMenu_language.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_language.Text = "&Language";
            // 
            // languageMenu
            // 
            this.languageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langMenu_en,
            this.langMenu_de});
            this.languageMenu.Name = "languageMenu";
            this.languageMenu.OwnerItem = this.notifIconMenu_language;
            this.languageMenu.Size = new System.Drawing.Size(118, 48);
            this.languageMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.languageMenu_ItemClicked);
            // 
            // langMenu_en
            // 
            this.langMenu_en.Name = "langMenu_en";
            this.langMenu_en.Size = new System.Drawing.Size(117, 22);
            this.langMenu_en.Tag = "en";
            this.langMenu_en.Text = "English";
            // 
            // langMenu_de
            // 
            this.langMenu_de.Name = "langMenu_de";
            this.langMenu_de.Size = new System.Drawing.Size(117, 22);
            this.langMenu_de.Tag = "de";
            this.langMenu_de.Text = "Deutsch";
            // 
            // notifIconMenu_about
            // 
            this.notifIconMenu_about.Name = "notifIconMenu_about";
            this.notifIconMenu_about.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_about.Text = "&About";
            this.notifIconMenu_about.Click += new System.EventHandler(this.notifIconMenu_about_Click);
            // 
            // notifIconMenu_sep02
            // 
            this.notifIconMenu_sep02.Name = "notifIconMenu_sep02";
            this.notifIconMenu_sep02.Size = new System.Drawing.Size(181, 6);
            // 
            // notifIconMenu_exit
            // 
            this.notifIconMenu_exit.Name = "notifIconMenu_exit";
            this.notifIconMenu_exit.Size = new System.Drawing.Size(184, 22);
            this.notifIconMenu_exit.Text = "E&xit";
            this.notifIconMenu_exit.Click += new System.EventHandler(this.notifIconMenu_exit_Click);
            // 
            // scanTimer
            // 
            this.scanTimer.Interval = 250;
            this.scanTimer.Tick += new System.EventHandler(this.scanTimer_Tick);
            // 
            // taktTimer
            // 
            this.taktTimer.Enabled = true;
            this.taktTimer.Interval = 1000;
            this.taktTimer.Tick += new System.EventHandler(this.taktTimer_Tick);
            // 
            // usbConnCheckWorker
            // 
            this.usbConnCheckWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.usbConnCheckWorker_DoWork);
            this.usbConnCheckWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.usbConnCheckWorker_RunWorkerCompleted);
            // 
            // dbConnCheckWorker
            // 
            this.dbConnCheckWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dbConnCheckWorker_DoWork);
            this.dbConnCheckWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dbConnCheckWorker_RunWorkerCompleted);
            // 
            // rfidtrackDataSet
            // 
            this.rfidtrackDataSet.DataSetName = "rfidtrackDataSet";
            this.rfidtrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tbllayout_wholeWindow);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "form_Main";
            this.Text = "RadioTrack Lineside";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Main_FormClosing);
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.ClientSizeChanged += new System.EventHandler(this.form_Main_ClientSizeChanged);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tbllayout_wholeWindow.ResumeLayout(false);
            this.tbllayout_leftHalfWindow.ResumeLayout(false);
            this.tbllayout_leftHalfWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tblLayout_rightHalfWindow.ResumeLayout(false);
            this.tblLayout_rightHalfWindow.PerformLayout();
            this.tbllayout_rightVinOrderContainer.ResumeLayout(false);
            this.tbllayout_rightVinOrderContainer.PerformLayout();
            this.notifIconMenu.ResumeLayout(false);
            this.databaseMenu.ResumeLayout(false);
            this.languageMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rfidtrackDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status_statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel status_spring;
        private System.Windows.Forms.ToolStripStatusLabel status_readerStatus;
        private System.Windows.Forms.ToolStripStatusLabel status_databaseStatus;
        private System.Windows.Forms.ToolStripStatusLabel status_dateLabel;
        private System.Windows.Forms.ToolStripStatusLabel status_timeLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.TableLayoutPanel tbllayout_wholeWindow;
        private System.Windows.Forms.TableLayoutPanel tbllayout_leftHalfWindow;
        private System.Windows.Forms.Label lbl_thisStationLabel;
        private System.Windows.Forms.Label lbl_timestampLabel;
        private System.Windows.Forms.Label lbl_taktTimeLabel;
        private System.Windows.Forms.TableLayoutPanel tblLayout_rightHalfWindow;
        private System.Windows.Forms.TableLayoutPanel tbllayout_rightVinOrderContainer;
        private System.Windows.Forms.Label lbl_vin;
        private System.Windows.Forms.Label lbl_orderNo;
        private System.Windows.Forms.Label lbl_modelCode;
        private System.Windows.Forms.RichTextBox textbox_buildCard;
        private System.Windows.Forms.Label lbl_scanTime;
        private System.Windows.Forms.Label lbl_taktTime;
        private System.Windows.Forms.NotifyIcon notifIcon;
        private System.Windows.Forms.Timer scanTimer;
        private rfidtrackDataSet rfidtrackDataSet;
        private System.Windows.Forms.ComboBox cb_stationPicker;
        private System.Windows.Forms.Timer taktTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker usbConnCheckWorker;
        private System.ComponentModel.BackgroundWorker dbConnCheckWorker;
        private System.Windows.Forms.ContextMenuStrip notifIconMenu;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_language;
        private System.Windows.Forms.ContextMenuStrip languageMenu;
        private System.Windows.Forms.ToolStripMenuItem langMenu_en;
        private System.Windows.Forms.ToolStripMenuItem langMenu_de;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_title;
        private System.Windows.Forms.ToolStripSeparator notifIconMenu_sep01;
        private System.Windows.Forms.ToolStripSeparator notifIconMenu_sep02;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_exit;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_about;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_database;
        private System.Windows.Forms.ContextMenuStrip databaseMenu;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu_primary;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu_backup;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu_edit;
        private System.Windows.Forms.ToolStripMenuItem notifIconMenu_thisStation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

