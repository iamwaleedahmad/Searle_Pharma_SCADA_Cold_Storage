
namespace GETZ_SCADA
{
    partial class Setpoints_Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setpoints_Alarm));
            this.keyboardInput1 = new AdvancedHMIControls.KeyboardInput();
            this.alarm_panel = new AdvancedHMIDrivers.ModbusTCPCom(this.components);
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.analogValueDisplay1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.analogValueDisplay2 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput2 = new AdvancedHMIControls.KeyboardInput();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.analogValueDisplay3 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput3 = new AdvancedHMIControls.KeyboardInput();
            this.analogValueDisplay4 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput4 = new AdvancedHMIControls.KeyboardInput();
            this.label4 = new System.Windows.Forms.Label();
            this.analogValueDisplay5 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput5 = new AdvancedHMIControls.KeyboardInput();
            this.label5 = new System.Windows.Forms.Label();
            this.analogValueDisplay6 = new AdvancedHMIControls.AnalogValueDisplay();
            this.label6 = new System.Windows.Forms.Label();
            this.keyboardInput6 = new AdvancedHMIControls.KeyboardInput();
            this.keyboardInput7 = new AdvancedHMIControls.KeyboardInput();
            this.analogValueDisplay7 = new AdvancedHMIControls.AnalogValueDisplay();
            this.label7 = new System.Windows.Forms.Label();
            this.analogValueDisplay8 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput8 = new AdvancedHMIControls.KeyboardInput();
            this.analogValueDisplay9 = new AdvancedHMIControls.AnalogValueDisplay();
            this.keyboardInput9 = new AdvancedHMIControls.KeyboardInput();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyboardInput1
            // 
            this.keyboardInput1.ClearAfterEnterKey = true;
            this.keyboardInput1.ComComponent = this.alarm_panel;
            this.keyboardInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput1.GetFocusMatchValue = 1;
            this.keyboardInput1.GetFocusValue = 0;
            this.keyboardInput1.Location = new System.Drawing.Point(240, 58);
            this.keyboardInput1.Name = "keyboardInput1";
            this.keyboardInput1.PLCAddressGetFocusValue = null;
            this.keyboardInput1.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput1.PLCAddressWriteValue")));
            this.keyboardInput1.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput1.TabIndex = 0;
            // 
            // alarm_panel
            // 
            this.alarm_panel.DisableSubscriptions = false;
            this.alarm_panel.IniFileName = "";
            this.alarm_panel.IniFileSection = null;
            this.alarm_panel.IPAddress = "192.168.2.3";
            this.alarm_panel.MaxReadGroupSize = 200;
            this.alarm_panel.PollRateOverride = 500;
            this.alarm_panel.SwapBytes = true;
            this.alarm_panel.SwapWords = false;
            this.alarm_panel.TcpipPort = ((ushort)(502));
            this.alarm_panel.TimeOut = 3000;
            this.alarm_panel.UnitId = ((byte)(1));
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
            // analogValueDisplay1
            // 
            this.analogValueDisplay1.AutoSize = true;
            this.analogValueDisplay1.ComComponent = this.alarm_panel;
            this.analogValueDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay1.KeypadMaxValue = 0D;
            this.analogValueDisplay1.KeypadMinValue = 0D;
            this.analogValueDisplay1.KeypadPasscode = null;
            this.analogValueDisplay1.KeypadScaleFactor = 1D;
            this.analogValueDisplay1.KeypadText = null;
            this.analogValueDisplay1.KeypadWidth = 300;
            this.analogValueDisplay1.Location = new System.Drawing.Point(346, 58);
            this.analogValueDisplay1.Name = "analogValueDisplay1";
            this.analogValueDisplay1.NumericFormat = null;
            this.analogValueDisplay1.PLCAddressKeypad = "";
            this.analogValueDisplay1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay1.PLCAddressValue")));
            this.analogValueDisplay1.PLCAddressValueLimitLower = null;
            this.analogValueDisplay1.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay1.PLCAddressVisible = null;
            this.analogValueDisplay1.ShowValue = true;
            this.analogValueDisplay1.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay1.TabIndex = 1;
            this.analogValueDisplay1.Text = "0000";
            this.analogValueDisplay1.Value = "0000";
            this.analogValueDisplay1.ValueLimitLower = -999999D;
            this.analogValueDisplay1.ValueLimitUpper = 999999D;
            this.analogValueDisplay1.ValuePrefix = null;
            this.analogValueDisplay1.ValueSuffix = null;
            this.analogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // analogValueDisplay2
            // 
            this.analogValueDisplay2.AutoSize = true;
            this.analogValueDisplay2.ComComponent = this.alarm_panel;
            this.analogValueDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay2.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay2.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay2.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay2.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay2.KeypadMaxValue = 0D;
            this.analogValueDisplay2.KeypadMinValue = 0D;
            this.analogValueDisplay2.KeypadPasscode = null;
            this.analogValueDisplay2.KeypadScaleFactor = 1D;
            this.analogValueDisplay2.KeypadText = null;
            this.analogValueDisplay2.KeypadWidth = 300;
            this.analogValueDisplay2.Location = new System.Drawing.Point(346, 86);
            this.analogValueDisplay2.Name = "analogValueDisplay2";
            this.analogValueDisplay2.NumericFormat = null;
            this.analogValueDisplay2.PLCAddressKeypad = "";
            this.analogValueDisplay2.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay2.PLCAddressValue")));
            this.analogValueDisplay2.PLCAddressValueLimitLower = null;
            this.analogValueDisplay2.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay2.PLCAddressVisible = null;
            this.analogValueDisplay2.ShowValue = true;
            this.analogValueDisplay2.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay2.TabIndex = 3;
            this.analogValueDisplay2.Text = "0000";
            this.analogValueDisplay2.Value = "0000";
            this.analogValueDisplay2.ValueLimitLower = -999999D;
            this.analogValueDisplay2.ValueLimitUpper = 999999D;
            this.analogValueDisplay2.ValuePrefix = null;
            this.analogValueDisplay2.ValueSuffix = null;
            this.analogValueDisplay2.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput2
            // 
            this.keyboardInput2.ClearAfterEnterKey = true;
            this.keyboardInput2.ComComponent = this.alarm_panel;
            this.keyboardInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput2.GetFocusMatchValue = 1;
            this.keyboardInput2.GetFocusValue = 0;
            this.keyboardInput2.Location = new System.Drawing.Point(240, 86);
            this.keyboardInput2.Name = "keyboardInput2";
            this.keyboardInput2.PLCAddressGetFocusValue = null;
            this.keyboardInput2.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput2.PLCAddressWriteValue")));
            this.keyboardInput2.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(226, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(349, 25);
            this.label9.TabIndex = 1669;
            this.label9.Text = "Setpoints and Alarm Timer Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1670;
            this.label1.Text = "RTD - 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(629, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 1671;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1672;
            this.label2.Text = "High";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 1673;
            this.label3.Text = "Low";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(629, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 1674;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.analogValueDisplay8);
            this.groupBox1.Controls.Add(this.keyboardInput8);
            this.groupBox1.Controls.Add(this.analogValueDisplay9);
            this.groupBox1.Controls.Add(this.keyboardInput9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.analogValueDisplay6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.keyboardInput6);
            this.groupBox1.Controls.Add(this.keyboardInput7);
            this.groupBox1.Controls.Add(this.analogValueDisplay7);
            this.groupBox1.Controls.Add(this.analogValueDisplay5);
            this.groupBox1.Controls.Add(this.keyboardInput5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.analogValueDisplay3);
            this.groupBox1.Controls.Add(this.analogValueDisplay2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.keyboardInput2);
            this.groupBox1.Controls.Add(this.keyboardInput3);
            this.groupBox1.Controls.Add(this.analogValueDisplay1);
            this.groupBox1.Controls.Add(this.keyboardInput4);
            this.groupBox1.Controls.Add(this.keyboardInput1);
            this.groupBox1.Controls.Add(this.analogValueDisplay4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 289);
            this.groupBox1.TabIndex = 1675;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cold Storage - 1";
            // 
            // analogValueDisplay3
            // 
            this.analogValueDisplay3.AutoSize = true;
            this.analogValueDisplay3.ComComponent = this.alarm_panel;
            this.analogValueDisplay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay3.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay3.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay3.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay3.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay3.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay3.KeypadMaxValue = 0D;
            this.analogValueDisplay3.KeypadMinValue = 0D;
            this.analogValueDisplay3.KeypadPasscode = null;
            this.analogValueDisplay3.KeypadScaleFactor = 1D;
            this.analogValueDisplay3.KeypadText = null;
            this.analogValueDisplay3.KeypadWidth = 300;
            this.analogValueDisplay3.Location = new System.Drawing.Point(167, 93);
            this.analogValueDisplay3.Name = "analogValueDisplay3";
            this.analogValueDisplay3.NumericFormat = null;
            this.analogValueDisplay3.PLCAddressKeypad = "";
            this.analogValueDisplay3.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay3.PLCAddressValue")));
            this.analogValueDisplay3.PLCAddressValueLimitLower = null;
            this.analogValueDisplay3.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay3.PLCAddressVisible = null;
            this.analogValueDisplay3.ShowValue = true;
            this.analogValueDisplay3.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay3.TabIndex = 1679;
            this.analogValueDisplay3.Text = "0000";
            this.analogValueDisplay3.Value = "0000";
            this.analogValueDisplay3.ValueLimitLower = -999999D;
            this.analogValueDisplay3.ValueLimitUpper = 999999D;
            this.analogValueDisplay3.ValuePrefix = null;
            this.analogValueDisplay3.ValueSuffix = null;
            this.analogValueDisplay3.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput3
            // 
            this.keyboardInput3.ClearAfterEnterKey = true;
            this.keyboardInput3.ComComponent = this.alarm_panel;
            this.keyboardInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput3.GetFocusMatchValue = 1;
            this.keyboardInput3.GetFocusValue = 0;
            this.keyboardInput3.Location = new System.Drawing.Point(61, 89);
            this.keyboardInput3.Name = "keyboardInput3";
            this.keyboardInput3.PLCAddressGetFocusValue = null;
            this.keyboardInput3.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput3.PLCAddressWriteValue")));
            this.keyboardInput3.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput3.TabIndex = 1678;
            // 
            // analogValueDisplay4
            // 
            this.analogValueDisplay4.AutoSize = true;
            this.analogValueDisplay4.ComComponent = this.alarm_panel;
            this.analogValueDisplay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay4.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay4.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay4.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay4.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay4.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay4.KeypadMaxValue = 0D;
            this.analogValueDisplay4.KeypadMinValue = 0D;
            this.analogValueDisplay4.KeypadPasscode = null;
            this.analogValueDisplay4.KeypadScaleFactor = 1D;
            this.analogValueDisplay4.KeypadText = null;
            this.analogValueDisplay4.KeypadWidth = 300;
            this.analogValueDisplay4.Location = new System.Drawing.Point(167, 61);
            this.analogValueDisplay4.Name = "analogValueDisplay4";
            this.analogValueDisplay4.NumericFormat = null;
            this.analogValueDisplay4.PLCAddressKeypad = "";
            this.analogValueDisplay4.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay4.PLCAddressValue")));
            this.analogValueDisplay4.PLCAddressValueLimitLower = null;
            this.analogValueDisplay4.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay4.PLCAddressVisible = null;
            this.analogValueDisplay4.ShowValue = true;
            this.analogValueDisplay4.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay4.TabIndex = 1677;
            this.analogValueDisplay4.Text = "0000";
            this.analogValueDisplay4.Value = "0000";
            this.analogValueDisplay4.ValueLimitLower = -999999D;
            this.analogValueDisplay4.ValueLimitUpper = 999999D;
            this.analogValueDisplay4.ValuePrefix = null;
            this.analogValueDisplay4.ValueSuffix = null;
            this.analogValueDisplay4.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput4
            // 
            this.keyboardInput4.ClearAfterEnterKey = true;
            this.keyboardInput4.ComComponent = this.alarm_panel;
            this.keyboardInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput4.GetFocusMatchValue = 1;
            this.keyboardInput4.GetFocusValue = 0;
            this.keyboardInput4.Location = new System.Drawing.Point(61, 59);
            this.keyboardInput4.Name = "keyboardInput4";
            this.keyboardInput4.PLCAddressGetFocusValue = null;
            this.keyboardInput4.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput4.PLCAddressWriteValue")));
            this.keyboardInput4.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput4.TabIndex = 1676;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(272, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 1680;
            this.label4.Text = "Reset Timer";
            // 
            // analogValueDisplay5
            // 
            this.analogValueDisplay5.AutoSize = true;
            this.analogValueDisplay5.ComComponent = this.alarm_panel;
            this.analogValueDisplay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay5.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay5.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay5.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay5.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay5.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay5.KeypadMaxValue = 0D;
            this.analogValueDisplay5.KeypadMinValue = 0D;
            this.analogValueDisplay5.KeypadPasscode = null;
            this.analogValueDisplay5.KeypadScaleFactor = 1D;
            this.analogValueDisplay5.KeypadText = null;
            this.analogValueDisplay5.KeypadWidth = 300;
            this.analogValueDisplay5.Location = new System.Drawing.Point(346, 114);
            this.analogValueDisplay5.Name = "analogValueDisplay5";
            this.analogValueDisplay5.NumericFormat = null;
            this.analogValueDisplay5.PLCAddressKeypad = "";
            this.analogValueDisplay5.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay5.PLCAddressValue")));
            this.analogValueDisplay5.PLCAddressValueLimitLower = null;
            this.analogValueDisplay5.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay5.PLCAddressVisible = null;
            this.analogValueDisplay5.ShowValue = true;
            this.analogValueDisplay5.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay5.TabIndex = 1682;
            this.analogValueDisplay5.Text = "0000";
            this.analogValueDisplay5.Value = "0000";
            this.analogValueDisplay5.ValueLimitLower = -999999D;
            this.analogValueDisplay5.ValueLimitUpper = 999999D;
            this.analogValueDisplay5.ValuePrefix = null;
            this.analogValueDisplay5.ValueSuffix = null;
            this.analogValueDisplay5.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput5
            // 
            this.keyboardInput5.ClearAfterEnterKey = true;
            this.keyboardInput5.ComComponent = this.alarm_panel;
            this.keyboardInput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput5.GetFocusMatchValue = 1;
            this.keyboardInput5.GetFocusValue = 0;
            this.keyboardInput5.Location = new System.Drawing.Point(240, 114);
            this.keyboardInput5.Name = "keyboardInput5";
            this.keyboardInput5.PLCAddressGetFocusValue = null;
            this.keyboardInput5.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput5.PLCAddressWriteValue")));
            this.keyboardInput5.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput5.TabIndex = 1681;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 1684;
            this.label5.Text = "Low";
            // 
            // analogValueDisplay6
            // 
            this.analogValueDisplay6.AutoSize = true;
            this.analogValueDisplay6.ComComponent = this.alarm_panel;
            this.analogValueDisplay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay6.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay6.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay6.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay6.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay6.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay6.KeypadMaxValue = 0D;
            this.analogValueDisplay6.KeypadMinValue = 0D;
            this.analogValueDisplay6.KeypadPasscode = null;
            this.analogValueDisplay6.KeypadScaleFactor = 1D;
            this.analogValueDisplay6.KeypadText = null;
            this.analogValueDisplay6.KeypadWidth = 300;
            this.analogValueDisplay6.Location = new System.Drawing.Point(167, 224);
            this.analogValueDisplay6.Name = "analogValueDisplay6";
            this.analogValueDisplay6.NumericFormat = null;
            this.analogValueDisplay6.PLCAddressKeypad = "";
            this.analogValueDisplay6.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay6.PLCAddressValue")));
            this.analogValueDisplay6.PLCAddressValueLimitLower = null;
            this.analogValueDisplay6.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay6.PLCAddressVisible = null;
            this.analogValueDisplay6.ShowValue = true;
            this.analogValueDisplay6.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay6.TabIndex = 1688;
            this.analogValueDisplay6.Text = "0000";
            this.analogValueDisplay6.Value = "0000";
            this.analogValueDisplay6.ValueLimitLower = -999999D;
            this.analogValueDisplay6.ValueLimitUpper = 999999D;
            this.analogValueDisplay6.ValuePrefix = null;
            this.analogValueDisplay6.ValueSuffix = null;
            this.analogValueDisplay6.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 1683;
            this.label6.Text = "High";
            // 
            // keyboardInput6
            // 
            this.keyboardInput6.ClearAfterEnterKey = true;
            this.keyboardInput6.ComComponent = this.alarm_panel;
            this.keyboardInput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput6.GetFocusMatchValue = 1;
            this.keyboardInput6.GetFocusValue = 0;
            this.keyboardInput6.Location = new System.Drawing.Point(61, 220);
            this.keyboardInput6.Name = "keyboardInput6";
            this.keyboardInput6.PLCAddressGetFocusValue = null;
            this.keyboardInput6.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput6.PLCAddressWriteValue")));
            this.keyboardInput6.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput6.TabIndex = 1687;
            // 
            // keyboardInput7
            // 
            this.keyboardInput7.ClearAfterEnterKey = true;
            this.keyboardInput7.ComComponent = this.alarm_panel;
            this.keyboardInput7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput7.GetFocusMatchValue = 1;
            this.keyboardInput7.GetFocusValue = 0;
            this.keyboardInput7.Location = new System.Drawing.Point(61, 190);
            this.keyboardInput7.Name = "keyboardInput7";
            this.keyboardInput7.PLCAddressGetFocusValue = null;
            this.keyboardInput7.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput7.PLCAddressWriteValue")));
            this.keyboardInput7.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput7.TabIndex = 1685;
            // 
            // analogValueDisplay7
            // 
            this.analogValueDisplay7.AutoSize = true;
            this.analogValueDisplay7.ComComponent = this.alarm_panel;
            this.analogValueDisplay7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay7.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay7.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay7.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay7.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay7.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay7.KeypadMaxValue = 0D;
            this.analogValueDisplay7.KeypadMinValue = 0D;
            this.analogValueDisplay7.KeypadPasscode = null;
            this.analogValueDisplay7.KeypadScaleFactor = 1D;
            this.analogValueDisplay7.KeypadText = null;
            this.analogValueDisplay7.KeypadWidth = 300;
            this.analogValueDisplay7.Location = new System.Drawing.Point(167, 193);
            this.analogValueDisplay7.Name = "analogValueDisplay7";
            this.analogValueDisplay7.NumericFormat = null;
            this.analogValueDisplay7.PLCAddressKeypad = "";
            this.analogValueDisplay7.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay7.PLCAddressValue")));
            this.analogValueDisplay7.PLCAddressValueLimitLower = null;
            this.analogValueDisplay7.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay7.PLCAddressVisible = null;
            this.analogValueDisplay7.ShowValue = true;
            this.analogValueDisplay7.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay7.TabIndex = 1686;
            this.analogValueDisplay7.Text = "0000";
            this.analogValueDisplay7.Value = "0000";
            this.analogValueDisplay7.ValueLimitLower = -999999D;
            this.analogValueDisplay7.ValueLimitUpper = 999999D;
            this.analogValueDisplay7.ValuePrefix = null;
            this.analogValueDisplay7.ValueSuffix = null;
            this.analogValueDisplay7.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(84, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 1689;
            this.label7.Text = "RTD - 2";
            // 
            // analogValueDisplay8
            // 
            this.analogValueDisplay8.AutoSize = true;
            this.analogValueDisplay8.ComComponent = this.alarm_panel;
            this.analogValueDisplay8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay8.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay8.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay8.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay8.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay8.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay8.KeypadMaxValue = 0D;
            this.analogValueDisplay8.KeypadMinValue = 0D;
            this.analogValueDisplay8.KeypadPasscode = null;
            this.analogValueDisplay8.KeypadScaleFactor = 1D;
            this.analogValueDisplay8.KeypadText = null;
            this.analogValueDisplay8.KeypadWidth = 300;
            this.analogValueDisplay8.Location = new System.Drawing.Point(346, 209);
            this.analogValueDisplay8.Name = "analogValueDisplay8";
            this.analogValueDisplay8.NumericFormat = null;
            this.analogValueDisplay8.PLCAddressKeypad = "";
            this.analogValueDisplay8.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay8.PLCAddressValue")));
            this.analogValueDisplay8.PLCAddressValueLimitLower = null;
            this.analogValueDisplay8.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay8.PLCAddressVisible = null;
            this.analogValueDisplay8.ShowValue = true;
            this.analogValueDisplay8.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay8.TabIndex = 1693;
            this.analogValueDisplay8.Text = "0000";
            this.analogValueDisplay8.Value = "0000";
            this.analogValueDisplay8.ValueLimitLower = -999999D;
            this.analogValueDisplay8.ValueLimitUpper = 999999D;
            this.analogValueDisplay8.ValuePrefix = null;
            this.analogValueDisplay8.ValueSuffix = null;
            this.analogValueDisplay8.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput8
            // 
            this.keyboardInput8.ClearAfterEnterKey = true;
            this.keyboardInput8.ComComponent = this.alarm_panel;
            this.keyboardInput8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput8.GetFocusMatchValue = 1;
            this.keyboardInput8.GetFocusValue = 0;
            this.keyboardInput8.Location = new System.Drawing.Point(240, 209);
            this.keyboardInput8.Name = "keyboardInput8";
            this.keyboardInput8.PLCAddressGetFocusValue = null;
            this.keyboardInput8.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput8.PLCAddressWriteValue")));
            this.keyboardInput8.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput8.TabIndex = 1692;
            // 
            // analogValueDisplay9
            // 
            this.analogValueDisplay9.AutoSize = true;
            this.analogValueDisplay9.ComComponent = this.alarm_panel;
            this.analogValueDisplay9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay9.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay9.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay9.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay9.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay9.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay9.KeypadMaxValue = 0D;
            this.analogValueDisplay9.KeypadMinValue = 0D;
            this.analogValueDisplay9.KeypadPasscode = null;
            this.analogValueDisplay9.KeypadScaleFactor = 1D;
            this.analogValueDisplay9.KeypadText = null;
            this.analogValueDisplay9.KeypadWidth = 300;
            this.analogValueDisplay9.Location = new System.Drawing.Point(346, 181);
            this.analogValueDisplay9.Name = "analogValueDisplay9";
            this.analogValueDisplay9.NumericFormat = null;
            this.analogValueDisplay9.PLCAddressKeypad = "";
            this.analogValueDisplay9.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay9.PLCAddressValue")));
            this.analogValueDisplay9.PLCAddressValueLimitLower = null;
            this.analogValueDisplay9.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay9.PLCAddressVisible = null;
            this.analogValueDisplay9.ShowValue = true;
            this.analogValueDisplay9.Size = new System.Drawing.Size(45, 20);
            this.analogValueDisplay9.TabIndex = 1691;
            this.analogValueDisplay9.Text = "0000";
            this.analogValueDisplay9.Value = "0000";
            this.analogValueDisplay9.ValueLimitLower = -999999D;
            this.analogValueDisplay9.ValueLimitUpper = 999999D;
            this.analogValueDisplay9.ValuePrefix = null;
            this.analogValueDisplay9.ValueSuffix = null;
            this.analogValueDisplay9.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // keyboardInput9
            // 
            this.keyboardInput9.ClearAfterEnterKey = true;
            this.keyboardInput9.ComComponent = this.alarm_panel;
            this.keyboardInput9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.keyboardInput9.GetFocusMatchValue = 1;
            this.keyboardInput9.GetFocusValue = 0;
            this.keyboardInput9.Location = new System.Drawing.Point(240, 181);
            this.keyboardInput9.Name = "keyboardInput9";
            this.keyboardInput9.PLCAddressGetFocusValue = null;
            this.keyboardInput9.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput9.PLCAddressWriteValue")));
            this.keyboardInput9.Size = new System.Drawing.Size(100, 26);
            this.keyboardInput9.TabIndex = 1690;
            // 
            // Setpoints_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Name = "Setpoints_Alarm";
            this.Text = "Setpoints Alarm Timer Settings";
            ((System.ComponentModel.ISupportInitialize)(this.alarm_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedHMIControls.KeyboardInput keyboardInput1;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay1;
        private AdvancedHMIDrivers.ModbusTCPCom alarm_panel;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay2;
        private AdvancedHMIControls.KeyboardInput keyboardInput2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay3;
        private AdvancedHMIControls.KeyboardInput keyboardInput3;
        private AdvancedHMIControls.KeyboardInput keyboardInput4;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay4;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay5;
        private AdvancedHMIControls.KeyboardInput keyboardInput5;
        private System.Windows.Forms.Label label4;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay8;
        private AdvancedHMIControls.KeyboardInput keyboardInput8;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay9;
        private AdvancedHMIControls.KeyboardInput keyboardInput9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay6;
        private System.Windows.Forms.Label label6;
        private AdvancedHMIControls.KeyboardInput keyboardInput6;
        private AdvancedHMIControls.KeyboardInput keyboardInput7;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay7;
    }
}