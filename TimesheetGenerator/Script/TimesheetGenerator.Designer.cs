namespace TimesheetGenerator
{
    partial class TimesheetGenerator
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
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Division = new System.Windows.Forms.Label();
            this.dtm_Tanggal = new System.Windows.Forms.DateTimePicker();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.txt_Divisi = new System.Windows.Forms.TextBox();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(13, 13);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Division
            // 
            this.lbl_Division.AutoSize = true;
            this.lbl_Division.Location = new System.Drawing.Point(12, 35);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(44, 13);
            this.lbl_Division.TabIndex = 1;
            this.lbl_Division.Text = "Division";
            // 
            // dtm_Tanggal
            // 
            this.dtm_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_Tanggal.Location = new System.Drawing.Point(93, 6);
            this.dtm_Tanggal.Name = "dtm_Tanggal";
            this.dtm_Tanggal.Size = new System.Drawing.Size(108, 20);
            this.dtm_Tanggal.TabIndex = 10;
            this.dtm_Tanggal.ValueChanged += new System.EventHandler(this.dtm_Tanggal_ValueChanged);
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Location = new System.Drawing.Point(12, 61);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(71, 13);
            this.lbl_ProjectName.TabIndex = 3;
            this.lbl_ProjectName.Text = "Project Name";
            // 
            // txt_Divisi
            // 
            this.txt_Divisi.Location = new System.Drawing.Point(93, 32);
            this.txt_Divisi.Name = "txt_Divisi";
            this.txt_Divisi.Size = new System.Drawing.Size(239, 20);
            this.txt_Divisi.TabIndex = 1;
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(93, 58);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(239, 20);
            this.txt_ProjectName.TabIndex = 2;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(13, 87);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 6;
            this.lbl_Location.Text = "Location";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(93, 84);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(239, 20);
            this.txt_Location.TabIndex = 3;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(9, 165);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(75, 23);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(93, 165);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(257, 165);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 8;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(174, 165);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.AutoSize = true;
            this.lbl_Remark.Location = new System.Drawing.Point(13, 114);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(44, 13);
            this.lbl_Remark.TabIndex = 12;
            this.lbl_Remark.Text = "Remark";
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(93, 111);
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(239, 20);
            this.txt_Remark.TabIndex = 4;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(16, 146);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 13;
            this.lbl_Status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(93, 137);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(121, 21);
            this.cmb_Status.TabIndex = 14;
            // 
            // TimesheetGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 212);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.lbl_Remark);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.txt_ProjectName);
            this.Controls.Add(this.txt_Divisi);
            this.Controls.Add(this.lbl_ProjectName);
            this.Controls.Add(this.dtm_Tanggal);
            this.Controls.Add(this.lbl_Division);
            this.Controls.Add(this.lbl_Date);
            this.Name = "TimesheetGenerator";
            this.Text = "Timesheet Generator";
            this.Load += new System.EventHandler(this.TimesheetGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Division;
        private System.Windows.Forms.DateTimePicker dtm_Tanggal;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.TextBox txt_Divisi;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Label lbl_Remark;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cmb_Status;
    }
}

