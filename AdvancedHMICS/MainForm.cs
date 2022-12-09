using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMIDrivers;
using AdvancedHMIControls;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using MfgControl.AdvancedHMI.Controls;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Timers;
using MySql.Data.MySqlClient;
using Microsoft.Web.WebView2;
using System.Net.Mail;
using System.Net;
using AdvancedHMICS;
using GETZ_SCADA;
using Font = System.Drawing.Font;
using System.Media;
using System.Security.Cryptography;



namespace AdvancedHMICS
{
    public partial class MainForm : Form
    {
        private MySqlConnection con;
        SaveFileDialog savefiledialog1 = new SaveFileDialog();
        string cs_1_temp_hot_status = "Normal";
        string cs_1_temp_cold_status = "Normal";
        string cs_2_temp_hot_status = "Normal";
        string cs_2_temp_cold_status = "Normal";

        private static System.Timers.Timer DB_Timer;
        private static System.Timers.Timer Graph_Timer;

        public double temperature_val = 0;

        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();

        string _port;
        string host;
        string e_id;
        string e_pass;
        string rcvr;
        string subj;
        string bdy;
        string error_message;
        //private EventHandler MouseLeftGroupBox;

        public MainForm()
        {
            InitializeComponent();
            SetTimer();
            GraphTimer();
            con = new MySqlConnection("Server =localhost; Port =3306; Database =searle_cold_storage; user id =root; password =; Connection Reset=false;convert zero datetime = True;SslMode=None;");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Login.u_name;
            load_email_settings();
            log_id();
            log_entry();
            user_role_load();
            backup_settings_load_to_labels();
            savefiledialog1.FileName = "";
            savefiledialog1.Filter = "PDF (*.pdf)|*.pdf";

            Login_Group_Box.MouseLeave += new EventHandler(MouseLeftGroupBox);
        }

        public void user_role_load()
        {
            string _username = lbl_username.Text;

            MySqlCommand cmd = new MySqlCommand("SELECT u_role FROM users WHERE u_name = '" + _username + "' ", con);
            con.Open();
            using (MySqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    lbl_user_role.Text = (read["u_role"]).ToString();
                }
            con.Close();
            }
        }

        public void backup_settings_load_to_labels()
        {
            // For Fetching Backup Seting to Labels
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_backup_settings WHERE id = 1 ", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                {
                    txt_backup_path.Text = dr["path"].ToString();
                    txt_time_backup.Text = dr["time"].ToString();
                }
                con.Close();
                dr.Close();
                dr.Dispose();
                cmd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

        private void log_id()
        {
            // For Fetching Maximum Log ID
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MAX(log_id) FROM user_log", con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                {
                    lbl_log_id.Text = dr["MAX(log_id)"].ToString();
                }
                dr.Close();
                dr.Dispose();
                con.Close();
                cmd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void log_entry()
        {
            //for Saving User Info in user log 
            try
            {
                string query = "INSERT INTO user_log (username,role,login_time) values ('" + lbl_username.Text + "','" + lbl_user_role.Text + "', Now() )";
                MySqlCommand cmnd = new MySqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmnd.ExecuteNonQuery();
                cmnd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //private void trend_load()
        //{
        //    try
        //    {
        //        live_trend_graph.Series.Clear();
        //        //live_trend_graph.ChartAreas.Clear();
        //        live_trend_graph.Images.Clear();
        //        live_trend_graph.Titles.Clear();
        //        live_trend_graph.Images.Clear();
        //        live_trend_graph.Annotations.Clear();
        //        live_trend_graph.Update();

        //        Title title = live_trend_graph.Titles.Add("Live Trend Temperature");
        //        title.Font = new Font("Arial", 14, FontStyle.Bold);

        //        //live_trend_graph.Images.Add(new NamedImage("gradient", GETZ_SCADA.Properties.Resources.Star_Logo_for_GETZ_COLD_STORAGE1));
        //        //ImageAnnotation imgA = new ImageAnnotation();
        //        //imgA.Image = "gradient";
        //        //imgA.ImageWrapMode = ChartImageWrapMode.Scaled;
        //        //imgA.IsSizeAlwaysRelative = false;
        //        //imgA.X = 2;
        //        //imgA.Y = 2;
        //        //imgA.Height = 30;
        //        //imgA.Width = 10;
        //        //live_trend_graph.Annotations.Add(imgA);

        //        var chartArea = new ChartArea("live_trend_graph");
        //        chartArea.AxisX.Title = "Time ( YYYY-MM-DD HH:MM)";
        //        chartArea.AxisY.Title = "Temperature ( °C )";

        //        //For 1st Value
        //        live_trend_graph.Series.Add("Temperature");
        //        live_trend_graph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        //        live_trend_graph.Series[0].Color = Color.DodgerBlue;
        //        live_trend_graph.Series[0].BorderWidth = 3;
        //        live_trend_graph.Series[0].MarkerStyle = MarkerStyle.Star10;
        //        //live_trend_graph.Series[0].BackSecondaryColor = Color.Gray;
        //        //live_trend_graph.Series[0].BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
        //        live_trend_graph.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
        //        live_trend_graph.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm";
        //        live_trend_graph.ChartAreas[0].AxisX.Title = "Time ( YYYY-MM-DD HH:MM)";
        //        live_trend_graph.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Center;
        //        live_trend_graph.ChartAreas[0].AxisX.TextOrientation = TextOrientation.Horizontal;
        //        live_trend_graph.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);

        //        live_trend_graph.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
        //        live_trend_graph.ChartAreas[0].AxisY.Title = "Temperature ( °C )";
        //        live_trend_graph.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Center;
        //        live_trend_graph.ChartAreas[0].AxisY.TextOrientation = TextOrientation.Rotated270;
        //        live_trend_graph.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);
        //        live_trend_graph.ChartAreas[0].AxisY.Maximum = 30;
        //        live_trend_graph.ChartAreas[0].AxisY.Interval = 1;
        //        live_trend_graph.ChartAreas[0].AxisY.Minimum = 15;

        //        //Query for Fetching Data
        //        MySqlCommand cmd = new MySqlCommand("SELECT timing,t_val FROM temp WHERE t_val > 0 ORDER BY t_id DESC LIMIT 500", con);
        //        if (con != null && con.State == ConnectionState.Closed)
        //        {
        //            con.Open();
        //            MySqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                live_trend_graph.Series[0].Points.AddXY(dr.GetDateTime("timing"), dr.GetDouble("t_val"));
        //                // live_trend_graph.Series[1].Points.AddXY(dr.GetDateTime("timing"), 35);
        //            }

        //            dr.Close();
        //            dr.Dispose();
        //            con.Close();
        //            con.Dispose();

        //            live_trend_graph.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
        //            live_trend_graph.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
        //            live_trend_graph.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        //        }           

        //    }
        //    catch (Exception ex)
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //            con.Dispose();
        //        }            
                
        //        MessageBox.Show(ex.ToString());
        //    }
        //    //finally
        //    //{
        //    //    con.Close();
        //    //    con.Dispose();
        //    //}
        //}

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            DB_Timer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            DB_Timer.Elapsed += OnTimedEvent;
            DB_Timer.AutoReset = true;
            DB_Timer.Enabled = true;
        }

        private void GraphTimer()
        {
            // Create a timer with a two second interval.
            Graph_Timer = new System.Timers.Timer(1000);
            // Hook up the Elapsed event for the timer. 
            Graph_Timer.Elapsed += OnTick;
            Graph_Timer.AutoReset = true;
            Graph_Timer.Enabled = true;
        }

        private void OnTick(Object source, ElapsedEventArgs e)
        {
            
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        { 
            try
            {
                //For Inserting temperature values into database
                string query = "INSERT INTO temp (timing,cs_1_t_h_val,cs_1_t_h_alarm_status,cs_1_t_c_val,cs_1_t_c_alarm_status,cs_2_t_h_val,cs_2_t_h_alarm_status,cs_2_t_c_val,cs_2_t_c_alarm_status) values (Now(), '" + cold_store_1_temp_h_val.Value + "','" + cs_1_temp_hot_status + "','" + cold_store_1_temp_c_val.Value + "','" + cs_1_temp_cold_status + "','" + cold_store_2_temp_h_val.Value + "','" + cs_2_temp_hot_status + "','" + cold_store_2_temp_c_val.Value + "','" + cs_2_temp_cold_status + "')";
                
                if (con != null && con.State == ConnectionState.Closed)
                {
                    MySqlCommand cmnd = new MySqlCommand(query, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    //con.Dispose();
                    cmnd.Dispose();
                }                           
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }

                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

      
        //private void mkt_calculate()
        //{
        //    try
        //    {
        //        dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        //        con.Open();
        //        DataTable dtable = new DataTable();
        //        MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT timing as Timing, t_val as 'Temp Reading',273.15 as 'Kelvin Constant (K)',-83.14472 as 'Delta H (ΔH)',0.008314472 as 'Gas Constant (R)',(t_val + 273.15) AS R1,((t_val + 273.15)*0.008314472) AS RXTK,(-83.14472)/((t_val + 273.15) * 0.008314472) AS CAL,EXP((-83.14472)/((t_val + 273.15) * 0.008314472)) AS EXPONENT FROM temp WHERE timing BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "' AND t_val > 0 ORDER BY t_id ASC", con);
        //        adapter.Fill(dtable);
        //        dgv.DataSource = dtable;
        //        con.Close();

        //        dgv.Columns[0].Width = 200;
        //        dgv.Columns[1].Width = 150;
        //        dgv.Columns[2].Width = 150;
        //        dgv.Columns[3].Width = 150;
        //        dgv.Columns[4].Width = 150;
        //        dgv.Columns[5].Width = 160;
        //        dgv.Columns[6].Width = 160;
        //        dgv.Columns[7].Width = 170;
        //        dgv.Columns[8].Width = 210;
        //        if (dgv.Rows.Count > 1)
        //        {
        //            //For Average of all Values
        //            int A = 0;
        //            double B = 0;
        //            double Y = 0;
        //            for (A = 0; A < dgv.Rows.Count - 1; ++A)
        //            {
        //                B += Convert.ToDouble(dgv.Rows[A].Cells[1].Value);
        //                Y += Convert.ToDouble(dgv.Rows[A].Cells[8].Value);
        //            }
        //            int NUMofROWS = dgv.Rows.Count -1;
        //            double AVG = Convert.ToDouble(B) / NUMofROWS;
        //            txt_avg_temp.Text = AVG.ToString("F3") + " °C";
        //            //For Maximum Value
        //            txt_max_temp.Text = (from DataGridViewRow row in dgv.Rows
        //                                 where row.Cells[1].FormattedValue.ToString() != string.Empty
        //                                 select Convert.ToDecimal(row.Cells[1].FormattedValue)).Max().ToString() + " °C";
        //            //For Minimum Value
        //            txt_min_temp.Text = (from DataGridViewRow row in dgv.Rows
        //                                 where row.Cells[1].FormattedValue.ToString() != string.Empty
        //                                 select Convert.ToDecimal(row.Cells[1].FormattedValue)).Min().ToString() + " °C";

        //            //For Mean Kinetic Temperature  
        //            double AV = Convert.ToDouble(Y) / NUMofROWS;
        //            exp_avg.Text = AV.ToString();
        //            double LOG = Math.Log(AV)*(-1);
        //            log_value.Text = LOG.ToString();
        //            double MKT = 10000/LOG - 273.15;
        //            txt_mkt.Text = MKT.ToString("F3") + " °C";
        //        }                
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    btn_show_record.Enabled = false;

        //}
        //private void temp()
        //{
        //    try
        //    {
        //        MySqlCommand com = new MySqlCommand("SELECT timing,t_val,t_alarm_status FROM temp WHERE (timing BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "') AND (t_id MOD '" + label10.Text + "' = 0) AND (t_val <> 0) ORDER BY t_id ASC", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(com);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "t_val");
        //        dgv.DataSource = ds;
        //        dgv.DataMember = "t_val";
        //        dgv.Columns[0].Width = 500;
        //        dgv.Columns[1].Width = 500;
        //        dgv.Columns[2].Width = 500;

        //        dgv.Columns[0].HeaderText = "Timing";
        //        dgv.Columns[1].HeaderText = "Temperature";
        //        dgv.Columns[2].HeaderText = "Status";

        //        dgv.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm tt";
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    btn_show_record.Enabled = false;
        //}

        //private void door()
        //{
        //    try
        //    {
        //        MySqlCommand com = new MySqlCommand("SELECT timing,door_status FROM door WHERE (timing BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "') AND (door_status='1' OR door_status='0') ORDER BY dr_id ASC", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(com);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "door_status");
        //        dgv.DataSource = ds;
        //        dgv.DataMember = "door_status";
        //        dgv.Columns[0].Width = 750;
        //        dgv.Columns[1].Width = 750;

        //        dgv.Columns[0].HeaderText = "Timing";
        //        dgv.Columns[1].HeaderText = "Door Status";

        //        dgv.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";

        //        //Your column index
        //        const int CELL_INDEX = 1;

        //        foreach (DataGridViewRow item in dgv.Rows)
        //        {
        //            if (item.Cells[CELL_INDEX] != null
        //            && item.Cells[CELL_INDEX].Value != null && item.Cells[CELL_INDEX].Value != System.DBNull.Value)
        //            {
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("1", "OPEN");
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("0", "CLOSE");
        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    btn_show_record.Enabled = false;
        //}

        //private void compr()
        //{
        //    try
        //    {
        //        MySqlCommand com = new MySqlCommand("SELECT timing,compr_status FROM compressor WHERE (timing BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "') AND (compr_status='1' OR compr_status='0' OR compr_status='2') ORDER BY cmpr_id ASC", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(com);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "compr_status");
        //        dgv.DataSource = ds;
        //        dgv.DataMember = "compr_status";
        //        dgv.Columns[0].Width = 750;
        //        dgv.Columns[1].Width = 750;


        //        dgv.Columns[0].HeaderText = "Timing";
        //        dgv.Columns[1].HeaderText = "Compressor Status";


        //        dgv.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";

        //        //Your column index
        //        const int CELL_INDEX = 1;

        //        foreach (DataGridViewRow item in dgv.Rows)
        //        {
        //            if (item.Cells[CELL_INDEX] != null
        //            && item.Cells[CELL_INDEX].Value != null && item.Cells[CELL_INDEX].Value != System.DBNull.Value)
        //            {
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("1", "ON");
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("0", "OFF");
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("2", "TRIP");
        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    btn_show_record.Enabled = false;
        //}

        //private void trip()
        //{
        //    try
        //    {
        //        MySqlCommand com = new MySqlCommand("SELECT timing,compr_trip_status FROM temp WHERE (timing BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "') AND (t_id MOD '" + label10.Text + "' = 0) ORDER BY t_id ASC", con);
        //        MySqlDataAdapter da = new MySqlDataAdapter(com);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "compr_trip_status");
        //        dgv.DataSource = ds;
        //        dgv.DataMember = "compr_trip_status";
        //        dgv.Columns[0].Width = 200;
        //        dgv.Columns[1].Width = 200;
        //        dgv.Columns[0].HeaderText = "Timing";
        //        dgv.Columns[1].HeaderText = "Compressor Trip Status";
        //        dgv.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss tt";
        //        //Your column index
        //        const int CELL_INDEX = 1;

        //        foreach (DataGridViewRow item in dgv.Rows)
        //        {
        //            if (item.Cells[CELL_INDEX] != null
        //            && item.Cells[CELL_INDEX].Value != null && item.Cells[CELL_INDEX].Value != System.DBNull.Value)
        //            {
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("1", "Trip");
        //                item.Cells[CELL_INDEX].Value = item.Cells[CELL_INDEX].Value.ToString().Replace("0", "-");
        //            }
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    btn_show_record.Enabled = false;
        //}

     

        //private void reset_grid()
        //{
        //    dgv.DataSource = null;
        //    dgv.Rows.Clear();
        //    dgv.Columns.Clear();            
        //    txt_avg_temp.Text = "0";
        //    txt_min_temp.Text = "0";
        //    txt_max_temp.Text = "0";
        //    txt_mkt.Text = "0";
        //    temp_group.Visible = false;
        //    btn_show_record.Enabled = true;
        //}

        //private void txt_value_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_value.Text== "MKT Report")
        //    {
        //        reset_grid();

        //        lbl_interval.Visible = false;
        //        txt_interval.Visible = false;
                
        //        //date_1.Location = new Point(620, 447);
        //        //date_2.Location = new Point(874, 447);

        //        //lbl_date_1.Location = new Point(615, 423);
        //        //lbl_date_2.Location = new Point(867, 423);

        //    }
        //    if (txt_value.Text == "Temperature Report")             
        //    {
        //        lbl_interval.Visible = true;
        //        txt_interval.Visible = true;
        //        //date_1.Location = new Point(733, 447);
        //        //date_2.Location = new Point(987, 447);
        //        //lbl_date_1.Location = new Point(728, 423);
        //        //lbl_date_2.Location = new Point(983, 423);
        //        dgv.DataSource = null;
        //        dgv.Rows.Clear();
        //        dgv.Columns.Clear();
        //        txt_avg_temp.Text = "0";
        //        txt_min_temp.Text = "0";
        //        txt_max_temp.Text = "0";
        //        txt_mkt.Text = "0";
        //        temp_group.Visible = false;
        //        btn_show_record.Enabled = true;
        //    }
        //    if (txt_value.Text == "Door Report" || txt_value.Text == "Compressor Report")
        //    {
        //        lbl_interval.Visible = false;
        //        txt_interval.Visible = false;
        //        //date_1.Location = new Point(620, 447);
        //        //date_2.Location = new Point(874, 447);
        //        //lbl_date_1.Location = new Point(615, 423);
        //        //lbl_date_2.Location = new Point(867, 423);
        //        dgv.DataSource = null;
        //        dgv.Rows.Clear();
        //        dgv.Columns.Clear();
        //        txt_avg_temp.Text = "0";
        //        txt_min_temp.Text = "0";
        //        txt_max_temp.Text = "0";
        //        txt_mkt.Text = "0";
        //        temp_group.Visible = false;
        //        btn_show_record.Enabled = true;
        //    }
        //}

        //private void date_1_ValueChanged(object sender, EventArgs e)
        //{
        //    reset_grid();
        //}

        //private void date_2_ValueChanged(object sender, EventArgs e)
        //{
        //    reset_grid();
        //}

        private void random_timer_Tick(object sender, EventArgs e)
        {
            //To Generate Random Number of Temperature Value for Testing 
            Random random = new Random();
            decimal abc = new decimal (random.NextDouble() * (32.5 - 18.0) + 20.0);
           // temperature_val = abc;
            //Temperature.Text = num.ToString("0.0") + " °C";
            Temperature.Text = abc.ToString("0.0") + " °C";
        }

        //private void txt_interval_TextChanged(object sender, EventArgs e)
        //{
        //    if (txt_value.Text == "Temperature Report" || txt_value.Text == "Door Report" || txt_value.Text == "Compressor Report")
        //    {
        //        reset_grid();
        //    }
        //}

        private void temp_val_ValueChanged(object sender, EventArgs e)
        {
            double rtd1_val = Convert.ToDouble(cold_store_1_temp_h_val.Value);
            temperature_val = rtd1_val;
            //Temperature.Text = rtd1_val.ToString("0.0");

            if (rtd1_val <= 0)
            {
                cold_store_1_temp_h_val.Text = 0.ToString();
                //rtd1_status = "Fault/Error";
                cold_store_1_temp_h_val.ForeColor = Color.Black;
            }
            if (rtd1_val > 600)
            {
                // rtd1_status = "Fault/Error";
                // screen_1.rtd1_val.Text = "ERR".ToString();
                cold_store_1_temp_h_val.ForeColor = Color.Black;
            }
            if (rtd1_val >= 27)
            {
                // rtd1_status = "H";
                cold_store_1_temp_h_val.ForeColor = Color.Crimson;
                cold_store_1_temp_h_val.BackColor = Color.LightPink;
                //screen_1.rtd1_val.ForeColor = Color.Salmon;
                if (alarm_list.Items.Contains("Temperature Low"))
                {
                    alarm_list.Items.Remove("Temperature Low");
                }
                if (!alarm_list.Items.Contains("Temperature High"))
                {
                    alarm_list.Items.Add("Temperature High");
                }
                cs_1_temp_hot_status = "High";
                //if ((alarm_panel.Read("002001")) == "False")
                //{
                //    alarm_panel.Write("002001", "1");
                //}
                groupbox_temp.BackColor = Color.LightPink;
                lbl_t.ForeColor = Color.Crimson;

                //SystemSounds.Beep.Play();
            }
            if ((rtd1_val < 27) && (rtd1_val > 22) && (rtd1_val >= 0))
            {
                //rtd1_status = "N";
                cold_store_1_temp_h_val.ForeColor = Color.Black;
                cold_store_1_temp_h_val.BackColor = Color.LightBlue;
                groupbox_temp.BackColor = Color.LightBlue;
                lbl_t.ForeColor = Color.Black;
                //screen_1.rtd1_val.ForeColor = Color.White;
                if ((alarm_list.Items.Contains("Temperature High")) || (alarm_list.Items.Contains("Temperature Low")))
                {
                    alarm_list.Items.Remove("Temperature High");
                    alarm_list.Items.Remove("Temperature Low");
                }
               // if ((alarm_panel.Read("002001")) == "True")
               // {
                 //   alarm_panel.Write("002001", "0");
               // }
            }
            if (rtd1_val <= 22)
            {
                //rtd1_status = "L";
                cold_store_1_temp_h_val.ForeColor = Color.DarkOrange;
                cold_store_1_temp_h_val.BackColor = Color.LightYellow;
                groupbox_temp.BackColor = Color.LightYellow;
                lbl_t.ForeColor = Color.DarkOrange;
                //screen_1.rtd1_val.ForeColor = Color.Gold;
                if (alarm_list.Items.Contains("Temperature High"))
                {
                    alarm_list.Items.Remove("Temperature High");
                }
                if (!alarm_list.Items.Contains("Temperature Low"))
                {
                    alarm_list.Items.Add("Temperature Low");
                }
                cs_1_temp_hot_status = "Low";
                //if ((alarm_panel.Read("002001")) == "False")
                //{
                   // alarm_panel.Write("002001", "1");
                //}
            }
        }

        public void load_email_settings()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM email_settings WHERE email_ID = 1 ", con);
                con.Open();
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        e_id= (read["sender_email"]).ToString();
                        e_pass = (read["sender_password"]).ToString();
                        host = (read["smtp_server"]).ToString();
                        _port= (read["port_number"]).ToString();
                        rcvr= (read["recipient_email"]).ToString();
                        subj = (read["subject"]).ToString();
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

        private void send_email()
        {
            bdy = richTextBox1.Text;
            try
            {
                MailMessage mm = new MailMessage(e_id.Trim(), rcvr.Trim())
                {
                    Subject = subj.Trim().ToString(),
                    IsBodyHtml = true,
                    Body = bdy.Trim().ToString() + "   " + "  ---   " + DateTime.Now
                };

                SmtpClient smtp = new SmtpClient
                {
                    Host = host,
                    Port = Convert.ToInt32(_port),
                    //EnableSsl = true,
                    Credentials = new NetworkCredential(e_id.Trim(), e_pass.Trim())                  
                };
                //smtp.EnableSsl = true;
                smtp.Send(mm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<email_settings>().Any())
            {
                Application.OpenForms.OfType<email_settings>().First().BringToFront();
            }
            else
            {
                var email = new email_settings();
                email.Show();
            }
        }

        private void Time_TextChanged(object sender, EventArgs e)
        {
            string text = "";
            foreach (var item in alarm_list.Items)
            {
                text += item.ToString() + "\n"; // /n to print each item on new line or you omit /n to print text on same line
            }
            richTextBox1.Text = text;
        }

        private void Temperature_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void trend_timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_close_app_Click_1(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Do you really want to Close Application?", "Close",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res != DialogResult.Yes)
            {
                this.Activate();
            }
            else
            {
                DB_Timer.Dispose();
                log_id();
                log_exit();
                Application.Exit();
            }
        }

        private void btn_minimize_app_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void log_exit()
        {
            //for Updating User Info in user log at exiting
            try
            {
                string query = ("UPDATE user_log set username ='" + lbl_username.Text + "', logout_time = Now() where log_id = '" + lbl_log_id.Text + "' ;");
                MySqlCommand cmnd = new MySqlCommand(query, con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                MySqlDataReader read;
                read = cmnd.ExecuteReader();
                read.Close();
                read.Dispose();
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            log_id();
            log_exit();
            lbl_username.Text = "Operator";
            lbl_user_role.Text = "Operator";
            btn_logout.Enabled = false;
            btn_login.Enabled = true;

            txt_username.Enabled = true;
            txt_password.Enabled = true;
            ////For User Roles
            //if (lbl_user_role.Text == "Admin")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = true;
            //    btn_email_settings.Enabled = true;
            //    btn_user_role.Enabled = true;
            //    btn_user_log.Enabled = true;
            //    btn_mkt.Enabled = true;
            //    btn_backup_settings.Enabled = true;
            //    btn_close_app.Enabled = true;
            //    btn_sms_settings.Enabled = true;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = true;
            //    btn_email_settings.Visible = true;
            //    btn_user_role.Visible = true;
            //    btn_user_log.Visible = true;
            //    btn_mkt.Visible = true;
            //    btn_backup_settings.Visible = true;
            //    btn_sms_settings.Visible = true;
            //}
            //if (lbl_user_role.Text == "Supervisor")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = false;
            //    btn_email_settings.Enabled = false;
            //    btn_user_role.Enabled = false;
            //    btn_user_log.Enabled = false;
            //    btn_mkt.Enabled = true;
            //    btn_backup_settings.Enabled = false;
            //    btn_close_app.Enabled = false;
            //    btn_sms_settings.Enabled = false;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = false;
            //    btn_email_settings.Visible = false;
            //    btn_user_role.Visible = false;
            //    btn_user_log.Visible = false;
            //    btn_mkt.Visible = true;
            //    btn_backup_settings.Visible = false;
            //    btn_sms_settings.Visible = false;
            //}
            //if (lbl_user_role.Text == "Operator")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = false;
            //    btn_email_settings.Enabled = false;
            //    btn_user_role.Enabled = false;
            //    btn_user_log.Enabled = false;
            //    btn_mkt.Enabled = false;
            //    btn_backup_settings.Enabled = false;
            //    btn_close_app.Enabled = false;
            //    btn_sms_settings.Enabled = false;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = false;
            //    btn_email_settings.Visible = false;
            //    btn_user_role.Visible = false;
            //    btn_user_log.Visible = false;
            //    btn_mkt.Visible = false;
            //    btn_backup_settings.Visible = false;
            //    btn_sms_settings.Visible = false;
            //}
            txt_username.Text = "";
            txt_password.Text = "";

        }

        private void Login_Group_Box_MouseHover(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void Login_Group_Box_Leave(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void Login_Group_Box_Move(object sender, EventArgs e)
        {
 
        }
        //Add new event handlers on appropriate location in your code (perhaps in the load event of the form?)
        // Login_Group_Box.MouseEnter += new EventHandler(MouseEnteredGroupBox);
        // Login_Group_Box.MouseLeave += new EventHandler(MouseLeftGroupBox);
        private void MouseLeftGroupBox(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void btn_logout_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            Login_Group_Box.BackColor = Color.White;
            lbl_usrnm.BackColor = Color.White;
            lbl_pwd.BackColor = Color.White;
        }

        private void txt_username_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void txt_password_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void lbl_usrnm_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void lbl_pwd_MouseMove(object sender, MouseEventArgs e)
        {
            Login_Group_Box.BackColor = Color.LightBlue;
            lbl_usrnm.BackColor = Color.LightBlue;
            lbl_pwd.BackColor = Color.LightBlue;
        }

        private void plc_1_ComError(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {
            plc1_indicator.SelectColor2 = false;
            plc1_status.Text = "Disconnected";
        }

        private void plc_1_ConnectionEstablished(object sender, EventArgs e)
        {
            plc1_indicator.SelectColor2 = true;
            plc1_status.Text = "Connected";
        }

     
        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_log_Click(object sender, EventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<userlog>().Any())
            {
                Application.OpenForms.OfType<userlog>().First().BringToFront();
            }
            else
            {
                var usr = new userlog();
                usr.Show();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    string _username = txt_username.Text;
                    string _password = Encrypt(txt_password.Text);
                    string _Query = "SELECT * FROM users WHERE u_name = '" + _username + "' AND u_pass = '" + _password + "' ";
                    MySqlCommand cmd = new MySqlCommand(_Query, con);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (_username == dr["u_name"].ToString() && _password == dr["u_pass"].ToString())
                            {
                                lbl_user_role.Text = (dr["u_role"]).ToString();
                                lbl_username.Text = txt_username.Text;
                                btn_logout.Enabled = true;
                                btn_login.Enabled = false;
                                txt_password.Enabled = false;
                                txt_username.Enabled = false;
                            }
                            else if (_username != dr["u_name"].ToString() || _password != dr["u_pass"].ToString())
                            {
                                MessageBox.Show("Incorrect Username or Password");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            log_id();
            log_exit();
            log_entry();
            ////For User Roles
            //if (lbl_user_role.Text == "Admin")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = true;
            //    btn_email_settings.Enabled = true;
            //    btn_user_role.Enabled = true;
            //    btn_user_log.Enabled = true;
            //    btn_mkt.Enabled = true;
            //    btn_backup_settings.Enabled = true;
            //    btn_close_app.Enabled = true;
            //    btn_sms_settings.Enabled = true;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = true;
            //    btn_email_settings.Visible = true;
            //    btn_user_role.Visible = true;
            //    btn_user_log.Visible = true;
            //    btn_mkt.Visible = true;
            //    btn_backup_settings.Visible = true;
            //    btn_sms_settings.Visible = true;
            //}
            //if (lbl_user_role.Text == "Supervisor")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = false;
            //    btn_email_settings.Enabled = false;
            //    btn_user_role.Enabled = false;
            //    btn_user_log.Enabled = false;
            //    btn_mkt.Enabled = true;
            //    btn_backup_settings.Enabled = false;
            //    btn_close_app.Enabled = false;
            //    btn_sms_settings.Enabled = false;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = false;
            //    btn_email_settings.Visible = false;
            //    btn_user_role.Visible = false;
            //    btn_user_log.Visible = false;
            //    btn_mkt.Visible = true;
            //    btn_backup_settings.Visible = false;
            //    btn_sms_settings.Visible = false;
            //}
            //if (lbl_user_role.Text == "Operator")
            //{
            //    btn_layout_screen.Enabled = true;
            //    btn_pdf_reports.Enabled = true;
            //    btn_accmltd_pdf_reports.Enabled = true;
            //    btn_graph_report.Enabled = true;
            //    btn_setpoints.Enabled = false;
            //    btn_email_settings.Enabled = false;
            //    btn_user_role.Enabled = false;
            //    btn_user_log.Enabled = false;
            //    btn_mkt.Enabled = false;
            //    btn_backup_settings.Enabled = false;
            //    btn_close_app.Enabled = false;
            //    btn_sms_settings.Enabled = false;

            //    btn_layout_screen.Visible = true;
            //    btn_pdf_reports.Visible = true;
            //    btn_accmltd_pdf_reports.Visible = true;
            //    btn_graph_report.Visible = true;
            //    btn_setpoints.Visible = false;
            //    btn_email_settings.Visible = false;
            //    btn_user_role.Visible = false;
            //    btn_user_log.Visible = false;
            //    btn_mkt.Visible = false;
            //    btn_backup_settings.Visible = false;
            //    btn_sms_settings.Visible = false;
            //}
            txt_password.Text = "";
            txt_username.Text = "";
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

                        string folder = txt_backup_path.Text.ToString();
                        string datetimeString = string.Format("{0:yyyy-MM-dd__hh-mm-ss-tt}.sql", DateTime.Now);
                        string filename = "\\GETZ_Cold_Storage_DB_Backup_" + datetimeString;
                        string file = folder + filename;
                        cmd.Connection = con;
                        con.Open();
                        try
                        {
                            mb.ExportToFile(file);
                        }
                        catch (Exception ex)
                        {
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

        private void btn_setpoints_timer_Click(object sender, EventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<Setpoints_Alarm>().Any())
            {
                Application.OpenForms.OfType<Setpoints_Alarm>().First().BringToFront();
            }
            else
            {
                var sp = new Setpoints_Alarm();
                sp.Show();
            }
        }

        private void etimer_Tick(object sender, EventArgs e)
        {
            if (alarm_list.Visible == true)
            {
                //send_email();
                //send_sms();
            }
        }

        private void btn_backup_settings_Click(object sender, EventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<Backup_Settings>().Any())
            {
                Application.OpenForms.OfType<Backup_Settings>().First().BringToFront();
            }
            else
            {
                var bck = new Backup_Settings();
                bck.Show();
            }
        }

        private void usr_accnts_button_Click(object sender, EventArgs e)
        {
            //Check if Form is Open (If Open Navigate to it, If Not, Open that Form)
            if (Application.OpenForms.OfType<user_accounts>().Any())
            {
                Application.OpenForms.OfType<user_accounts>().First().BringToFront();
            }
            else
            {
                var usr = new user_accounts();
                usr.Show();
            }
        }

        private void cold_store_1_temp_h_val_ValueChanged(object sender, EventArgs e)
        {
           // cold_store_1_temp_h_val.Text= cold_store_1_temp_h_val.Value.
        }

        //private void btn_save_pdf_Click(object sender, EventArgs e)
        //{
        //    Dashboard master = (Dashboard)Application.OpenForms["Dashboard"];
        //    string user_logged = master.lbl_username.Text;
        //    Byte[] bytes;
        //    if (savefiledialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        using (var ms = new MemoryStream())
        //        {
        //            // Declaring File Name via Textbox
        //            textBox1.Text = savefiledialog1.FileName;
        //            // Code Start for Font Styles
        //            iTextSharp.text.Font ptitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
        //            iTextSharp.text.Font pstitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
        //            iTextSharp.text.Font pdata = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        //            iTextSharp.text.Font pbold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
        //            iTextSharp.text.Font pb = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
        //            iTextSharp.text.Font pfoot = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK);
        //            // Code Ends for Font Styling

        //            //Code Starts for Method of Saving File As PDF
        //            Paragraph paragraph = new Paragraph();
        //            Document pdffile = new Document(PageSize.A4, 0f, 0f, 5f, 10f);
        //            //new FileStream(textBox1.Text, FileMode.Create)
        //            PdfWriter write = PdfWriter.GetInstance(pdffile, ms);
        //            pdffile.Open();
        //            //For Adding Logo on Top
        //            System.Drawing.Bitmap logogetz = Searle_Cold_Storage_SCADA.Resources.Getz_CEPH_unit_2_logo1;
        //            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(logogetz, System.Drawing.Imaging.ImageFormat.Jpeg);
        //            image.ScaleToFit(110.0F, 160.0F);
        //            image.SetAbsolutePosition(pdffile.Left, pdffile.Top - 65);
        //            pdffile.Add(image);
        //            //Adding Header Text
        //            pdffile.Add(new Paragraph("                              Getz Pharma (PVT) Limited ", ptitle));
        //            pdffile.Add(new Paragraph("  "));
        //            pdffile.Add(new Paragraph("                                         Continuous Monitoring Report", pstitle));
        //            pdffile.Add(new Paragraph("                                                   Detailed Report of  " + txt_value.Text, pbold));
        //            pdffile.Add(new Paragraph("                               Readings between   " + DateTimePicker1.Text + "  And  " + DateTimePicker2.Text, pbold));
        //            pdffile.Add(new Paragraph("  "));
        //            //Code Ends for Header and Upper Textboxes

        //            //Code For Data Grid View Data (pdf export)
        //            pdffile.Add(paragraph);
        //            PdfPTable pdftable = new PdfPTable(dataGridView1.Columns.Count);
        //            pdftable.WidthPercentage = 97f;
        //            pdftable.LockedWidth = false;
        //            //int[] intTblWidth = new[] { 160, 160, 160 };
        //            //pdftable.SetWidths(intTblWidth);
        //            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
        //            {
        //                //pdftable.SetWidths(intTblWidth);
        //                pdftable.HorizontalAlignment = 0;
        //                pdftable.SpacingBefore = 5.0F;
        //            }
        //            PdfPCell pdfcell = new PdfPCell();
        //            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
        //            {
        //                pdfcell = new PdfPCell(new Phrase(new Chunk(dataGridView1.Columns[i].HeaderText, pb)));
        //                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
        //                pdfcell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
        //                pdfcell.FixedHeight = (30f);
        //                pdftable.AddCell(pdfcell);
        //            }
        //            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
        //            {
        //                for (int j = 0; j <= dataGridView1.Columns.Count - 1; j++)
        //                {
        //                    pdfcell = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString(), pdata));
        //                    pdftable.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
        //                    pdfcell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
        //                    pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
        //                    pdfcell.FixedHeight = (26f);
        //                    pdftable.AddCell(pdfcell);
        //                }
        //            }
        //            pdffile.Add(pdftable);
        //            pdffile.Add(new Paragraph("    "));
        //            pdffile.Add(new Paragraph("    "));
        //            pdffile.Add(new Paragraph("    "));
        //            pdffile.Add(new Paragraph("    Checked By:  " + user_logged + "                                                                                                         Verified By: ________________ ", pb));
        //            pdffile.Add(new Paragraph("    "));
        //            pdffile.Add(new Paragraph());
        //            pdffile.Close();
        //            bytes = ms.ToArray();
        //        }

        //        //Read our PDF and apply page numbers
        //        using (var reader = new PdfReader(bytes))
        //        {
        //            using (var ms = new MemoryStream())
        //            {
        //                using (var stamper = new PdfStamper(reader, ms))
        //                {
        //                    int PageCount = reader.NumberOfPages;
        //                    for (int i = 1; i <= PageCount; i++)
        //                    {
        //                        ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_CENTER, new Phrase(String.Format("                                                                                             Page {0} of {1}", i, PageCount)), 160, 10, 0);
        //                    }
        //                }
        //                bytes = ms.ToArray();
        //            }
        //        }
        //        var outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), textBox1.Text);
        //        System.IO.File.WriteAllBytes(outputFile, bytes);
        //        MessageBox.Show("Data Exported to PDF Successfuly");
        //    }
        //}
    }
}
