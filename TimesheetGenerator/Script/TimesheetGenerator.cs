using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimesheetGenerator.Script;

namespace TimesheetGenerator
{
    public partial class TimesheetGenerator : Form
    {
        public TimesheetGenerator()
        {
            InitializeComponent();
        }


        private void TimesheetGenerator_Load(object sender, EventArgs e)
        {
            setStatus();
            getStatus();
        }

        private void getStatus()
        {
            string formated = String.Format(dtm_Tanggal.Value.ToString("dddd", new CultureInfo("id-IN")));
            if (formated == "Sabtu" || formated == "Minggu")
            {
                cmb_Status.Text = "Libur";
            }
            else
            {
                cmb_Status.Text = "Masuk";
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Config cnf = new Config();
            SqlConnection conn = cnf.getConnection();
            try
            {
                conn.Open();
                string id = cnf.getId();
                string query = "INSERT INTO LTG_SD_Timesheet VALUES ('"+id+"','"+dtm_Tanggal.Text+"','"+txt_Divisi.Text+"','"+txt_ProjectName.Text+"','"+txt_Location.Text+"','"+txt_Remark.Text+"', '');";
                SqlCommand insert = new SqlCommand(query, conn);
                //insert.ExecuteNonQuery();

                int counter = Int32.Parse(id.Substring(id.Length - 1));
                string query_update = "UPDATE LTG_MD_ConfigInfo SET tgObjectValue = '"+counter+"', dtmLastUpdated = GETDATE() where tgConfigObject = 'Counter';";
                SqlCommand update = new SqlCommand(query_update,conn);
                //update.ExecuteNonQuery();
                
                
                conn.Close();
                insert.Dispose();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setStatus()
        {
            Config cnf = new Config();
            SqlConnection conn = cnf.getConnection();

            string status = "SELECT tgStatusName FROM LTG_MD_WorkingStatus";
            conn.Open();
            SqlCommand command = new SqlCommand(status, conn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string item = dataReader.GetValue(0).ToString();
                cmb_Status.Items.Add(item);
            }
            conn.Close();
            command.Dispose();
        }

        private void dtm_Tanggal_ValueChanged(object sender, EventArgs e)
        {
            getStatus();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.Show();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ExportForm ef = new ExportForm();
            ef.Show();
        }
    }
}
