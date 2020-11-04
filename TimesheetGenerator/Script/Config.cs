using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetGenerator.Script
{
    class Config
    {
        public SqlConnection getConnection()
        {
            string path = Path.GetTempPath();
            string connectionString = System.IO.File.ReadAllText(path+@"LTG\Config.ini");
            SqlConnection conn = new SqlConnection(connectionString);
            
            return conn;
        }

        public string getDataQuery(string query)
        {
            string result = "";
            SqlConnection conn = getConnection();
            SqlCommand command;
            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                result = dt.Rows[0]["tgObjectValue"].ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
         public string getId()
        {
            string id="";
            string prefix = getDataQuery("select tgObjectValue from LTG_MD_ConfigInfo where tgConfigId = '001';");
            string counter = getDataQuery("select tgObjectValue from LTG_MD_ConfigInfo where tgConfigId = '002';");
            int count = Int32.Parse(counter)+1;
            char add_prefix = char.Parse(getDataQuery("select tgObjectValue from LTG_MD_ConfigInfo where tgConfigId = '003';"));
            int lenght = Int32.Parse(getDataQuery("select tgObjectValue from LTG_MD_ConfigInfo where tgConfigId = '004';"));
            string pad = counter.PadLeft(lenght-1, add_prefix);

            id = prefix + "-" + pad + count;
            return id;
        }
    }
}
