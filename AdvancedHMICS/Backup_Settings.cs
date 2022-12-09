using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMICS;
using MySql.Data.MySqlClient;

namespace GETZ_SCADA
{
    public partial class Backup_Settings : Form
    {
        MySqlConnection con;
        FolderBrowserDialog backup_folder = new FolderBrowserDialog();
        public Backup_Settings()
        {
            InitializeComponent();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =getz_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True; SSL Mode=None;");
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = ("UPDATE db_backup_settings set path ='" + txtpath.Text.ToString() + "',time ='" + time_picker.Text.ToString() + "' where id = 1 ;");
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
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (backup_folder.ShowDialog() == DialogResult.OK)
            {
                // Declaring File Name
                string path = backup_folder.SelectedPath;
                string output = path.Replace(@"\", @"\\");
                txtpath.Text = output;
            }
        }

        private void backup_now_Click(object sender, EventArgs e)
        {
            Backup();
        }
        private void Backup()
        {
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        string folder = txtpath.Text.ToString();
                        string datetimeString = string.Format("{0:yyyy-MM-dd__hh-mm-ss-tt}.sql", DateTime.Now);
                        string filename = "\\GETZ_CEPH_DB_Backup_" + datetimeString;
                        string file = folder + filename;
                        cmd.Connection = con;
                        con.Open();
                        try
                        {
                            mb.ExportToFile(file);
                            MessageBox.Show("Saved Successfully !");
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.Close();
                            con.Dispose();
                        }
                    }
                }
            }
        }

        private void Backup_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm master = (MainForm)Application.OpenForms["MainForm"];
            master.backup_settings_load_to_labels();
        }

        private void Backup_Settings_Load(object sender, EventArgs e)
        {
            // For Fetching Backup Seting to Textboxes
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_backup_settings WHERE id = 1 ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                {
                    //For Replacing Single BackSlash "\" with DoubleBackSlash"\\"
                    string path = dr["path"].ToString();
                    string output = path.Replace(@"\", @"\\");
                    txtpath.Text = output;
                    time_picker.Text = dr["time"].ToString();
                }
                con.Close();
                cmd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
