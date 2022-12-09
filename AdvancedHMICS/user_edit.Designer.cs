
namespace AdvancedHMICS
{
    partial class user_edit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.u_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user_role = new System.Windows.Forms.ComboBox();
            this.btn_update_user = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password_retype = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.u_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_delete_user);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_user_role);
            this.groupBox1.Controls.Add(this.btn_update_user);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_password_retype);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 289);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // u_ID
            // 
            this.u_ID.BackColor = System.Drawing.Color.White;
            this.u_ID.Font = new System.Drawing.Font("Arial", 12F);
            this.u_ID.ForeColor = System.Drawing.Color.Black;
            this.u_ID.Location = new System.Drawing.Point(311, 31);
            this.u_ID.Name = "u_ID";
            this.u_ID.Size = new System.Drawing.Size(41, 26);
            this.u_ID.TabIndex = 42;
            this.u_ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "u_ID";
            this.label1.Visible = false;
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_user.FlatAppearance.BorderSize = 0;
            this.btn_delete_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_user.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_delete_user.ForeColor = System.Drawing.Color.White;
            this.btn_delete_user.Location = new System.Drawing.Point(187, 231);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(103, 34);
            this.btn_delete_user.TabIndex = 41;
            this.btn_delete_user.Text = "Delete User";
            this.btn_delete_user.UseVisualStyleBackColor = false;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "User Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(92, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Edit User Account";
            // 
            // txt_user_role
            // 
            this.txt_user_role.BackColor = System.Drawing.Color.White;
            this.txt_user_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_user_role.ForeColor = System.Drawing.Color.Black;
            this.txt_user_role.FormattingEnabled = true;
            this.txt_user_role.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Operator"});
            this.txt_user_role.Location = new System.Drawing.Point(111, 176);
            this.txt_user_role.Name = "txt_user_role";
            this.txt_user_role.Size = new System.Drawing.Size(144, 24);
            this.txt_user_role.TabIndex = 39;
            this.txt_user_role.Text = "Operator";
            // 
            // btn_update_user
            // 
            this.btn_update_user.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_update_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_user.FlatAppearance.BorderSize = 0;
            this.btn_update_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_user.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_update_user.ForeColor = System.Drawing.Color.White;
            this.btn_update_user.Location = new System.Drawing.Point(78, 231);
            this.btn_update_user.Name = "btn_update_user";
            this.btn_update_user.Size = new System.Drawing.Size(103, 34);
            this.btn_update_user.TabIndex = 29;
            this.btn_update_user.Text = "Update";
            this.btn_update_user.UseVisualStyleBackColor = false;
            this.btn_update_user.Click += new System.EventHandler(this.btn_update_user_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 38);
            this.label5.TabIndex = 38;
            this.label5.Text = "Re-Type\r\nPassword";
            // 
            // txt_password_retype
            // 
            this.txt_password_retype.BackColor = System.Drawing.Color.White;
            this.txt_password_retype.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_password_retype.ForeColor = System.Drawing.Color.Black;
            this.txt_password_retype.Location = new System.Drawing.Point(111, 138);
            this.txt_password_retype.Name = "txt_password_retype";
            this.txt_password_retype.Size = new System.Drawing.Size(144, 26);
            this.txt_password_retype.TabIndex = 37;
            this.txt_password_retype.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Location = new System.Drawing.Point(111, 60);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(144, 26);
            this.txt_username.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(111, 99);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(144, 26);
            this.txt_password.TabIndex = 35;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // user_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.user_edit_FormClosed);
            this.Load += new System.EventHandler(this.user_edit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox u_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox txt_user_role;
        private System.Windows.Forms.Button btn_update_user;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_password_retype;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_password;
    }
}