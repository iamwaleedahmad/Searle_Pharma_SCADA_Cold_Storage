
namespace GETZ_SCADA
{
    partial class Backup_Settings
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
            this.backup_now = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.time_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backup_now
            // 
            this.backup_now.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backup_now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup_now.FlatAppearance.BorderSize = 0;
            this.backup_now.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backup_now.Font = new System.Drawing.Font("Arial", 10F);
            this.backup_now.Location = new System.Drawing.Point(144, 241);
            this.backup_now.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backup_now.Name = "backup_now";
            this.backup_now.Size = new System.Drawing.Size(167, 54);
            this.backup_now.TabIndex = 17;
            this.backup_now.Text = "Click here to take database backup now";
            this.backup_now.UseVisualStyleBackColor = false;
            this.backup_now.Click += new System.EventHandler(this.backup_now_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "*Database Backup file will be created at given path on selected time everyday.";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.MediumAquamarine;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Arial", 10F);
            this.save.Location = new System.Drawing.Point(144, 138);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(167, 40);
            this.save.TabIndex = 15;
            this.save.Text = "Save Settings";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // time_picker
            // 
            this.time_picker.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.time_picker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time_picker.Location = new System.Drawing.Point(108, 80);
            this.time_picker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_picker.Name = "time_picker";
            this.time_picker.Size = new System.Drawing.Size(142, 22);
            this.time_picker.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Time :";
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(320, 13);
            this.browse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(124, 28);
            this.browse.TabIndex = 12;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select Folder (Path):";
            // 
            // txtpath
            // 
            this.txtpath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpath.Location = new System.Drawing.Point(24, 44);
            this.txtpath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(420, 22);
            this.txtpath.TabIndex = 11;
            // 
            // Backup_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 311);
            this.Controls.Add(this.backup_now);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.time_picker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpath);
            this.Name = "Backup_Settings";
            this.Text = "Backup_Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Backup_Settings_FormClosed);
            this.Load += new System.EventHandler(this.Backup_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backup_now;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker time_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpath;
    }
}