using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace RadioTrack_ReaderClient
{
    public partial class db_editor : Form
    {
        string primaryConnStr;
        string backupConnStr;

        public db_editor()
        {
            InitializeComponent();
        }

        private void db_editor_Load(object sender, EventArgs e)
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            try { primaryConnStr = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_primary"].ConnectionString; }
            catch (Exception ex) { }
            try { backupConnStr = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_backup"].ConnectionString; }
            catch (Exception ex) { }

            // Populate textboxes with existing data
            
            // Primary
            MySqlConnectionStringBuilder builder_p = new MySqlConnectionStringBuilder(primaryConnStr);
            tb_server_p.Text = builder_p.Server;
            if (builder_p.Port != 3306) tb_port_p.Text = builder_p.Port.ToString();
            tb_dbname_p.Text = builder_p.Database;
            tb_username_p.Text = builder_p.UserID;
            tb_password_p.Text = builder_p.Password;

            // Backup
            MySqlConnectionStringBuilder builder_b = new MySqlConnectionStringBuilder(backupConnStr);
            tb_server_b.Text = builder_b.Server;
            if (builder_b.Port != 3306) tb_port_b.Text = builder_b.Port.ToString();
            tb_dbname_b.Text = builder_b.Database;
            tb_username_b.Text = builder_b.UserID;
            tb_password_b.Text = builder_b.Password;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Default port for MySQL is 3306
            uint defaultPort = 3306;

            // Save the new values
            MySqlConnectionStringBuilder builder_p = new MySqlConnectionStringBuilder();
            builder_p.Server = tb_server_p.Text.Trim();
            if (!String.IsNullOrWhiteSpace(tb_port_p.Text)) builder_p.Port = uint.Parse(tb_port_p.Text);
            else builder_p.Port = defaultPort;
            builder_p.Database = tb_dbname_p.Text.Trim();
            builder_p.UserID = tb_username_p.Text.Trim();
            builder_p.Password = tb_password_p.Text.Trim();

            MySqlConnectionStringBuilder builder_b = new MySqlConnectionStringBuilder();
            builder_b.Server = tb_server_b.Text.Trim();
            if (!String.IsNullOrWhiteSpace(tb_port_b.Text)) builder_b.Port = uint.Parse(tb_port_b.Text);
            else builder_b.Port = defaultPort;
            builder_b.Database = tb_dbname_b.Text.Trim();
            builder_b.UserID = tb_username_b.Text.Trim();
            builder_b.Password = tb_password_b.Text.Trim();

            save(builder_p.GetConnectionString(true), builder_b.GetConnectionString(true));
            this.Close();
        }

        private void save(string primaryConnStr, string backupConnStr)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var pConfig = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_primary"];
            var bConfig = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_backup"];
            
            if(!String.IsNullOrWhiteSpace(primaryConnStr)) pConfig.ConnectionString = primaryConnStr;
            if(!String.IsNullOrWhiteSpace(backupConnStr)) bConfig.ConnectionString = backupConnStr;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
