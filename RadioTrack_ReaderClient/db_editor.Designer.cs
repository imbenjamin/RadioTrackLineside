namespace RadioTrack_ReaderClient
{
    partial class db_editor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tabControl_connections = new System.Windows.Forms.TabControl();
            this.tab_primary = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_server_p = new System.Windows.Forms.Label();
            this.lbl_dbname_p = new System.Windows.Forms.Label();
            this.lbl_username_p = new System.Windows.Forms.Label();
            this.lbl_password_p = new System.Windows.Forms.Label();
            this.tb_dbname_p = new System.Windows.Forms.TextBox();
            this.tb_username_p = new System.Windows.Forms.TextBox();
            this.tb_password_p = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_server_p = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port_p = new System.Windows.Forms.TextBox();
            this.tab_backup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_server_b = new System.Windows.Forms.Label();
            this.lbl_dbname_b = new System.Windows.Forms.Label();
            this.lbl_username_b = new System.Windows.Forms.Label();
            this.lbl_password_b = new System.Windows.Forms.Label();
            this.tb_dbname_b = new System.Windows.Forms.TextBox();
            this.tb_username_b = new System.Windows.Forms.TextBox();
            this.tb_password_b = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_server_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_port_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl_connections.SuspendLayout();
            this.tab_primary.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tab_backup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl_connections, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 269);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(368, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cancel.Location = new System.Drawing.Point(290, 8);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.Location = new System.Drawing.Point(209, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tabControl_connections
            // 
            this.tabControl_connections.Controls.Add(this.tab_primary);
            this.tabControl_connections.Controls.Add(this.tab_backup);
            this.tabControl_connections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_connections.Location = new System.Drawing.Point(3, 39);
            this.tabControl_connections.Name = "tabControl_connections";
            this.tabControl_connections.SelectedIndex = 0;
            this.tabControl_connections.Size = new System.Drawing.Size(368, 224);
            this.tabControl_connections.TabIndex = 1;
            // 
            // tab_primary
            // 
            this.tab_primary.Controls.Add(this.tableLayoutPanel3);
            this.tab_primary.Location = new System.Drawing.Point(4, 22);
            this.tab_primary.Name = "tab_primary";
            this.tab_primary.Padding = new System.Windows.Forms.Padding(3);
            this.tab_primary.Size = new System.Drawing.Size(360, 234);
            this.tab_primary.TabIndex = 0;
            this.tab_primary.Text = "Primary Connection";
            this.tab_primary.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_server_p, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_dbname_p, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_username_p, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_password_p, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tb_dbname_p, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_username_p, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_password_p, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(354, 228);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_server_p
            // 
            this.lbl_server_p.AutoSize = true;
            this.lbl_server_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_server_p.Location = new System.Drawing.Point(3, 0);
            this.lbl_server_p.Name = "lbl_server_p";
            this.lbl_server_p.Size = new System.Drawing.Size(100, 45);
            this.lbl_server_p.TabIndex = 0;
            this.lbl_server_p.Text = "Server:";
            this.lbl_server_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dbname_p
            // 
            this.lbl_dbname_p.AutoSize = true;
            this.lbl_dbname_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dbname_p.Location = new System.Drawing.Point(3, 45);
            this.lbl_dbname_p.Name = "lbl_dbname_p";
            this.lbl_dbname_p.Size = new System.Drawing.Size(100, 45);
            this.lbl_dbname_p.TabIndex = 1;
            this.lbl_dbname_p.Text = "Database Name:";
            this.lbl_dbname_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_username_p
            // 
            this.lbl_username_p.AutoSize = true;
            this.lbl_username_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_username_p.Location = new System.Drawing.Point(3, 135);
            this.lbl_username_p.Name = "lbl_username_p";
            this.lbl_username_p.Size = new System.Drawing.Size(100, 45);
            this.lbl_username_p.TabIndex = 3;
            this.lbl_username_p.Text = "Username:";
            this.lbl_username_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_password_p
            // 
            this.lbl_password_p.AutoSize = true;
            this.lbl_password_p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_password_p.Location = new System.Drawing.Point(3, 180);
            this.lbl_password_p.Name = "lbl_password_p";
            this.lbl_password_p.Size = new System.Drawing.Size(100, 48);
            this.lbl_password_p.TabIndex = 4;
            this.lbl_password_p.Text = "Password:";
            this.lbl_password_p.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_dbname_p
            // 
            this.tb_dbname_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_dbname_p.Location = new System.Drawing.Point(109, 57);
            this.tb_dbname_p.Name = "tb_dbname_p";
            this.tb_dbname_p.Size = new System.Drawing.Size(200, 20);
            this.tb_dbname_p.TabIndex = 6;
            // 
            // tb_username_p
            // 
            this.tb_username_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_username_p.Location = new System.Drawing.Point(109, 147);
            this.tb_username_p.Name = "tb_username_p";
            this.tb_username_p.Size = new System.Drawing.Size(200, 20);
            this.tb_username_p.TabIndex = 7;
            // 
            // tb_password_p
            // 
            this.tb_password_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_password_p.Location = new System.Drawing.Point(109, 194);
            this.tb_password_p.Name = "tb_password_p";
            this.tb_password_p.Size = new System.Drawing.Size(200, 20);
            this.tb_password_p.TabIndex = 8;
            this.tb_password_p.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Controls.Add(this.tb_server_p, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_port_p, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(109, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(242, 39);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // tb_server_p
            // 
            this.tb_server_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_server_p.Location = new System.Drawing.Point(3, 9);
            this.tb_server_p.Name = "tb_server_p";
            this.tb_server_p.Size = new System.Drawing.Size(115, 20);
            this.tb_server_p.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(124, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_port_p
            // 
            this.tb_port_p.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_port_p.Location = new System.Drawing.Point(172, 9);
            this.tb_port_p.Name = "tb_port_p";
            this.tb_port_p.Size = new System.Drawing.Size(67, 20);
            this.tb_port_p.TabIndex = 2;
            this.tb_port_p.Text = "3306";
            // 
            // tab_backup
            // 
            this.tab_backup.Controls.Add(this.tableLayoutPanel4);
            this.tab_backup.Location = new System.Drawing.Point(4, 22);
            this.tab_backup.Name = "tab_backup";
            this.tab_backup.Padding = new System.Windows.Forms.Padding(3);
            this.tab_backup.Size = new System.Drawing.Size(360, 198);
            this.tab_backup.TabIndex = 1;
            this.tab_backup.Text = "Backup Connection";
            this.tab_backup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_server_b, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_dbname_b, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_username_b, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_password_b, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tb_dbname_b, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tb_username_b, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_password_b, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(354, 192);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbl_server_b
            // 
            this.lbl_server_b.AutoSize = true;
            this.lbl_server_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_server_b.Location = new System.Drawing.Point(3, 0);
            this.lbl_server_b.Name = "lbl_server_b";
            this.lbl_server_b.Size = new System.Drawing.Size(100, 38);
            this.lbl_server_b.TabIndex = 0;
            this.lbl_server_b.Text = "Server:";
            this.lbl_server_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dbname_b
            // 
            this.lbl_dbname_b.AutoSize = true;
            this.lbl_dbname_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dbname_b.Location = new System.Drawing.Point(3, 38);
            this.lbl_dbname_b.Name = "lbl_dbname_b";
            this.lbl_dbname_b.Size = new System.Drawing.Size(100, 38);
            this.lbl_dbname_b.TabIndex = 1;
            this.lbl_dbname_b.Text = "Database Name:";
            this.lbl_dbname_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_username_b
            // 
            this.lbl_username_b.AutoSize = true;
            this.lbl_username_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_username_b.Location = new System.Drawing.Point(3, 114);
            this.lbl_username_b.Name = "lbl_username_b";
            this.lbl_username_b.Size = new System.Drawing.Size(100, 38);
            this.lbl_username_b.TabIndex = 3;
            this.lbl_username_b.Text = "Username:";
            this.lbl_username_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_password_b
            // 
            this.lbl_password_b.AutoSize = true;
            this.lbl_password_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_password_b.Location = new System.Drawing.Point(3, 152);
            this.lbl_password_b.Name = "lbl_password_b";
            this.lbl_password_b.Size = new System.Drawing.Size(100, 40);
            this.lbl_password_b.TabIndex = 4;
            this.lbl_password_b.Text = "Password:";
            this.lbl_password_b.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_dbname_b
            // 
            this.tb_dbname_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_dbname_b.Location = new System.Drawing.Point(109, 47);
            this.tb_dbname_b.Name = "tb_dbname_b";
            this.tb_dbname_b.Size = new System.Drawing.Size(200, 20);
            this.tb_dbname_b.TabIndex = 6;
            // 
            // tb_username_b
            // 
            this.tb_username_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_username_b.Location = new System.Drawing.Point(109, 123);
            this.tb_username_b.Name = "tb_username_b";
            this.tb_username_b.Size = new System.Drawing.Size(200, 20);
            this.tb_username_b.TabIndex = 7;
            // 
            // tb_password_b
            // 
            this.tb_password_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_password_b.Location = new System.Drawing.Point(109, 162);
            this.tb_password_b.Name = "tb_password_b";
            this.tb_password_b.Size = new System.Drawing.Size(200, 20);
            this.tb_password_b.TabIndex = 8;
            this.tb_password_b.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Controls.Add(this.tb_server_b, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tb_port_b, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(109, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(242, 32);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // tb_server_b
            // 
            this.tb_server_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_server_b.Location = new System.Drawing.Point(3, 6);
            this.tb_server_b.Name = "tb_server_b";
            this.tb_server_b.Size = new System.Drawing.Size(115, 20);
            this.tb_server_b.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(124, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_port_b
            // 
            this.tb_port_b.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_port_b.Location = new System.Drawing.Point(172, 6);
            this.tb_port_b.Name = "tb_port_b";
            this.tb_port_b.Size = new System.Drawing.Size(67, 20);
            this.tb_port_b.TabIndex = 2;
            this.tb_port_b.Text = "3306";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(368, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "View and modify the database connection settings here.\r\nIf the \'Port\' field is le" +
    "ft blank, the default value of 3306 will be used.";
            // 
            // db_editor
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(374, 306);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "db_editor";
            this.Text = "Edit Database Connections";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.db_editor_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl_connections.ResumeLayout(false);
            this.tab_primary.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tab_backup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TabControl tabControl_connections;
        private System.Windows.Forms.TabPage tab_primary;
        private System.Windows.Forms.TabPage tab_backup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_server_p;
        private System.Windows.Forms.Label lbl_dbname_p;
        private System.Windows.Forms.Label lbl_username_p;
        private System.Windows.Forms.Label lbl_password_p;
        private System.Windows.Forms.TextBox tb_dbname_p;
        private System.Windows.Forms.TextBox tb_username_p;
        private System.Windows.Forms.TextBox tb_password_p;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_server_b;
        private System.Windows.Forms.Label lbl_dbname_b;
        private System.Windows.Forms.Label lbl_username_b;
        private System.Windows.Forms.Label lbl_password_b;
        private System.Windows.Forms.TextBox tb_dbname_b;
        private System.Windows.Forms.TextBox tb_username_b;
        private System.Windows.Forms.TextBox tb_password_b;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox tb_server_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port_p;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox tb_server_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_port_b;
        private System.Windows.Forms.Label label3;
    }
}