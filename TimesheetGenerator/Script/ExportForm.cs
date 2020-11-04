using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesheetGenerator.Script
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }


        private void cb_Tanggal_Click(object sender, EventArgs e)
        {
            cb_Bulan.Checked = false;
        }

        private void cb_Bulan_Click(object sender, EventArgs e)
        {
            cb_Tanggal.Checked = false;
        }
    }
}
