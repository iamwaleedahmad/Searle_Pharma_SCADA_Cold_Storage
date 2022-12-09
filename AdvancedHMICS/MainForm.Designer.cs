namespace AdvancedHMICS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.temp_panel = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.Temperature = new System.Windows.Forms.Label();
            this.alarm_panel = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.alarm_list = new System.Windows.Forms.ListBox();
            this.alarm_heading_label = new System.Windows.Forms.Label();
            this.plc1_status = new System.Windows.Forms.Label();
            this.plc1_indicator = new AdvancedHMIControls.BasicIndicator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.random_timer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trend_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_setpoints_timer = new System.Windows.Forms.Button();
            this.btn_sms_settings = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_backup_settings = new System.Windows.Forms.Button();
            this.usr_accnts_button = new System.Windows.Forms.Button();
            this.btn_user_log = new System.Windows.Forms.Button();
            this.btn_user_accounts = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.Login_Group_Box = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_usrnm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimize_app = new System.Windows.Forms.Button();
            this.btn_close_app = new System.Windows.Forms.Button();
            this.Time = new AdvancedHMIControls.DateTimeDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.basicButton1 = new AdvancedHMIControls.BasicButton();
            this.lbl_log_id = new System.Windows.Forms.Label();
            this.label350 = new System.Windows.Forms.Label();
            this.lbl_user_role = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.backup_now = new System.Windows.Forms.Button();
            this.sendmail = new System.Windows.Forms.Button();
            this.lbl_smtp = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_recipient = new System.Windows.Forms.Label();
            this.lbl_port_num = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.txt_time_backup = new System.Windows.Forms.Label();
            this.txt_backup_path = new System.Windows.Forms.Label();
            this.etimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grp_cold_storage_2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cold_store_2_temp_h_val = new AdvancedHMIControls.AnalogValueDisplay();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cold_store_2_temp_c_val = new AdvancedHMIControls.AnalogValueDisplay();
            this.webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.grp_cold_storage_1 = new System.Windows.Forms.GroupBox();
            this.groupbox_temp = new System.Windows.Forms.GroupBox();
            this.lbl_t = new System.Windows.Forms.Label();
            this.cold_store_1_temp_h_val = new AdvancedHMIControls.AnalogValueDisplay();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cold_store_1_temp_c_val = new AdvancedHMIControls.AnalogValueDisplay();
            this.webView23 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.webView24 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_panel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Login_Group_Box.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grp_cold_storage_2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.grp_cold_storage_1.SuspendLayout();
            this.groupbox_temp.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView24)).BeginInit();
            this.SuspendLayout();
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // temp_panel
            // 
            this.temp_panel.DisableSubscriptions = false;
            this.temp_panel.IniFileName = "";
            this.temp_panel.IniFileSection = null;
            this.temp_panel.IPAddress = "192.168.2.3";
            this.temp_panel.MaxReadGroupSize = 200;
            this.temp_panel.PollRateOverride = 500;
            this.temp_panel.SwapBytes = true;
            this.temp_panel.SwapWords = false;
            this.temp_panel.TcpipPort = ((ushort)(502));
            this.temp_panel.TimeOut = 3000;
            this.temp_panel.UnitId = ((byte)(1));
            this.temp_panel.ComError += new System.EventHandler<MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs>(this.plc_1_ComError);
            this.temp_panel.ConnectionEstablished += new System.EventHandler(this.plc_1_ConnectionEstablished);
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.Temperature.ForeColor = System.Drawing.Color.DarkOrange;
            this.Temperature.Location = new System.Drawing.Point(359, 106);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(71, 37);
            this.Temperature.TabIndex = 1650;
            this.Temperature.Text = "000";
            this.Temperature.Visible = false;
            this.Temperature.TextChanged += new System.EventHandler(this.Temperature_TextChanged);
            // 
            // alarm_panel
            // 
            this.alarm_panel.DisableSubscriptions = false;
            this.alarm_panel.IniFileName = "";
            this.alarm_panel.IniFileSection = null;
            this.alarm_panel.IPAddress = "192.168.2.2";
            this.alarm_panel.MaxReadGroupSize = 200;
            this.alarm_panel.PollRateOverride = 500;
            this.alarm_panel.SwapBytes = true;
            this.alarm_panel.SwapWords = false;
            this.alarm_panel.TcpipPort = ((ushort)(502));
            this.alarm_panel.TimeOut = 3000;
            this.alarm_panel.UnitId = ((byte)(1));
            // 
            // alarm_list
            // 
            this.alarm_list.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alarm_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.alarm_list.ForeColor = System.Drawing.Color.Maroon;
            this.alarm_list.FormattingEnabled = true;
            this.alarm_list.ItemHeight = 24;
            this.alarm_list.Location = new System.Drawing.Point(11, 213);
            this.alarm_list.Name = "alarm_list";
            this.alarm_list.Size = new System.Drawing.Size(204, 124);
            this.alarm_list.TabIndex = 1676;
            // 
            // alarm_heading_label
            // 
            this.alarm_heading_label.AutoSize = true;
            this.alarm_heading_label.BackColor = System.Drawing.Color.Transparent;
            this.alarm_heading_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm_heading_label.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.alarm_heading_label.ForeColor = System.Drawing.Color.Black;
            this.alarm_heading_label.Location = new System.Drawing.Point(8, 187);
            this.alarm_heading_label.Name = "alarm_heading_label";
            this.alarm_heading_label.Size = new System.Drawing.Size(155, 24);
            this.alarm_heading_label.TabIndex = 1677;
            this.alarm_heading_label.Text = "Active Alarm List:";
            // 
            // plc1_status
            // 
            this.plc1_status.AutoSize = true;
            this.plc1_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plc1_status.ForeColor = System.Drawing.Color.Black;
            this.plc1_status.Location = new System.Drawing.Point(38, 20);
            this.plc1_status.Name = "plc1_status";
            this.plc1_status.Size = new System.Drawing.Size(73, 25);
            this.plc1_status.TabIndex = 1681;
            this.plc1_status.Text = "Status";
            // 
            // plc1_indicator
            // 
            this.plc1_indicator.Color1 = System.Drawing.Color.Red;
            this.plc1_indicator.Color2 = System.Drawing.Color.LimeGreen;
            this.plc1_indicator.Color3 = System.Drawing.Color.Red;
            this.plc1_indicator.ComComponent = this.ethernetIPforCLXCom1;
            this.plc1_indicator.Location = new System.Drawing.Point(8, 17);
            this.plc1_indicator.Name = "plc1_indicator";
            this.plc1_indicator.OutlineColor = System.Drawing.Color.Transparent;
            this.plc1_indicator.OutlineWidth = 1;
            this.plc1_indicator.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle;
            this.plc1_indicator.SelectColor2 = false;
            this.plc1_indicator.SelectColor3 = false;
            this.plc1_indicator.Shape = MfgControl.AdvancedHMI.Controls.Indicator.ShapeTypes.Rectangle;
            this.plc1_indicator.Size = new System.Drawing.Size(30, 30);
            this.plc1_indicator.SuppressErrorDisplay = true;
            this.plc1_indicator.TabIndex = 1680;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.plc1_status);
            this.groupBox3.Controls.Add(this.plc1_indicator);
            this.groupBox3.Location = new System.Drawing.Point(11, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 56);
            this.groupBox3.TabIndex = 1688;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // random_timer
            // 
            this.random_timer.Interval = 1500;
            this.random_timer.Tick += new System.EventHandler(this.random_timer_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(10, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 40);
            this.button2.TabIndex = 1711;
            this.button2.Text = "Email Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(350, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(80, 35);
            this.richTextBox1.TabIndex = 1712;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // trend_timer
            // 
            this.trend_timer.Enabled = true;
            this.trend_timer.Interval = 8000;
            this.trend_timer.Tick += new System.EventHandler(this.trend_timer_Tick);
            // 
            // btn_setpoints_timer
            // 
            this.btn_setpoints_timer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_setpoints_timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_setpoints_timer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setpoints_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setpoints_timer.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btn_setpoints_timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_setpoints_timer.Location = new System.Drawing.Point(10, 356);
            this.btn_setpoints_timer.Name = "btn_setpoints_timer";
            this.btn_setpoints_timer.Size = new System.Drawing.Size(206, 40);
            this.btn_setpoints_timer.TabIndex = 1714;
            this.btn_setpoints_timer.Text = "Setpoints and Timer";
            this.btn_setpoints_timer.UseVisualStyleBackColor = false;
            this.btn_setpoints_timer.Click += new System.EventHandler(this.btn_setpoints_timer_Click);
            // 
            // btn_sms_settings
            // 
            this.btn_sms_settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sms_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_sms_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sms_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sms_settings.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btn_sms_settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sms_settings.Location = new System.Drawing.Point(10, 436);
            this.btn_sms_settings.Name = "btn_sms_settings";
            this.btn_sms_settings.Size = new System.Drawing.Size(206, 40);
            this.btn_sms_settings.TabIndex = 1715;
            this.btn_sms_settings.Text = "SMS Settings";
            this.btn_sms_settings.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(10, 516);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(206, 40);
            this.button6.TabIndex = 1717;
            this.button6.Text = "PDF Report";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btn_backup_settings
            // 
            this.btn_backup_settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_backup_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_backup_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backup_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup_settings.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btn_backup_settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_backup_settings.Location = new System.Drawing.Point(10, 476);
            this.btn_backup_settings.Name = "btn_backup_settings";
            this.btn_backup_settings.Size = new System.Drawing.Size(206, 40);
            this.btn_backup_settings.TabIndex = 1716;
            this.btn_backup_settings.Text = "Backup Settings";
            this.btn_backup_settings.UseVisualStyleBackColor = false;
            this.btn_backup_settings.Click += new System.EventHandler(this.btn_backup_settings_Click);
            // 
            // usr_accnts_button
            // 
            this.usr_accnts_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.usr_accnts_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.usr_accnts_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usr_accnts_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usr_accnts_button.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.usr_accnts_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usr_accnts_button.Location = new System.Drawing.Point(10, 636);
            this.usr_accnts_button.Name = "usr_accnts_button";
            this.usr_accnts_button.Size = new System.Drawing.Size(206, 40);
            this.usr_accnts_button.TabIndex = 1721;
            this.usr_accnts_button.Text = "User Accounts";
            this.usr_accnts_button.UseVisualStyleBackColor = false;
            this.usr_accnts_button.Click += new System.EventHandler(this.usr_accnts_button_Click);
            // 
            // btn_user_log
            // 
            this.btn_user_log.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_user_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_user_log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_log.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btn_user_log.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user_log.Location = new System.Drawing.Point(10, 596);
            this.btn_user_log.Name = "btn_user_log";
            this.btn_user_log.Size = new System.Drawing.Size(206, 40);
            this.btn_user_log.TabIndex = 1720;
            this.btn_user_log.Text = "User Log";
            this.btn_user_log.UseVisualStyleBackColor = false;
            this.btn_user_log.Click += new System.EventHandler(this.btn_user_log_Click);
            // 
            // btn_user_accounts
            // 
            this.btn_user_accounts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_user_accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn_user_accounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_accounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_accounts.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btn_user_accounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user_accounts.Location = new System.Drawing.Point(-502, 750);
            this.btn_user_accounts.Name = "btn_user_accounts";
            this.btn_user_accounts.Size = new System.Drawing.Size(200, 32);
            this.btn_user_accounts.TabIndex = 1719;
            this.btn_user_accounts.Text = "User Roles";
            this.btn_user_accounts.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(10, 556);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(206, 40);
            this.button11.TabIndex = 1718;
            this.button11.Text = "Graph Report";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // Login_Group_Box
            // 
            this.Login_Group_Box.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Login_Group_Box.BackColor = System.Drawing.Color.White;
            this.Login_Group_Box.Controls.Add(this.btn_logout);
            this.Login_Group_Box.Controls.Add(this.btn_login);
            this.Login_Group_Box.Controls.Add(this.txt_password);
            this.Login_Group_Box.Controls.Add(this.txt_username);
            this.Login_Group_Box.Controls.Add(this.lbl_pwd);
            this.Login_Group_Box.Controls.Add(this.lbl_usrnm);
            this.Login_Group_Box.Location = new System.Drawing.Point(11, 673);
            this.Login_Group_Box.Name = "Login_Group_Box";
            this.Login_Group_Box.Size = new System.Drawing.Size(204, 160);
            this.Login_Group_Box.TabIndex = 1722;
            this.Login_Group_Box.TabStop = false;
            this.Login_Group_Box.Leave += new System.EventHandler(this.Login_Group_Box_Leave);
            this.Login_Group_Box.MouseHover += new System.EventHandler(this.Login_Group_Box_MouseHover);
            this.Login_Group_Box.Move += new System.EventHandler(this.Login_Group_Box_Move);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(115, 124);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(82, 27);
            this.btn_logout.TabIndex = 1335;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            this.btn_logout.MouseLeave += new System.EventHandler(this.btn_logout_MouseLeave);
            this.btn_logout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_logout_MouseMove);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Enabled = false;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(9, 124);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(82, 27);
            this.btn_login.TabIndex = 1385;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            this.btn_login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_login_MouseMove);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Enabled = false;
            this.txt_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(9, 90);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(186, 26);
            this.txt_password.TabIndex = 1384;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            this.txt_password.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_password_MouseMove);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Enabled = false;
            this.txt_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(9, 37);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(186, 26);
            this.txt_username.TabIndex = 1383;
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            this.txt_username.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_username_MouseMove);
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.White;
            this.lbl_pwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_pwd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.ForeColor = System.Drawing.Color.Black;
            this.lbl_pwd.Location = new System.Drawing.Point(6, 69);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(78, 18);
            this.lbl_pwd.TabIndex = 1386;
            this.lbl_pwd.Text = "Password";
            this.lbl_pwd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_pwd_MouseMove);
            // 
            // lbl_usrnm
            // 
            this.lbl_usrnm.AutoSize = true;
            this.lbl_usrnm.BackColor = System.Drawing.Color.White;
            this.lbl_usrnm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_usrnm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usrnm.ForeColor = System.Drawing.Color.Black;
            this.lbl_usrnm.Location = new System.Drawing.Point(6, 17);
            this.lbl_usrnm.Name = "lbl_usrnm";
            this.lbl_usrnm.Size = new System.Drawing.Size(80, 18);
            this.lbl_usrnm.TabIndex = 1385;
            this.lbl_usrnm.Text = "Username";
            this.lbl_usrnm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_usrnm_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 24);
            this.label12.TabIndex = 1723;
            this.label12.Text = "PLC Panel Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btn_minimize_app);
            this.panel1.Controls.Add(this.btn_close_app);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 50);
            this.panel1.TabIndex = 1724;
            // 
            // btn_minimize_app
            // 
            this.btn_minimize_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize_app.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.btn_minimize_app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize_app.FlatAppearance.BorderSize = 0;
            this.btn_minimize_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize_app.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btn_minimize_app.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_minimize_app.Location = new System.Drawing.Point(1620, 0);
            this.btn_minimize_app.Name = "btn_minimize_app";
            this.btn_minimize_app.Size = new System.Drawing.Size(150, 50);
            this.btn_minimize_app.TabIndex = 1695;
            this.btn_minimize_app.Text = "Minimize";
            this.btn_minimize_app.UseVisualStyleBackColor = false;
            this.btn_minimize_app.Click += new System.EventHandler(this.btn_minimize_app_Click_1);
            // 
            // btn_close_app
            // 
            this.btn_close_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close_app.BackColor = System.Drawing.Color.Firebrick;
            this.btn_close_app.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close_app.FlatAppearance.BorderSize = 0;
            this.btn_close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_app.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btn_close_app.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_close_app.Location = new System.Drawing.Point(1770, 0);
            this.btn_close_app.Name = "btn_close_app";
            this.btn_close_app.Size = new System.Drawing.Size(150, 50);
            this.btn_close_app.TabIndex = 1694;
            this.btn_close_app.Text = "Close";
            this.btn_close_app.UseVisualStyleBackColor = false;
            this.btn_close_app.Click += new System.EventHandler(this.btn_close_app_Click_1);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.DisplayFormat = "hh:mm:ss tt";
            this.Time.Font = new System.Drawing.Font("Arial", 26F);
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(203, 5);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(210, 40);
            this.Time.TabIndex = 1693;
            this.Time.Text = "12:19:11 PM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(760, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 45);
            this.label1.TabIndex = 1692;
            this.label1.Text = "Cold Storage SCADA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 52);
            this.pictureBox1.TabIndex = 1696;
            this.pictureBox1.TabStop = false;
            // 
            // basicButton1
            // 
            this.basicButton1.BackColor = System.Drawing.Color.Black;
            this.basicButton1.ComComponent = this.alarm_panel;
            this.basicButton1.ForeColor = System.Drawing.Color.Black;
            this.basicButton1.ForeColorAltername = System.Drawing.Color.Black;
            this.basicButton1.Highlight = false;
            this.basicButton1.HighlightColor = System.Drawing.Color.Green;
            this.basicButton1.Location = new System.Drawing.Point(241, 111);
            this.basicButton1.MaximumHoldTime = 3000;
            this.basicButton1.MinimumHoldTime = 500;
            this.basicButton1.Name = "basicButton1";
            this.basicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle;
            this.basicButton1.PLCAddressClick = "002001";
            this.basicButton1.SelectTextAlternate = false;
            this.basicButton1.Size = new System.Drawing.Size(112, 32);
            this.basicButton1.TabIndex = 1725;
            this.basicButton1.Text = "Alarm Buzzer";
            this.basicButton1.TextAlternate = null;
            this.basicButton1.UseVisualStyleBackColor = true;
            this.basicButton1.ValueToWrite = 0;
            this.basicButton1.Visible = false;
            // 
            // lbl_log_id
            // 
            this.lbl_log_id.AutoSize = true;
            this.lbl_log_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_log_id.Location = new System.Drawing.Point(134, 85);
            this.lbl_log_id.Name = "lbl_log_id";
            this.lbl_log_id.Size = new System.Drawing.Size(56, 19);
            this.lbl_log_id.TabIndex = 1727;
            this.lbl_log_id.Text = "log_id";
            this.lbl_log_id.Visible = false;
            // 
            // label350
            // 
            this.label350.AutoSize = true;
            this.label350.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label350.ForeColor = System.Drawing.Color.Black;
            this.label350.Location = new System.Drawing.Point(9, 85);
            this.label350.Name = "label350";
            this.label350.Size = new System.Drawing.Size(50, 19);
            this.label350.TabIndex = 1731;
            this.label350.Text = "Role:";
            // 
            // lbl_user_role
            // 
            this.lbl_user_role.AutoSize = true;
            this.lbl_user_role.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_role.ForeColor = System.Drawing.Color.Black;
            this.lbl_user_role.Location = new System.Drawing.Point(62, 85);
            this.lbl_user_role.Name = "lbl_user_role";
            this.lbl_user_role.Size = new System.Drawing.Size(38, 19);
            this.lbl_user_role.TabIndex = 1730;
            this.lbl_user_role.Text = "role";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.ForeColor = System.Drawing.Color.Black;
            this.label150.Location = new System.Drawing.Point(9, 61);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(51, 19);
            this.label150.TabIndex = 1729;
            this.label150.Text = "User:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(62, 61);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(128, 19);
            this.lbl_username.TabIndex = 1728;
            this.lbl_username.Text = "user_logged_in";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 13F);
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(222, 66);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(139, 30);
            this.btn_refresh.TabIndex = 1732;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Visible = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // backup_now
            // 
            this.backup_now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.backup_now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backup_now.Font = new System.Drawing.Font("Calibri", 14F);
            this.backup_now.ForeColor = System.Drawing.Color.White;
            this.backup_now.Location = new System.Drawing.Point(549, 64);
            this.backup_now.Name = "backup_now";
            this.backup_now.Size = new System.Drawing.Size(119, 35);
            this.backup_now.TabIndex = 1740;
            this.backup_now.Text = "Backup Now ";
            this.backup_now.UseVisualStyleBackColor = false;
            this.backup_now.Visible = false;
            this.backup_now.Click += new System.EventHandler(this.backup_now_Click);
            // 
            // sendmail
            // 
            this.sendmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.sendmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendmail.Font = new System.Drawing.Font("Calibri", 14F);
            this.sendmail.ForeColor = System.Drawing.Color.White;
            this.sendmail.Location = new System.Drawing.Point(667, 63);
            this.sendmail.Name = "sendmail";
            this.sendmail.Size = new System.Drawing.Size(119, 35);
            this.sendmail.TabIndex = 1739;
            this.sendmail.Text = "Send Email";
            this.sendmail.UseVisualStyleBackColor = false;
            this.sendmail.Visible = false;
            // 
            // lbl_smtp
            // 
            this.lbl_smtp.AutoSize = true;
            this.lbl_smtp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_smtp.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_smtp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_smtp.Location = new System.Drawing.Point(436, 140);
            this.lbl_smtp.Name = "lbl_smtp";
            this.lbl_smtp.Size = new System.Drawing.Size(30, 15);
            this.lbl_smtp.TabIndex = 1738;
            this.lbl_smtp.Text = "smtp";
            this.lbl_smtp.Visible = false;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_subject.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_subject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_subject.Location = new System.Drawing.Point(436, 80);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(40, 15);
            this.lbl_subject.TabIndex = 1737;
            this.lbl_subject.Text = "subject";
            this.lbl_subject.Visible = false;
            // 
            // lbl_recipient
            // 
            this.lbl_recipient.AutoSize = true;
            this.lbl_recipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_recipient.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_recipient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_recipient.Location = new System.Drawing.Point(436, 95);
            this.lbl_recipient.Name = "lbl_recipient";
            this.lbl_recipient.Size = new System.Drawing.Size(47, 15);
            this.lbl_recipient.TabIndex = 1736;
            this.lbl_recipient.Text = "recipient";
            this.lbl_recipient.Visible = false;
            // 
            // lbl_port_num
            // 
            this.lbl_port_num.AutoSize = true;
            this.lbl_port_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_port_num.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_port_num.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_port_num.Location = new System.Drawing.Point(436, 125);
            this.lbl_port_num.Name = "lbl_port_num";
            this.lbl_port_num.Size = new System.Drawing.Size(50, 15);
            this.lbl_port_num.TabIndex = 1735;
            this.lbl_port_num.Text = "port num";
            this.lbl_port_num.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_password.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_password.Location = new System.Drawing.Point(436, 110);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(51, 15);
            this.lbl_password.TabIndex = 1734;
            this.lbl_password.Text = "password";
            this.lbl_password.Visible = false;
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lbl_sender.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_sender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sender.Location = new System.Drawing.Point(436, 65);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(38, 15);
            this.lbl_sender.TabIndex = 1733;
            this.lbl_sender.Text = "sender";
            this.lbl_sender.Visible = false;
            // 
            // txt_time_backup
            // 
            this.txt_time_backup.AutoSize = true;
            this.txt_time_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txt_time_backup.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time_backup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_time_backup.Location = new System.Drawing.Point(801, 82);
            this.txt_time_backup.Name = "txt_time_backup";
            this.txt_time_backup.Size = new System.Drawing.Size(38, 18);
            this.txt_time_backup.TabIndex = 1742;
            this.txt_time_backup.Text = "time";
            this.txt_time_backup.Visible = false;
            // 
            // txt_backup_path
            // 
            this.txt_backup_path.AutoSize = true;
            this.txt_backup_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txt_backup_path.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_backup_path.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_backup_path.Location = new System.Drawing.Point(801, 68);
            this.txt_backup_path.Name = "txt_backup_path";
            this.txt_backup_path.Size = new System.Drawing.Size(98, 18);
            this.txt_backup_path.TabIndex = 1741;
            this.txt_backup_path.Text = "backup_path";
            this.txt_backup_path.Visible = false;
            // 
            // etimer
            // 
            this.etimer.Enabled = true;
            this.etimer.Interval = 600000;
            this.etimer.Tick += new System.EventHandler(this.etimer_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::GETZ_SCADA.Properties.Resources.Star_Logo_for_GETZ_COLD_STORAGE1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(13, 847);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(202, 161);
            this.pictureBox4.TabIndex = 1706;
            this.pictureBox4.TabStop = false;
            // 
            // grp_cold_storage_2
            // 
            this.grp_cold_storage_2.Controls.Add(this.label6);
            this.grp_cold_storage_2.Controls.Add(this.groupBox1);
            this.grp_cold_storage_2.Controls.Add(this.groupBox2);
            this.grp_cold_storage_2.Controls.Add(this.webView22);
            this.grp_cold_storage_2.Controls.Add(this.webView21);
            this.grp_cold_storage_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.grp_cold_storage_2.Location = new System.Drawing.Point(1076, 80);
            this.grp_cold_storage_2.Name = "grp_cold_storage_2";
            this.grp_cold_storage_2.Size = new System.Drawing.Size(840, 927);
            this.grp_cold_storage_2.TabIndex = 1749;
            this.grp_cold_storage_2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(294, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 45);
            this.label6.TabIndex = 1752;
            this.label6.Text = "Cold Storage - 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cold_store_2_temp_h_val);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(259, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 67);
            this.groupBox1.TabIndex = 1751;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 1651;
            this.label2.Text = "Hottest:";
            // 
            // cold_store_2_temp_h_val
            // 
            this.cold_store_2_temp_h_val.AutoSize = true;
            this.cold_store_2_temp_h_val.BackColor = System.Drawing.Color.White;
            this.cold_store_2_temp_h_val.ComComponent = this.temp_panel;
            this.cold_store_2_temp_h_val.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cold_store_2_temp_h_val.ForeColor = System.Drawing.Color.Black;
            this.cold_store_2_temp_h_val.ForeColorInLimits = System.Drawing.Color.Black;
            this.cold_store_2_temp_h_val.ForeColorOverLimit = System.Drawing.Color.Red;
            this.cold_store_2_temp_h_val.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.cold_store_2_temp_h_val.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.cold_store_2_temp_h_val.KeypadMaxValue = 0D;
            this.cold_store_2_temp_h_val.KeypadMinValue = 0D;
            this.cold_store_2_temp_h_val.KeypadPasscode = null;
            this.cold_store_2_temp_h_val.KeypadScaleFactor = 1D;
            this.cold_store_2_temp_h_val.KeypadText = null;
            this.cold_store_2_temp_h_val.KeypadWidth = 300;
            this.cold_store_2_temp_h_val.Location = new System.Drawing.Point(126, 23);
            this.cold_store_2_temp_h_val.Name = "cold_store_2_temp_h_val";
            this.cold_store_2_temp_h_val.NumericFormat = "0.0";
            this.cold_store_2_temp_h_val.PLCAddressKeypad = "";
            this.cold_store_2_temp_h_val.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("cold_store_2_temp_h_val.PLCAddressValue")));
            this.cold_store_2_temp_h_val.PLCAddressValueLimitLower = null;
            this.cold_store_2_temp_h_val.PLCAddressValueLimitUpper = null;
            this.cold_store_2_temp_h_val.PLCAddressVisible = null;
            this.cold_store_2_temp_h_val.ShowValue = true;
            this.cold_store_2_temp_h_val.Size = new System.Drawing.Size(107, 37);
            this.cold_store_2_temp_h_val.SuppressErrorDisplay = true;
            this.cold_store_2_temp_h_val.TabIndex = 1710;
            this.cold_store_2_temp_h_val.Text = "0.0 °C";
            this.cold_store_2_temp_h_val.Value = "0000";
            this.cold_store_2_temp_h_val.ValueLimitLower = -999999D;
            this.cold_store_2_temp_h_val.ValueLimitUpper = 999999D;
            this.cold_store_2_temp_h_val.ValuePrefix = null;
            this.cold_store_2_temp_h_val.ValueSuffix = " °C";
            this.cold_store_2_temp_h_val.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cold_store_2_temp_c_val);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(259, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 67);
            this.groupBox2.TabIndex = 1752;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 1651;
            this.label3.Text = "Coldest:";
            // 
            // cold_store_2_temp_c_val
            // 
            this.cold_store_2_temp_c_val.AutoSize = true;
            this.cold_store_2_temp_c_val.BackColor = System.Drawing.Color.White;
            this.cold_store_2_temp_c_val.ComComponent = this.temp_panel;
            this.cold_store_2_temp_c_val.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cold_store_2_temp_c_val.ForeColor = System.Drawing.Color.Black;
            this.cold_store_2_temp_c_val.ForeColorInLimits = System.Drawing.Color.Black;
            this.cold_store_2_temp_c_val.ForeColorOverLimit = System.Drawing.Color.Red;
            this.cold_store_2_temp_c_val.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.cold_store_2_temp_c_val.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.cold_store_2_temp_c_val.KeypadMaxValue = 0D;
            this.cold_store_2_temp_c_val.KeypadMinValue = 0D;
            this.cold_store_2_temp_c_val.KeypadPasscode = null;
            this.cold_store_2_temp_c_val.KeypadScaleFactor = 1D;
            this.cold_store_2_temp_c_val.KeypadText = null;
            this.cold_store_2_temp_c_val.KeypadWidth = 300;
            this.cold_store_2_temp_c_val.Location = new System.Drawing.Point(126, 23);
            this.cold_store_2_temp_c_val.Name = "cold_store_2_temp_c_val";
            this.cold_store_2_temp_c_val.NumericFormat = "0.0";
            this.cold_store_2_temp_c_val.PLCAddressKeypad = "";
            this.cold_store_2_temp_c_val.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("cold_store_2_temp_c_val.PLCAddressValue")));
            this.cold_store_2_temp_c_val.PLCAddressValueLimitLower = null;
            this.cold_store_2_temp_c_val.PLCAddressValueLimitUpper = null;
            this.cold_store_2_temp_c_val.PLCAddressVisible = null;
            this.cold_store_2_temp_c_val.ShowValue = true;
            this.cold_store_2_temp_c_val.Size = new System.Drawing.Size(107, 37);
            this.cold_store_2_temp_c_val.SuppressErrorDisplay = true;
            this.cold_store_2_temp_c_val.TabIndex = 1710;
            this.cold_store_2_temp_c_val.Text = "0.0 °C";
            this.cold_store_2_temp_c_val.Value = "0000";
            this.cold_store_2_temp_c_val.ValueLimitLower = -999999D;
            this.cold_store_2_temp_c_val.ValueLimitUpper = 999999D;
            this.cold_store_2_temp_c_val.ValuePrefix = null;
            this.cold_store_2_temp_c_val.ValueSuffix = " °C";
            this.cold_store_2_temp_c_val.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // webView22
            // 
            this.webView22.AllowExternalDrop = true;
            this.webView22.CreationProperties = null;
            this.webView22.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView22.Location = new System.Drawing.Point(6, 497);
            this.webView22.Name = "webView22";
            this.webView22.Size = new System.Drawing.Size(830, 423);
            this.webView22.Source = new System.Uri("http://localhost/searle_live_trends/graph_4.php", System.UriKind.Absolute);
            this.webView22.TabIndex = 1750;
            this.webView22.ZoomFactor = 1D;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(6, 70);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(830, 423);
            this.webView21.Source = new System.Uri("http://localhost/searle_live_trends/graph_3.php", System.UriKind.Absolute);
            this.webView21.TabIndex = 1749;
            this.webView21.ZoomFactor = 1D;
            // 
            // grp_cold_storage_1
            // 
            this.grp_cold_storage_1.Controls.Add(this.groupbox_temp);
            this.grp_cold_storage_1.Controls.Add(this.label5);
            this.grp_cold_storage_1.Controls.Add(this.groupBox6);
            this.grp_cold_storage_1.Controls.Add(this.webView23);
            this.grp_cold_storage_1.Controls.Add(this.webView24);
            this.grp_cold_storage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.grp_cold_storage_1.Location = new System.Drawing.Point(226, 80);
            this.grp_cold_storage_1.Name = "grp_cold_storage_1";
            this.grp_cold_storage_1.Size = new System.Drawing.Size(840, 927);
            this.grp_cold_storage_1.TabIndex = 1750;
            this.grp_cold_storage_1.TabStop = false;
            // 
            // groupbox_temp
            // 
            this.groupbox_temp.BackColor = System.Drawing.Color.White;
            this.groupbox_temp.Controls.Add(this.lbl_t);
            this.groupbox_temp.Controls.Add(this.cold_store_1_temp_h_val);
            this.groupbox_temp.ForeColor = System.Drawing.Color.White;
            this.groupbox_temp.Location = new System.Drawing.Point(259, 76);
            this.groupbox_temp.Name = "groupbox_temp";
            this.groupbox_temp.Size = new System.Drawing.Size(322, 67);
            this.groupbox_temp.TabIndex = 1748;
            this.groupbox_temp.TabStop = false;
            // 
            // lbl_t
            // 
            this.lbl_t.AutoSize = true;
            this.lbl_t.Font = new System.Drawing.Font("Arial", 24F);
            this.lbl_t.ForeColor = System.Drawing.Color.Black;
            this.lbl_t.Location = new System.Drawing.Point(4, 23);
            this.lbl_t.Name = "lbl_t";
            this.lbl_t.Size = new System.Drawing.Size(124, 36);
            this.lbl_t.TabIndex = 1651;
            this.lbl_t.Text = "Hottest:";
            // 
            // cold_store_1_temp_h_val
            // 
            this.cold_store_1_temp_h_val.AutoSize = true;
            this.cold_store_1_temp_h_val.BackColor = System.Drawing.Color.White;
            this.cold_store_1_temp_h_val.ComComponent = this.temp_panel;
            this.cold_store_1_temp_h_val.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cold_store_1_temp_h_val.ForeColor = System.Drawing.Color.Black;
            this.cold_store_1_temp_h_val.ForeColorInLimits = System.Drawing.Color.Black;
            this.cold_store_1_temp_h_val.ForeColorOverLimit = System.Drawing.Color.Red;
            this.cold_store_1_temp_h_val.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.cold_store_1_temp_h_val.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.cold_store_1_temp_h_val.KeypadMaxValue = 0D;
            this.cold_store_1_temp_h_val.KeypadMinValue = 0D;
            this.cold_store_1_temp_h_val.KeypadPasscode = null;
            this.cold_store_1_temp_h_val.KeypadScaleFactor = 1D;
            this.cold_store_1_temp_h_val.KeypadText = null;
            this.cold_store_1_temp_h_val.KeypadWidth = 300;
            this.cold_store_1_temp_h_val.Location = new System.Drawing.Point(126, 23);
            this.cold_store_1_temp_h_val.Name = "cold_store_1_temp_h_val";
            this.cold_store_1_temp_h_val.NumericFormat = "0.0";
            this.cold_store_1_temp_h_val.PLCAddressKeypad = "";
            this.cold_store_1_temp_h_val.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("cold_store_1_temp_h_val.PLCAddressValue")));
            this.cold_store_1_temp_h_val.PLCAddressValueLimitLower = null;
            this.cold_store_1_temp_h_val.PLCAddressValueLimitUpper = null;
            this.cold_store_1_temp_h_val.PLCAddressVisible = null;
            this.cold_store_1_temp_h_val.ShowValue = true;
            this.cold_store_1_temp_h_val.Size = new System.Drawing.Size(107, 37);
            this.cold_store_1_temp_h_val.SuppressErrorDisplay = true;
            this.cold_store_1_temp_h_val.TabIndex = 1710;
            this.cold_store_1_temp_h_val.Text = "0.0 °C";
            this.cold_store_1_temp_h_val.Value = "0000";
            this.cold_store_1_temp_h_val.ValueLimitLower = -999999D;
            this.cold_store_1_temp_h_val.ValueLimitUpper = 999999D;
            this.cold_store_1_temp_h_val.ValuePrefix = null;
            this.cold_store_1_temp_h_val.ValueSuffix = " °C";
            this.cold_store_1_temp_h_val.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.cold_store_1_temp_h_val.ValueChanged += new System.EventHandler(this.cold_store_1_temp_h_val_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(289, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 45);
            this.label5.TabIndex = 1751;
            this.label5.Text = "Cold Storage - 1";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.cold_store_1_temp_c_val);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(259, 505);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(322, 67);
            this.groupBox6.TabIndex = 1751;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 36);
            this.label4.TabIndex = 1651;
            this.label4.Text = "Coldest:";
            // 
            // cold_store_1_temp_c_val
            // 
            this.cold_store_1_temp_c_val.AutoSize = true;
            this.cold_store_1_temp_c_val.BackColor = System.Drawing.Color.White;
            this.cold_store_1_temp_c_val.ComComponent = this.temp_panel;
            this.cold_store_1_temp_c_val.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cold_store_1_temp_c_val.ForeColor = System.Drawing.Color.Black;
            this.cold_store_1_temp_c_val.ForeColorInLimits = System.Drawing.Color.Black;
            this.cold_store_1_temp_c_val.ForeColorOverLimit = System.Drawing.Color.Red;
            this.cold_store_1_temp_c_val.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.cold_store_1_temp_c_val.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.cold_store_1_temp_c_val.KeypadMaxValue = 0D;
            this.cold_store_1_temp_c_val.KeypadMinValue = 0D;
            this.cold_store_1_temp_c_val.KeypadPasscode = null;
            this.cold_store_1_temp_c_val.KeypadScaleFactor = 1D;
            this.cold_store_1_temp_c_val.KeypadText = null;
            this.cold_store_1_temp_c_val.KeypadWidth = 300;
            this.cold_store_1_temp_c_val.Location = new System.Drawing.Point(126, 23);
            this.cold_store_1_temp_c_val.Name = "cold_store_1_temp_c_val";
            this.cold_store_1_temp_c_val.NumericFormat = "0.0";
            this.cold_store_1_temp_c_val.PLCAddressKeypad = "";
            this.cold_store_1_temp_c_val.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("cold_store_1_temp_c_val.PLCAddressValue")));
            this.cold_store_1_temp_c_val.PLCAddressValueLimitLower = null;
            this.cold_store_1_temp_c_val.PLCAddressValueLimitUpper = null;
            this.cold_store_1_temp_c_val.PLCAddressVisible = null;
            this.cold_store_1_temp_c_val.ShowValue = true;
            this.cold_store_1_temp_c_val.Size = new System.Drawing.Size(107, 37);
            this.cold_store_1_temp_c_val.SuppressErrorDisplay = true;
            this.cold_store_1_temp_c_val.TabIndex = 1710;
            this.cold_store_1_temp_c_val.Text = "0.0 °C";
            this.cold_store_1_temp_c_val.Value = "0000";
            this.cold_store_1_temp_c_val.ValueLimitLower = -999999D;
            this.cold_store_1_temp_c_val.ValueLimitUpper = 999999D;
            this.cold_store_1_temp_c_val.ValuePrefix = null;
            this.cold_store_1_temp_c_val.ValueSuffix = " °C";
            this.cold_store_1_temp_c_val.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // webView23
            // 
            this.webView23.AllowExternalDrop = true;
            this.webView23.CreationProperties = null;
            this.webView23.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView23.Location = new System.Drawing.Point(5, 498);
            this.webView23.Name = "webView23";
            this.webView23.Size = new System.Drawing.Size(830, 423);
            this.webView23.Source = new System.Uri("http://localhost/searle_live_trends/graph_2.php", System.UriKind.Absolute);
            this.webView23.TabIndex = 1750;
            this.webView23.ZoomFactor = 1D;
            // 
            // webView24
            // 
            this.webView24.AllowExternalDrop = true;
            this.webView24.CreationProperties = null;
            this.webView24.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView24.Location = new System.Drawing.Point(5, 71);
            this.webView24.Name = "webView24";
            this.webView24.Size = new System.Drawing.Size(830, 423);
            this.webView24.Source = new System.Uri("http://localhost/searle_live_trends/chartphp.php", System.UriKind.Absolute);
            this.webView24.TabIndex = 1749;
            this.webView24.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.grp_cold_storage_1);
            this.Controls.Add(this.grp_cold_storage_2);
            this.Controls.Add(this.txt_time_backup);
            this.Controls.Add(this.txt_backup_path);
            this.Controls.Add(this.backup_now);
            this.Controls.Add(this.sendmail);
            this.Controls.Add(this.lbl_smtp);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_recipient);
            this.Controls.Add(this.lbl_port_num);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label350);
            this.Controls.Add(this.lbl_user_role);
            this.Controls.Add(this.label150);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_log_id);
            this.Controls.Add(this.basicButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usr_accnts_button);
            this.Controls.Add(this.btn_user_log);
            this.Controls.Add(this.btn_user_accounts);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_backup_settings);
            this.Controls.Add(this.btn_sms_settings);
            this.Controls.Add(this.btn_setpoints_timer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.alarm_list);
            this.Controls.Add(this.alarm_heading_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Login_Group_Box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard | GETZ Cold Storage Temperature and Humidity Mapping Software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_panel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Login_Group_Box.ResumeLayout(false);
            this.Login_Group_Box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grp_cold_storage_2.ResumeLayout(false);
            this.grp_cold_storage_2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.grp_cold_storage_1.ResumeLayout(false);
            this.grp_cold_storage_1.PerformLayout();
            this.groupbox_temp.ResumeLayout(false);
            this.groupbox_temp.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.ListBox alarm_list;
        private System.Windows.Forms.Label alarm_heading_label;
        public System.Windows.Forms.Label plc1_status;
        private AdvancedHMIControls.BasicIndicator plc1_indicator;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer random_timer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private AdvancedHMIDrivers.ModbusTCPCom temp_panel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer trend_timer;
        private System.Windows.Forms.Button btn_setpoints_timer;
        private System.Windows.Forms.Button btn_sms_settings;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_backup_settings;
        private System.Windows.Forms.Button usr_accnts_button;
        private System.Windows.Forms.Button btn_user_log;
        private System.Windows.Forms.Button btn_user_accounts;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox Login_Group_Box;
        private System.Windows.Forms.Label lbl_usrnm;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimize_app;
        private System.Windows.Forms.Button btn_close_app;
        private AdvancedHMIControls.DateTimeDisplay Time;
        private System.Windows.Forms.Label label1;
        private AdvancedHMIDrivers.ModbusTCPCom alarm_panel;
        private AdvancedHMIControls.BasicButton basicButton1;
        public System.Windows.Forms.Label lbl_log_id;
        public System.Windows.Forms.Label label350;
        public System.Windows.Forms.Label lbl_user_role;
        public System.Windows.Forms.Label label150;
        public System.Windows.Forms.Label lbl_username;
        internal System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button backup_now;
        private System.Windows.Forms.Button sendmail;
        internal System.Windows.Forms.Label lbl_smtp;
        internal System.Windows.Forms.Label lbl_subject;
        internal System.Windows.Forms.Label lbl_recipient;
        internal System.Windows.Forms.Label lbl_port_num;
        internal System.Windows.Forms.Label lbl_password;
        internal System.Windows.Forms.Label lbl_sender;
        internal System.Windows.Forms.Label txt_time_backup;
        internal System.Windows.Forms.Label txt_backup_path;
        public System.Windows.Forms.Timer etimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp_cold_storage_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private AdvancedHMIControls.AnalogValueDisplay cold_store_2_temp_c_val;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private AdvancedHMIControls.AnalogValueDisplay cold_store_2_temp_h_val;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.GroupBox grp_cold_storage_1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private AdvancedHMIControls.AnalogValueDisplay cold_store_1_temp_c_val;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView23;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView24;
        private System.Windows.Forms.GroupBox groupbox_temp;
        private System.Windows.Forms.Label lbl_t;
        private AdvancedHMIControls.AnalogValueDisplay cold_store_1_temp_h_val;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

