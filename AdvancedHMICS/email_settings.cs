using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using MySql.Data;
using AdvancedHMICS;

namespace GETZ_SCADA
{
    public partial class email_settings : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public email_settings()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =getz_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True; SSL Mode=None;");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string query = ("UPDATE email_settings set sender_email ='" + txtSenderEmail.Text + "',sender_password ='" + txtSenderPassword.Text + "',smtp_server ='" + txtSmtpServer.Text + "',port_number ='" + txtPortNumber.Text + "',recipient_email = '" + txtRecipientEmail.Text.Trim() + "', subject = '" + txtSubject.Text + "' where email_ID = 1 ;");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                MySqlDataReader read;
                con.Open();
                read = cmnd.ExecuteReader();
                MessageBox.Show("Settings Updated");
                con.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            MainForm master = (MainForm)Application.OpenForms["MainForm"];
            master.load_email_settings();
            this.Close();
        }

        private void email_settings_Load(object sender, EventArgs e)
        {
            email_setting();
        }

        public void email_setting()
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM email_settings WHERE email_ID = 1 ", con);
                con.Open();
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        txtSenderEmail.Text = (read["sender_email"]).ToString();
                        txtSenderPassword.Text = (read["sender_password"]).ToString();
                        txtSmtpServer.Text = (read["smtp_server"]).ToString();
                        txtPortNumber.Text = (read["port_number"]).ToString();
                        txtRecipientEmail.Text = (read["recipient_email"]).ToString();
                        txtSubject.Text = (read["subject"]).ToString();
                    }
                }
                con.Close();
                cmd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSenderPassword.PasswordChar = '\0';
            }
            else
            {
                txtSenderPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm master = (MainForm)Application.OpenForms["MainForm"];
            master.load_email_settings();
            this.Close();
        }
    }
}
