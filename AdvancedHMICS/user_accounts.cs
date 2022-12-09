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
using System.Security.Cryptography;

namespace AdvancedHMICS
{
    public partial class user_accounts : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public user_accounts()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =getz_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True; SSL Mode=None;");
        }

        static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public void user_accounts_Load(object sender, EventArgs e)
        {
            datagridview();
        }
        public void datagridview()
        {
            //For Loading Datagridview Users
            try
            {
                DataTable dtable = new DataTable();
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT u_name,u_role,last_login FROM users", con);
                adapter.Fill(dtable);
                table_users.DataSource = dtable;       
                table_users.Columns[0].HeaderText = "Username";
                table_users.Columns[1].HeaderText = "User Role";
                table_users.Columns[2].HeaderText = "Last Login Time";

                table_users.Columns[0].Width = 100;
                table_users.Columns[1].Width = 100;
                table_users.Columns[2].Width = 185;

                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "" || txt_password_retype.Text == "")
            {
                MessageBox.Show("Please Fill all the fields");
            }
            else
            {
                if (txt_password.Text == txt_password_retype.Text)
                {
                    try
                    {
                        string query = "INSERT INTO users (u_name,u_pass,u_role) values ('" + txt_username.Text + "','" + Encrypt(txt_password_retype.Text) + "','" + txt_role.Text + "') ";
                        MySqlCommand cmnd = new MySqlCommand(query, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        cmnd.Dispose();
                        MessageBox.Show("New User Added Successfully");
                        con.Close();
                        user_accounts_Load(sender, e);
                        txt_username.Clear();
                        txt_password.Clear();
                        txt_password_retype.Clear();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                else if (txt_password.Text != txt_password_retype.Text)
                {
                    MessageBox.Show("Password Do Not Match - Retype again");
                    txt_password.Clear();
                    txt_password_retype.Clear();
                }
                //Screen1 master = (Screen1)Application.OpenForms["Screen1"];
                //master.button56.PerformClick();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            user_edit edt = new user_edit();
            int row = table_users.CurrentRow.Index;
            edt.u_ID.Text = Convert.ToString(table_users[0, row].Value);
            edt.txt_username.Text = Convert.ToString(table_users[1, row].Value);
            edt.txt_user_role.Text = Convert.ToString(table_users[2, row].Value);
            edt.Show();
            this.Close();
        }
    }
}
