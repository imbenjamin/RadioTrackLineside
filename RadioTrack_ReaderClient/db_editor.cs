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

        // Default port for MySQL is 3306
        uint defaultPort = 3306;

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

        // Cancel button clicked
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save button clicked
        private void btn_save_Click(object sender, EventArgs e)
        {
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

            Exception ex_p;
            Exception ex_b;
            if (validateConnection(builder_p, out ex_p))
            {
                if (validateConnection(builder_b, out ex_b))
                {
                    save(builder_p.GetConnectionString(true), builder_b.GetConnectionString(true));
                    this.Close();
                }
                else MessageBox.Show("There is a problem with the backup connection configuration!" + Environment.NewLine + "Please verify that the configuration entered is correct." + Environment.NewLine + Environment.NewLine + "(" + ex_b.Message + ")", "Backup Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("There is a problem with the primary connection configuration!" + Environment.NewLine + "Please verify that the configuration entered is correct." + Environment.NewLine + Environment.NewLine + "(" + ex_p.Message + ")", "Primary Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Save the given configurations to the application settings
        /// </summary>
        /// <param name="primaryConnStr">generated primary connection string</param>
        /// <param name="backupConnStr">generated backup connection string</param>
        private void save(string primaryConnStr, string backupConnStr)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var pConfig = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_primary"];
            var bConfig = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_backup"];

            if (!String.IsNullOrWhiteSpace(primaryConnStr)) pConfig.ConnectionString = primaryConnStr;
            if (!String.IsNullOrWhiteSpace(backupConnStr)) bConfig.ConnectionString = backupConnStr;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        /// <summary>
        /// Validate that a connection configuration is valid (connects to the database)
        /// </summary>
        /// <param name="ConnStrBuilder">The MySqlConnectionStringBuilder object of a connection configuration</param>
        /// <param name="error">Returns a MySqlException if an exception is thrown</param>
        /// <returns>true = configuration is valid</returns>
        private bool validateConnection(MySqlConnectionStringBuilder ConnStrBuilder, out Exception error)
        {
            error = (Exception)null;
            if (!String.IsNullOrWhiteSpace(ConnStrBuilder.Server) && !String.IsNullOrWhiteSpace(ConnStrBuilder.Database) && !String.IsNullOrWhiteSpace(ConnStrBuilder.UserID) && !String.IsNullOrWhiteSpace(ConnStrBuilder.Password))
            {
                bool result = false;
                try
                {
                    string ConnStr = ConnStrBuilder.GetConnectionString(true);
                    MySqlConnection conn = new MySqlConnection(ConnStr);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    result = conn.Ping();
                    if (conn.State == ConnectionState.Open) conn.Open();
                }
                catch (Exception ex)
                {
                    error = ex;
                }
                return result;
            }
            else
            { return true; }
        }

        // Validate the 'Port' fields for a valid int between 1 and 65535
        #region Port Validating
        private void tb_port_p_Validating(object sender, CancelEventArgs e)
        {
            // Validates port to contains a number between 1 and 65535
            TextBox tb = (TextBox)sender;

            if (!String.IsNullOrWhiteSpace(tb.Text))
            {
                try { validatePort(tb); }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    tb.Select(0, tb.Text.Length);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                tb.Text = defaultPort.ToString();
        }

        private void tb_port_b_Validating(object sender, CancelEventArgs e)
        {
            // Validates port to contains a number between 1 and 65535
            TextBox tb = (TextBox)sender;

            if (!String.IsNullOrWhiteSpace(tb.Text))
            {
                try { validatePort(tb); }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    tb.Select(0, tb.Text.Length);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                tb.Text = defaultPort.ToString();
        }

        private void validatePort(TextBox tb)
        {
            int port;
            if (!int.TryParse(tb.Text, out port))
            {
                throw new FormatException("The Port you have entered must be a number", (Exception)null);
            }
            else
            {
                if (!(port >= 1 && port <= 65535))
                {
                    throw new ArgumentOutOfRangeException("The Port must be between 1 and 65535", (Exception)null);
                }
            }
        }
        #endregion
    }
}
