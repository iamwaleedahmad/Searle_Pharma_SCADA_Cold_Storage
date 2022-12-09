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

namespace GETZ_SCADA
{
    public partial class userlog : Form
    {
        MySqlConnection con;
        public userlog()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =getz_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True; SSL Mode=None;");
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MySqlCommand com = new MySqlCommand("SELECT username,role,login_time,logout_time FROM user_log WHERE  DATE(login_time) = '" + txt_date.Text + "' ", con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds, "user_log");
            table_log.DataSource = ds;
            table_log.DataMember = "user_log";
            table_log.Columns[0].HeaderText = "User Name";
            table_log.Columns[1].HeaderText = "User Role";
            table_log.Columns[2].HeaderText = "Login Time";
            table_log.Columns[3].HeaderText = "Logout Time";
            table_log.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            table_log.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm:ss tt";
            table_log.Columns[0].Width = 100;
            table_log.Columns[1].Width = 100;
            table_log.Columns[2].Width = 150;
            table_log.Columns[3].Width = 150;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            table_log.DataSource = null;
            table_log.Rows.Clear();
            table_log.Columns.Clear();
        }
    }
}
