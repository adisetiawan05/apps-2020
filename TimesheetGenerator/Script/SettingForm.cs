using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetGenerator.Script
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Config cnf = new Config();
            SqlConnection conn = cnf.getConnection();
            conn.Open();
            string query = "SELECT tgConfigObject, tgObjectValue FROM LTG_MD_ConfigInfo";
            //SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            conn.Close();
            dgv_SettingGrid.DataSource = dt;

            dgv_SettingGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_SettingGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }


        private void btn_Update_Click(object sender, EventArgs e)
        {

        }
    }
}
