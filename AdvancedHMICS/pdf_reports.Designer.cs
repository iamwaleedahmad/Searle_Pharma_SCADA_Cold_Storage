
namespace GETZ_SCADA
{
    partial class pdf_reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pdf_reports));
            this.Button5 = new System.Windows.Forms.Button();
            this.btn_show_record = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txt_interval = new System.Windows.Forms.ComboBox();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.date_2 = new System.Windows.Forms.DateTimePicker();
            this.txt_value = new System.Windows.Forms.ComboBox();
            this.lbl_date_2 = new System.Windows.Forms.Label();
            this.date_1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.temp_group = new System.Windows.Forms.GroupBox();
            this.exp_avg = new System.Windows.Forms.Label();
            this.log_value = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_mkt = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_max_temp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_min_temp = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_avg_temp = new System.Windows.Forms.Label();
            this.btn_save_pdf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.temp_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button5.BackColor = System.Drawing.Color.Chocolate;
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.FlatAppearance.BorderSize = 0;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button5.Location = new System.Drawing.Point(1281, 161);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(125, 30);
            this.Button5.TabIndex = 1699;
            this.Button5.Text = "Reset";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // btn_show_record
            // 
            this.btn_show_record.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_show_record.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_show_record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_record.Enabled = false;
            this.btn_show_record.FlatAppearance.BorderSize = 0;
            this.btn_show_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_record.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_show_record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_record.Location = new System.Drawing.Point(1151, 161);
            this.btn_show_record.Name = "btn_show_record";
            this.btn_show_record.Size = new System.Drawing.Size(125, 30);
            this.btn_show_record.TabIndex = 1698;
            this.btn_show_record.Text = "Show";
            this.btn_show_record.UseVisualStyleBackColor = false;
            // 
            // dgv
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-8, 195);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.Size = new System.Drawing.Size(1569, 366);
            this.dgv.TabIndex = 1700;
            // 
            // txt_interval
            // 
            this.txt_interval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txt_interval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_interval.ForeColor = System.Drawing.Color.White;
            this.txt_interval.FormattingEnabled = true;
            this.txt_interval.Items.AddRange(new object[] {
            "1 minute",
            "2 minutes",
            "5 minutes",
            "10 minutes",
            "30 minutes",
            "1 hour"});
            this.txt_interval.Location = new System.Drawing.Point(442, 162);
            this.txt_interval.Name = "txt_interval";
            this.txt_interval.Size = new System.Drawing.Size(88, 28);
            this.txt_interval.TabIndex = 1696;
            // 
            // lbl_interval
            // 
            this.lbl_interval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interval.ForeColor = System.Drawing.Color.Black;
            this.lbl_interval.Location = new System.Drawing.Point(358, 162);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(82, 25);
            this.lbl_interval.TabIndex = 1697;
            this.lbl_interval.Text = "Interval";
            // 
            // date_2
            // 
            this.date_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_2.CalendarFont = new System.Drawing.Font("Calibri", 11F);
            this.date_2.CalendarTitleForeColor = System.Drawing.Color.White;
            this.date_2.CustomFormat = "yyyy-MM-dd HH:mm:ss tt";
            this.date_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.date_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_2.Location = new System.Drawing.Point(882, 162);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(241, 29);
            this.date_2.TabIndex = 1694;
            // 
            // txt_value
            // 
            this.txt_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.txt_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_value.ForeColor = System.Drawing.Color.White;
            this.txt_value.FormattingEnabled = true;
            this.txt_value.Items.AddRange(new object[] {
            "Temperature Report",
            "MKT Report",
            "Door Report",
            "Compressor Report"});
            this.txt_value.Location = new System.Drawing.Point(119, 162);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(236, 28);
            this.txt_value.TabIndex = 1693;
            // 
            // lbl_date_2
            // 
            this.lbl_date_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_date_2.AutoSize = true;
            this.lbl_date_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_date_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_2.ForeColor = System.Drawing.Color.Black;
            this.lbl_date_2.Location = new System.Drawing.Point(843, 162);
            this.lbl_date_2.Name = "lbl_date_2";
            this.lbl_date_2.Size = new System.Drawing.Size(37, 25);
            this.lbl_date_2.TabIndex = 1692;
            this.lbl_date_2.Text = "To";
            // 
            // date_1
            // 
            this.date_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_1.CalendarFont = new System.Drawing.Font("Calibri", 11F);
            this.date_1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.date_1.CustomFormat = "yyyy-MM-dd HH:mm:ss tt";
            this.date_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.date_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_1.Location = new System.Drawing.Point(600, 162);
            this.date_1.Name = "date_1";
            this.date_1.Size = new System.Drawing.Size(241, 29);
            this.date_1.TabIndex = 1691;
            // 
            // lbl_date_1
            // 
            this.lbl_date_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_date_1.AutoSize = true;
            this.lbl_date_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_date_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_date_1.Location = new System.Drawing.Point(539, 162);
            this.lbl_date_1.Name = "lbl_date_1";
            this.lbl_date_1.Size = new System.Drawing.Size(61, 25);
            this.lbl_date_1.TabIndex = 1690;
            this.lbl_date_1.Text = "From";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-13, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 1695;
            this.label9.Text = "Select Value";
            // 
            // temp_group
            // 
            this.temp_group.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.temp_group.Controls.Add(this.exp_avg);
            this.temp_group.Controls.Add(this.log_value);
            this.temp_group.Controls.Add(this.label22);
            this.temp_group.Controls.Add(this.txt_mkt);
            this.temp_group.Controls.Add(this.label20);
            this.temp_group.Controls.Add(this.txt_max_temp);
            this.temp_group.Controls.Add(this.label18);
            this.temp_group.Controls.Add(this.txt_min_temp);
            this.temp_group.Controls.Add(this.label16);
            this.temp_group.Controls.Add(this.txt_avg_temp);
            this.temp_group.Location = new System.Drawing.Point(-8, 556);
            this.temp_group.Name = "temp_group";
            this.temp_group.Size = new System.Drawing.Size(1569, 50);
            this.temp_group.TabIndex = 1702;
            this.temp_group.TabStop = false;
            this.temp_group.Visible = false;
            // 
            // exp_avg
            // 
            this.exp_avg.AutoSize = true;
            this.exp_avg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_avg.ForeColor = System.Drawing.Color.Black;
            this.exp_avg.Location = new System.Drawing.Point(1059, 22);
            this.exp_avg.Name = "exp_avg";
            this.exp_avg.Size = new System.Drawing.Size(18, 19);
            this.exp_avg.TabIndex = 1356;
            this.exp_avg.Text = "0";
            // 
            // log_value
            // 
            this.log_value.AutoSize = true;
            this.log_value.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_value.ForeColor = System.Drawing.Color.Black;
            this.log_value.Location = new System.Drawing.Point(959, 20);
            this.log_value.Name = "log_value";
            this.log_value.Size = new System.Drawing.Size(18, 19);
            this.log_value.TabIndex = 1355;
            this.log_value.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(1176, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(159, 19);
            this.label22.TabIndex = 1350;
            this.label22.Text = "Mean Kinetic Temp:";
            // 
            // txt_mkt
            // 
            this.txt_mkt.AutoSize = true;
            this.txt_mkt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mkt.ForeColor = System.Drawing.Color.Black;
            this.txt_mkt.Location = new System.Drawing.Point(1338, 20);
            this.txt_mkt.Name = "txt_mkt";
            this.txt_mkt.Size = new System.Drawing.Size(18, 19);
            this.txt_mkt.TabIndex = 1349;
            this.txt_mkt.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(740, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 19);
            this.label20.TabIndex = 1348;
            this.label20.Text = "Maximum Temp:";
            // 
            // txt_max_temp
            // 
            this.txt_max_temp.AutoSize = true;
            this.txt_max_temp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_max_temp.ForeColor = System.Drawing.Color.Black;
            this.txt_max_temp.Location = new System.Drawing.Point(873, 20);
            this.txt_max_temp.Name = "txt_max_temp";
            this.txt_max_temp.Size = new System.Drawing.Size(18, 19);
            this.txt_max_temp.TabIndex = 1347;
            this.txt_max_temp.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(375, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 19);
            this.label18.TabIndex = 1346;
            this.label18.Text = "Minimum Temp:";
            // 
            // txt_min_temp
            // 
            this.txt_min_temp.AutoSize = true;
            this.txt_min_temp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_min_temp.ForeColor = System.Drawing.Color.Black;
            this.txt_min_temp.Location = new System.Drawing.Point(505, 20);
            this.txt_min_temp.Name = "txt_min_temp";
            this.txt_min_temp.Size = new System.Drawing.Size(18, 19);
            this.txt_min_temp.TabIndex = 1345;
            this.txt_min_temp.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 19);
            this.label16.TabIndex = 1343;
            this.label16.Text = "Average Temp:";
            // 
            // txt_avg_temp
            // 
            this.txt_avg_temp.AutoSize = true;
            this.txt_avg_temp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avg_temp.ForeColor = System.Drawing.Color.Black;
            this.txt_avg_temp.Location = new System.Drawing.Point(128, 20);
            this.txt_avg_temp.Name = "txt_avg_temp";
            this.txt_avg_temp.Size = new System.Drawing.Size(18, 19);
            this.txt_avg_temp.TabIndex = 1342;
            this.txt_avg_temp.Text = "0";
            // 
            // btn_save_pdf
            // 
            this.btn_save_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save_pdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_save_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_pdf.FlatAppearance.BorderSize = 0;
            this.btn_save_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_pdf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_pdf.Image = ((System.Drawing.Image)(resources.GetObject("btn_save_pdf.Image")));
            this.btn_save_pdf.Location = new System.Drawing.Point(1411, 161);
            this.btn_save_pdf.Name = "btn_save_pdf";
            this.btn_save_pdf.Size = new System.Drawing.Size(150, 30);
            this.btn_save_pdf.TabIndex = 1701;
            this.btn_save_pdf.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(358, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 1703;
            this.label10.Text = "1";
            this.label10.Visible = false;
            // 
            // pdf_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 767);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.btn_show_record);
            this.Controls.Add(this.btn_save_pdf);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txt_interval);
            this.Controls.Add(this.lbl_interval);
            this.Controls.Add(this.date_2);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_date_2);
            this.Controls.Add(this.date_1);
            this.Controls.Add(this.lbl_date_1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.temp_group);
            this.Name = "pdf_reports";
            this.Text = "PDF Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.temp_group.ResumeLayout(false);
            this.temp_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button btn_show_record;
        private System.Windows.Forms.Button btn_save_pdf;
        private System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.ComboBox txt_interval;
        private System.Windows.Forms.Label lbl_interval;
        internal System.Windows.Forms.DateTimePicker date_2;
        internal System.Windows.Forms.ComboBox txt_value;
        private System.Windows.Forms.Label lbl_date_2;
        internal System.Windows.Forms.DateTimePicker date_1;
        private System.Windows.Forms.Label lbl_date_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox temp_group;
        private System.Windows.Forms.Label exp_avg;
        private System.Windows.Forms.Label log_value;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txt_mkt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txt_max_temp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txt_min_temp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txt_avg_temp;
        private System.Windows.Forms.Label label10;
    }
}