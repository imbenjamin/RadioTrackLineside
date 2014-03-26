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
using RFIDeas_pcProxAPI;
using System.Diagnostics;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Security.Principal;

namespace RadioTrack_ReaderClient
{
    public partial class form_Main : Form
    {
        static string rfidtrackConnStr = Properties.Settings.Default.databaseConnStr_primary;
        MySqlConnection dbConn = new MySqlConnection(rfidtrackConnStr);

        // Resource Manager for languages
        ResourceManager resMan;
        CultureInfo culture;

        bool dbConnectionOk = false;
        bool readerConnectionOk = false;
        bool allStatusOk = false;
        bool firstConnect = true;
        bool dbHasConnectedOnce = false;
        bool readerHasConnectedOnce = false;
        long lastCardScanned = 0;
        Stopwatch taktStopwatch = new Stopwatch();

        DateTime clock = DateTime.Now;

        public form_Main()
        {
            InitializeComponent();
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            // Get the language to use
            resMan = new ResourceManager("RadioTrack_ReaderClient.Resources.lang", typeof(form_Main).Assembly);
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.defaultLanguage))
            {
                // A language default has been set
                setLanguage(Properties.Settings.Default.defaultLanguage);
            }
            else
            {
                // A language has not been set, default to English
                culture = CultureInfo.CreateSpecificCulture("en");
                langMenu_en.Checked = true;
                langMenu_de.Checked = false;
                applyUiLanguage();
            }

            // Get the database connection to use
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.defaultDatabase))
            {
                // A default has been set
                setDatabaseConn(Properties.Settings.Default.defaultDatabase);
            }
            else
            {
                // A connection has not been set, default to Primary
                setDatabaseConn("primary");
            }
            if (!isUserAdministrator())
            {
                databaseMenu_edit.Enabled = false;
                databaseMenu_edit.ToolTipText = "Administrator Access Required";
            }

            // Initial clock set
            status_dateLabel.Text = clock.ToShortDateString();
            status_timeLabel.Text = clock.ToShortTimeString();

            cb_stationPicker.Items.Add(resMan.GetString("misc_please_wait", culture));
            cb_stationPicker.SelectedIndex = 0;
        }

        private void setDatabaseConn(string connToUse)
        {
            ConfigurationManager.RefreshSection("connectionStrings");
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            switch (connToUse)
            {
                case "primary":
                    rfidtrackConnStr = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_primary"].ConnectionString;
                    dbConn = new MySqlConnection(rfidtrackConnStr);
                    databaseMenu_primary.Checked = true;
                    databaseMenu_backup.Checked = false;
                    break;
                
                case "backup":
                    try
                    {
                        rfidtrackConnStr = config.ConnectionStrings.ConnectionStrings["RadioTrack_ReaderClient.Properties.Settings.databaseConnStr_backup"].ConnectionString;
                        dbConn = new MySqlConnection(rfidtrackConnStr);
                        databaseMenu_primary.Checked = false;
                        databaseMenu_backup.Checked = true;
                    }
                    catch (NullReferenceException ex) { MessageBox.Show("A Backup database connection has not been set.", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    catch (Exception ex) { }
                    break;
            }
        }

        private void setLanguage(string langCode)
        {
            culture = CultureInfo.CreateSpecificCulture(langCode);

            Properties.Settings.Default.defaultLanguage = langCode;
            Properties.Settings.Default.Save();

            switch (langCode)
            {
                case "en":
                    langMenu_en.Checked = true;
                    langMenu_de.Checked = false;
                    break;
                case "de":
                    langMenu_de.Checked = true;
                    langMenu_en.Checked = false;
                    break;
            }

            applyUiLanguage();
        }

        private void applyUiLanguage()
        {
            lbl_thisStationLabel.Text = resMan.GetString("label_this_station", culture);
            lbl_timestampLabel.Text = resMan.GetString("label_vehicle_registered_at", culture);
            lbl_taktTimeLabel.Text = resMan.GetString("label_this_takt", culture);

            status_statusLabel.Text = resMan.GetString("status_waiting_for_connections", culture);
            status_readerStatus.Text = resMan.GetString("status_connecting_to_reader", culture);
            status_databaseStatus.Text = resMan.GetString("status_connecting_to_database", culture);

            notifIconMenu_database.Text = resMan.GetString("dbmenu_database", culture);
            notifIconMenu_language.Text = resMan.GetString("lang_language", culture);
            notifIconMenu_exit.Text = resMan.GetString("misc_exit", culture);
            notifIconMenu_about.Text = resMan.GetString("misc_about", culture);
            databaseMenu_primary.Text = resMan.GetString("dbmenu_use_primary_database", culture);
            databaseMenu_backup.Text = resMan.GetString("dbmenu_use_backup_database", culture);
            databaseMenu_edit.Text = resMan.GetString("dbmenu_edit_database_connections", culture);
            langMenu_en.Text = resMan.GetString("lang_english", culture);
            langMenu_de.Text = resMan.GetString("lang_german", culture);

        }

        private void allStatusToggle(bool newStatus)
        {
            switch (newStatus)
            {
                case true:
                    // Good to go!
                    allStatusOk = true;
                    status_statusLabel.Text = resMan.GetString("status_ready", culture);

                    break;

                case false:
                    // Something wrong!
                    allStatusOk = false;
                    status_statusLabel.Text = resMan.GetString("status_waiting_for_connections", culture);

                    break;
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            // Update time
            clock = DateTime.Now;
            status_dateLabel.Text = clock.ToShortDateString();
            status_timeLabel.Text = clock.ToShortTimeString();

            // Check Database connection in a background thread
            if (!dbConnCheckWorker.IsBusy)
            {
                // Get the database connection to use
                if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.defaultDatabase))
                {
                    // A default has been set
                    setDatabaseConn(Properties.Settings.Default.defaultDatabase);
                }
                else
                {
                    // A connection has not been set, default to Primary
                    setDatabaseConn("primary");
                }
                dbConn = new MySqlConnection(rfidtrackConnStr);
                dbConnCheckWorker.RunWorkerAsync(dbConn);
            }

            // Check Reader connection in a background thread
            if (!usbConnCheckWorker.IsBusy)
                usbConnCheckWorker.RunWorkerAsync();

            if (firstConnect && dbHasConnectedOnce && readerHasConnectedOnce) firstConnect = false;
        }

        #region Notification Icon
        private void notifIcon_Click(object sender, EventArgs e)
        {
            this.Activate();           
        }

        private void notifIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Activate();
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        private void scanTimer_Tick(object sender, EventArgs e)
        {
            int nBits = pcProxDLLAPI.getActiveID(8);

            if (nBits > 0)
            {
                // Card is present

                long decId = getCardId();

                // Test to see if the ID is the same
                // (Can read a single card multiple times with several Ticks of the timer)
                if (lastCardScanned == decId)
                {
                    // Duplicate scan
                    status_statusLabel.Text = String.Format(resMan.GetString("status_scanned_duplicate", culture), decId.ToString());
                    // textbox_buildCard.AppendText("\nDuplicate card scanned");
                }
                else
                {
                    // New card scanned
                    lastCardScanned = decId;

                    parseCard(decId);
                    
                    // MessageBox.Show(decId.ToString());
                }
            }
            else
            {
                // Card is not present
                // (Do Nothing)
            }
        }

        private long getCardId()
        {
            string rawId = "";
            Byte[] id = new Byte[8];

            // Read the bytes
            for (short i = 0; i < 8; i++)
                id[i] = pcProxDLLAPI.getActiveID_byte(i);

            // For some reason, bytes are backwards?
            // So, reverse the array
            Array.Reverse(id);

            // Translate to a string format to be converted
            foreach (Byte idByte in id)
                rawId += String.Format("{0:X2}", idByte);

            // Convert the Hex number to a (long) Dec
            long decId = long.Parse(rawId, System.Globalization.NumberStyles.HexNumber);

            return decId;
        }

        private void parseCard(long cardId)
        {
            string vehicleVin = "";
            string vehicleOrderNo = "";
            string stationId = cb_stationPicker.SelectedValue.ToString();
            DateTime timestamp = DateTime.Now;
            ArrayList buildConfigList = new ArrayList();
            status_statusLabel.Text = String.Format(resMan.GetString("status_scanned", culture), cardId.ToString());
            lbl_scanTime.Text = timestamp.ToString("HH:mm:ss");

            // Get vehicle info
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string query = "SELECT t.vehicle_vin, v.vehicle_orderno, v.vehicle_modelCode, v.vehicle_buildConfiguration FROM vehicle_tags t LEFT JOIN vehicles v ON t.vehicle_vin = v.vehicle_vin WHERE t.rfidtag_id = @rfid";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            cmd.Parameters.AddWithValue("rfid", cardId.ToString());

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                taktStopwatch.Restart();

                while (reader.Read())
                {
                    vehicleVin = reader["vehicle_vin"].ToString();
                    vehicleOrderNo = reader["vehicle_orderno"].ToString();
                    lbl_modelCode.Text = reader["vehicle_modelCode"].ToString();

                    foreach (string code in reader["vehicle_buildConfiguration"].ToString().Split(';'))
                        buildConfigList.Add(code);
                }
            }

            if (dbConn.State == ConnectionState.Open)
                dbConn.Close();

            lbl_vin.Text = vehicleVin;
            lbl_orderNo.Text = vehicleOrderNo;
            displayBuildCard((string[])buildConfigList.ToArray(typeof(string)));

            // Finally, update Database with new vehicle
            //if (!submitStationRegister(vehicleVin, cardId.ToString(), stationId, timestamp))
            //    MessageBox.Show("Failed to update the database with the new vehicle!", "Error updating Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Uncomment lines to submit to database!", "Commit to database", MessageBoxButtons.OK);
        }

        private void displayBuildCard(string[] configList)
        {
            textbox_buildCard.Text = resMan.GetString("misc_build_configuration", culture) + "\u2028\u2029";

            foreach (string code in configList)
            {
                if (code == "---") textbox_buildCard.AppendText("\u2029");
                else
                {
                    string desc = getConfigDescFromCode(code);
                    textbox_buildCard.AppendText(code + "\u0009\u0009" + desc + "\u2028");
                }
            }
        }

        private string getConfigDescFromCode(string code)
        {
            string result = resMan.GetString("misc_description_not_found", culture);

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            string query = "SELECT config_desc FROM buildconfig_codes WHERE config_code = @cid";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            cmd.Parameters.AddWithValue("cid", code);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                    result = reader["config_desc"].ToString();
            }

            if (dbConn.State == ConnectionState.Open)
                dbConn.Close();

            return result;
        }

        private void taktTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan time = taktStopwatch.Elapsed;
            lbl_taktTime.Text = time.Hours.ToString("00") + ":" + time.Minutes.ToString("00") + ":" + time.Seconds.ToString("00");
        }

        #region Background Workers
        private void usbConnCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool result = false;

            // Only attempt to connect if the reader is actually disconnected
            if (pcProxDLLAPI.USBDisconnect() == 1)
            {
                int rc = pcProxDLLAPI.usbConnect();
                if (rc == 1)
                {
                    result = true;

                    string tooltipString = String.Format(resMan.GetString("status_reader_connected_to", culture), pcProxDLLAPI.GetDID().ToString(), pcProxDLLAPI.getPartNumberString());
                    if (status_readerStatus.ToolTipText != tooltipString)
                        status_readerStatus.ToolTipText = tooltipString;
                }
                else
                {
                    string tooltipString = "";
                    if (status_readerStatus.ToolTipText != tooltipString)
                        status_readerStatus.ToolTipText = tooltipString;
                }
            }
            e.Result = result;
        }

        private void usbConnCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                if (readerConnectionOk == false && !firstConnect) notifIcon.ShowBalloonTip(5000, resMan.GetString("notificon_reader_connected_title", culture), resMan.GetString("notificon_reader_connected_text", culture), ToolTipIcon.Info);
                readerConnectionOk = true;
            }
            else
            {
                if (readerConnectionOk == true) notifIcon.ShowBalloonTip(5000, resMan.GetString("notificon_reader_disconnected_title", culture), resMan.GetString("notificon_reader_disconnected_text", culture), ToolTipIcon.Error);
                readerConnectionOk = false;
            }

            if (readerConnectionOk)
            {
                if (!readerHasConnectedOnce) readerHasConnectedOnce = true;
                status_readerStatus.Text = resMan.GetString("status_reader_connected", culture);
                status_readerStatus.BackColor = Color.LightGreen;
                scanTimer.Start();
            }
            else
            {
                status_readerStatus.Text = resMan.GetString("status_reader_disconnected", culture);
                status_readerStatus.BackColor = Color.Tomato;
                scanTimer.Stop();
            }

            if (dbConnectionOk && readerConnectionOk)
                allStatusToggle(true);
            else
                allStatusToggle(false);

            
        }

        private void dbConnCheckWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            MySqlConnection connection = (MySqlConnection)e.Argument;
            bool result = false;

            try
            {
                if (connection.State == ConnectionState.Closed)
                    dbConn.Open();

                if (connection.Ping())
                {
                    result = true;
                    if (status_databaseStatus.ToolTipText != String.Format(resMan.GetString("status_database_connected_to", culture), dbConn.Database))
                        status_databaseStatus.ToolTipText = String.Format(resMan.GetString("status_database_connected_to", culture), dbConn.Database);
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                if (status_databaseStatus.ToolTipText != String.Format(resMan.GetString("status_connection_error", culture), ex.Message))
                    status_databaseStatus.ToolTipText = String.Format(resMan.GetString("status_connection_error", culture), ex.Message);
            }

            e.Result = result;
        }

        private void dbConnCheckWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                if (dbConnectionOk == false && !firstConnect) notifIcon.ShowBalloonTip(5000, resMan.GetString("notificon_database_connected_title", culture), resMan.GetString("notificon_database_connected_text", culture), ToolTipIcon.Info);
                dbConnectionOk = true;
            }
            else
            {
                if (dbConnectionOk == true) notifIcon.ShowBalloonTip(5000, resMan.GetString("notificon_database_disconnected_title", culture), resMan.GetString("notificon_database_disconnected_text", culture), ToolTipIcon.Error);
                dbConnectionOk = false;
            }

            if (dbConnectionOk)
            {
                status_databaseStatus.Text = resMan.GetString("status_database_connected", culture);
                status_databaseStatus.BackColor = Color.LightGreen;
                if (!dbHasConnectedOnce)
                {
                    // Populate Station drop-down

                    if (dbConn.State == ConnectionState.Closed)
                        dbConn.Open();

                    string query = "SELECT * FROM rfid_stations";

                    MySqlCommand cmd = new MySqlCommand(query, dbConn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    var stations = new Dictionary<string, string>();

                    while (reader.Read())
                    {
                        stations.Add(reader["station_id"].ToString(), reader["station_desc"].ToString());
                    }

                    var stationsList = stations.ToList();
                    cb_stationPicker.ValueMember = "Key";
                    cb_stationPicker.DisplayMember = "Value";
                    cb_stationPicker.DataSource = stationsList;

                    cb_stationPicker.SelectedIndex = 0;

                    if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.thisStation))
                    {
                        if (Properties.Settings.Default.thisStation != cb_stationPicker.SelectedValue.ToString())
                        {
                            status_statusLabel.Text = String.Format(resMan.GetString("status_applying_saved_station", culture), Properties.Settings.Default.thisStation);
                            try
                            {
                                cb_stationPicker.SelectedValue = Properties.Settings.Default.thisStation;
                                notifIcon.Text = String.Format("RadioTrack Lineside ({0})", Properties.Settings.Default.thisStation);
                                notifIconMenu_thisStation.Text = String.Format("Station: {0}", Properties.Settings.Default.thisStation);
                            }
                            catch (Exception ex) { status_statusLabel.Text = String.Format(resMan.GetString("status_applying_saved_station_error", culture), ex.Message); }
                        }
                    }

                    reader.Close();
                    if (dbConn.State == ConnectionState.Open)
                        dbConn.Close();
                }
                if (!dbHasConnectedOnce) dbHasConnectedOnce = true;

            }
            else
            {
                status_databaseStatus.Text = resMan.GetString("status_database_disconnected", culture);
                status_databaseStatus.BackColor = Color.Tomato;
            }
        }
        #endregion

        // Station has been changed by user
        private void cb_stationPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string station = cb_stationPicker.SelectedValue.ToString();
            Properties.Settings.Default.thisStation = station;
            Properties.Settings.Default.Save();
            status_statusLabel.Text = String.Format(resMan.GetString("status_station_successfully_saved", culture), station);
            notifIcon.Text = String.Format("RadioTrack Lineside ({0})", station);
            notifIconMenu_thisStation.Text = String.Format("Station: {0}", station);
        }

        #region Notification Icon handlers
        private void languageMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem itemClicked = e.ClickedItem;
            string lang = (string)itemClicked.Tag;

            setLanguage(lang);
        }

        private void notifIconMenu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(resMan.GetString("misc_exit_confirmation_text", culture), resMan.GetString("misc_exit_confirmation_title", culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void notifIconMenu_about_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
                about.ShowDialog(this);
        }

        private void databaseMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem itemClicked = e.ClickedItem;
            string tag = (string)itemClicked.Tag;

            if (tag == "edit")
            {
                // Edit connections
                if (isUserAdministrator())
                {
                    db_editor dbeditor = new db_editor();
                    dbeditor.Show();
                }

            }
            else
            {
                setDatabaseConn(tag);
            }
        }
        #endregion

        private void form_Main_ClientSizeChanged(object sender, EventArgs e)
        {
            taktTimer.Enabled = true;
            this.Update();
        }

        private bool isUserAdministrator()
        {
            WindowsIdentity user = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(user);
            bool result = principal.IsInRole(WindowsBuiltInRole.Administrator);
            return result;
        }

        private bool submitStationRegister(string vin, string rfidId, string newStationId, DateTime newTimestamp)
        {
            bool pass = false;
            string oldHist = "";
            string oldStationId = "";
            string oldTimestamp = "";
            string newHist = "";

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            // First get the old station history string
            string sqlGetHist = "SELECT stationhistory, station_id, timestamp FROM vehicle_tags WHERE (rfidtag_id=@rfid AND vehicle_vin=@vin)";
            MySqlCommand cmdGetHist = new MySqlCommand(sqlGetHist, dbConn);
            cmdGetHist.Parameters.AddWithValue("rfid", rfidId);
            cmdGetHist.Parameters.AddWithValue("vin", vin);
            cmdGetHist.Prepare();
            MySqlDataReader readerGetHist = cmdGetHist.ExecuteReader();
            while (readerGetHist.Read())
            {
                oldHist = readerGetHist["stationhistory"].ToString();
                oldStationId = readerGetHist["station_id"].ToString();
                oldTimestamp = readerGetHist["timestamp"].ToString();
            }
            readerGetHist.Close();

            // Update the station history string
            newHist = String.Format("{0};{1},{2}", oldHist, oldStationId, oldTimestamp);

            // Now update the vehicle_tags table with the new station, timestamp and station history
            string sql = "UPDATE vehicle_tags SET station_id=@stId, timestamp=STR_TO_DATE(@time,'%d/%m/%Y %h:%i:%s'), stationhistory=@hist WHERE (rfidtag_id=@rfid AND vehicle_vin=@vin)";
            MySqlCommand cmd = new MySqlCommand(sql, dbConn);

            cmd.Parameters.AddWithValue("stId", newStationId.Trim());
            cmd.Parameters.AddWithValue("time", newTimestamp.ToString("dd/MM/yyyy HH:mm:ss"));
            cmd.Parameters.AddWithValue("hist", newHist.Trim());
            cmd.Parameters.AddWithValue("rfid", rfidId.Trim());
            cmd.Parameters.AddWithValue("vin", vin.Trim());
            
            cmd.Prepare();

            int execute = cmd.ExecuteNonQuery();

            // Now, update the vehicles table with the update build status
            string sqlBuildStatus = "UPDATE vehicles SET vehicle_buildStatus_id=@status WHERE vehicle_vin=@vin";
            MySqlCommand cmdBuildStatus = new MySqlCommand(sqlBuildStatus, dbConn);
            cmdBuildStatus.Parameters.AddWithValue("status", getBuildStatusFromStationId(newStationId, newHist));
            cmdBuildStatus.Parameters.AddWithValue("vin", vin.Trim());
            cmd.Prepare();

            int executeBuildStatus = cmdBuildStatus.ExecuteNonQuery();

            if (dbConn.State == ConnectionState.Open)
                dbConn.Close();

            if (execute == 1 && executeBuildStatus == 1)
                pass = true;

            return pass;
        }

        private int getBuildStatusFromStationId(string stationId, string stationHistory)
        {
            int result = 2;
            bool onLine = false;

            /* Statuses are as follows:
             * 1   Build not started
             * 2   Build in progress
             * 3   Vehicle in Audit
             * 4   Vehicle being tested
             * 5   Vehicle Finished
             * 6   Vehicle being reworked
             */

            // Statuses for non-assembly line stations
            switch (stationId)
            {
                case "SFC":
                    result = 1;
                    break;
                case "TF":
                    result = 4;
                    break;
                case "AUDIT":
                    result = 3;
                    break;
                case "SOUND":
                    result = 4;
                    break;
                case "WATER":
                    result = 4;
                    break;
                case "CPA":
                    result = 5;
                    break;
                case "CPB":
                    result = 5;
                    break;
                case "FLEET":
                    result = 5;
                    break;
                default:
                    onLine = true;
                    break;
            }

            // Statuses for assembly line stations
            if (onLine)
            {
                ArrayList vehicleHist = new ArrayList();
                foreach (string station in stationHistory.Split(';'))
                    vehicleHist.Add(station.Split(',')[0]);

                // If the vehicle has previously been at the station, then it is being reworked
                if (vehicleHist.Contains(stationId))
                    result = 6;
                else result = 2;
            }

            return result;
        }
    }
}
