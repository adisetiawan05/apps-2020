namespace TimesheetGenerator.Script
{
    partial class ExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtm_Start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_End = new System.Windows.Forms.DateTimePicker();
            this.cb_Tanggal = new System.Windows.Forms.CheckBox();
            this.cb_Bulan = new System.Windows.Forms.CheckBox();
            this.txt_Bulan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtm_Start
            // 
            this.dtm_Start.Enabled = false;
            this.dtm_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_Start.Location = new System.Drawing.Point(80, 13);
            this.dtm_Start.Name = "dtm_Start";
            this.dtm_Start.Size = new System.Drawing.Size(101, 20);
            this.dtm_Start.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "s/d";
            // 
            // dtm_End
            // 
            this.dtm_End.Enabled = false;
            this.dtm_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_End.Location = new System.Drawing.Point(216, 13);
            this.dtm_End.Name = "dtm_End";
            this.dtm_End.Size = new System.Drawing.Size(108, 20);
            this.dtm_End.TabIndex = 4;
            // 
            // cb_Tanggal
            // 
            this.cb_Tanggal.AutoSize = true;
            this.cb_Tanggal.Location = new System.Drawing.Point(12, 16);
            this.cb_Tanggal.Name = "cb_Tanggal";
            this.cb_Tanggal.Size = new System.Drawing.Size(65, 17);
            this.cb_Tanggal.TabIndex = 5;
            this.cb_Tanggal.Text = "Tanggal";
            this.cb_Tanggal.UseVisualStyleBackColor = true;
            this.cb_Tanggal.Click += new System.EventHandler(this.cb_Tanggal_Click);
            // 
            // cb_Bulan
            // 
            this.cb_Bulan.AutoSize = true;
            this.cb_Bulan.Location = new System.Drawing.Point(12, 39);
            this.cb_Bulan.Name = "cb_Bulan";
            this.cb_Bulan.Size = new System.Drawing.Size(53, 17);
            this.cb_Bulan.TabIndex = 6;
            this.cb_Bulan.Text = "Bulan";
            this.cb_Bulan.UseVisualStyleBackColor = true;
            this.cb_Bulan.Click += new System.EventHandler(this.cb_Bulan_Click);
            // 
            // txt_Bulan
            // 
            this.txt_Bulan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Bulan.Enabled = false;
            this.txt_Bulan.Location = new System.Drawing.Point(80, 40);
            this.txt_Bulan.Name = "txt_Bulan";
            this.txt_Bulan.Size = new System.Drawing.Size(139, 20);
            this.txt_Bulan.TabIndex = 7;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 173);
            this.Controls.Add(this.txt_Bulan);
            this.Controls.Add(this.cb_Bulan);
            this.Controls.Add(this.cb_Tanggal);
            this.Controls.Add(this.dtm_End);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtm_Start);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtm_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_End;
        private System.Windows.Forms.CheckBox cb_Tanggal;
        private System.Windows.Forms.CheckBox cb_Bulan;
        private System.Windows.Forms.TextBox txt_Bulan;
    }
}