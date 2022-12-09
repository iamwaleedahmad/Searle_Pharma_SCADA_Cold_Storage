using AdvancedHMICS;
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
using System.Security.Cryptography;

namespace GETZ_SCADA
{
    public partial class Login : Form
    {
        public static string u_name;
        private MySqlConnection con;
        public Login()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =searle_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True;SslMode=None;");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_uname.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM users WHERE u_name = '" + txt_uname.Text + "' AND 	u_pass = '" + Encrypt(txt_pass.Text) + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        u_name = txt_uname.Text;
                        string Query = "UPDATE users SET last_login = Now() WHERE u_name = '" + txt_uname.Text + "';";
                        MySqlCommand cmd2 = new MySqlCommand(Query, con);
                        MySqlCommand commandDatabase = cmd2;
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        this.Hide();
                        var dash = new MainForm();
                        dash.Show();
                        dash.lbl_username.Text = txt_uname.Text;

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.ForeColor = Color.White;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.ForeColor = Color.Black;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.Black;
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.ForeColor = Color.White;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txt_uname.Text) || string.IsNullOrEmpty(txt_pass.Text))
                {
                    MessageBox.Show("Please input Username and Password", "Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM users WHERE u_name = '" + txt_uname.Text + "' AND 	u_pass = '" + Encrypt(txt_pass.Text) + "' ", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            u_name = txt_uname.Text;
                            string Query = "UPDATE users SET last_login = Now() WHERE u_name = '" + txt_uname.Text + "';";
                            MySqlCommand cmd2 = new MySqlCommand(Query, con);
                            MySqlCommand commandDatabase = cmd2;
                            MySqlDataReader myReader = commandDatabase.ExecuteReader();
                            this.Hide();
                            var dash = new MainForm();
                            dash.Show();
                            dash.lbl_username.Text = txt_uname.Text;

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password");
                        }
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }                
        }
    }
}
