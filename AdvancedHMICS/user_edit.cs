using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace AdvancedHMICS
{
    public partial class user_edit : Form
    {
        MySqlConnection con;
        public user_accounts useracc_;
        public user_edit()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =getz_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True; SSL Mode=None;");
        }

        private void user_edit_Load(object sender, EventArgs e)
        {
            useracc_ = new user_accounts();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT u_pass FROM users WHERE u_name = '" + txt_username.Text + "' ", con);
                con.Open();
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        txt_password.Text = (read["u_pass"]).ToString();
                        txt_password_retype.Text = (read["u_pass"]).ToString();
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

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_password_retype.Text)
            {
                try
                {
                    string query = ("UPDATE users set u_name ='" + txt_username.Text.ToString() + "', u_pass ='" + txt_password_retype.Text.ToString() + "', u_role ='" + txt_user_role.Text.ToString() + "' WHERE u_id='" + u_ID.Text.ToString() + "' ");
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    MySqlDataReader read;
                    con.Open();
                    read = cmnd.ExecuteReader();
                    MessageBox.Show("User Account Updated");
                    con.Close();
                    useracc_.Show();
                    this.Close();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Password Don't Match");
            }
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Do you really want to Delete the User?", "Delete?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                try
                {
                    string query = ("DELETE FROM users WHERE u_id = '" + u_ID.Text + "'");
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    MySqlDataReader read;
                    con.Open();
                    read = cmnd.ExecuteReader();
                    MessageBox.Show("User Deleted");
                    con.Close();
                    this.Close();

                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void user_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<user_accounts>().Any())
            {
                Application.OpenForms.OfType<user_accounts>().First().BringToFront();
                useracc_.user_accounts_Load(sender, e);
            }
            else
            {
                useracc_.Show();
            }
        }
    }
}
