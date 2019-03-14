namespace PresentationLayer
{
    partial class ManageSchedulesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSchedules = new System.Windows.Forms.ComboBox();
            this.groupBoxAds = new System.Windows.Forms.GroupBox();
            this.buttonRemoveAd = new System.Windows.Forms.Button();
            this.buttonAddAd = new System.Windows.Forms.Button();
            this.listAds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAds.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule";
            // 
            // cbxSchedules
            // 
            this.cbxSchedules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchedules.FormattingEnabled = true;
            this.cbxSchedules.Location = new System.Drawing.Point(132, 14);
            this.cbxSchedules.Name = "cbxSchedules";
            this.cbxSchedules.Size = new System.Drawing.Size(622, 28);
            this.cbxSchedules.TabIndex = 1;
            this.cbxSchedules.SelectedIndexChanged += new System.EventHandler(this.Schedule_SelectedIndexChanged);
            // 
            // groupBoxAds
            // 
            this.groupBoxAds.Controls.Add(this.buttonRemoveAd);
            this.groupBoxAds.Controls.Add(this.buttonAddAd);
            this.groupBoxAds.Controls.Add(this.listAds);
            this.groupBoxAds.Enabled = false;
            this.groupBoxAds.Location = new System.Drawing.Point(36, 78);
            this.groupBoxAds.Name = "groupBoxAds";
            this.groupBoxAds.Size = new System.Drawing.Size(718, 360);
            this.groupBoxAds.TabIndex = 3;
            this.groupBoxAds.TabStop = false;
            this.groupBoxAds.Text = "Ads";
            // 
            // buttonRemoveAd
            // 
            this.buttonRemoveAd.Location = new System.Drawing.Point(356, 312);
            this.buttonRemoveAd.Name = "buttonRemoveAd";
            this.buttonRemoveAd.Size = new System.Drawing.Size(82, 35);
            this.buttonRemoveAd.TabIndex = 2;
            this.buttonRemoveAd.Text = "Remove";
            this.buttonRemoveAd.UseVisualStyleBackColor = true;
            this.buttonRemoveAd.Click += new System.EventHandler(this.ButtonRemoveAd_Click);
            // 
            // buttonAddAd
            // 
            this.buttonAddAd.Location = new System.Drawing.Point(266, 312);
            this.buttonAddAd.Name = "buttonAddAd";
            this.buttonAddAd.Size = new System.Drawing.Size(84, 35);
            this.buttonAddAd.TabIndex = 1;
            this.buttonAddAd.Text = "Add";
            this.buttonAddAd.UseVisualStyleBackColor = true;
            this.buttonAddAd.Click += new System.EventHandler(this.ButtonAddAd_Click);
            // 
            // listAds
            // 
            this.listAds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listAds.Location = new System.Drawing.Point(96, 25);
            this.listAds.Name = "listAds";
            this.listAds.Size = new System.Drawing.Size(616, 259);
            this.listAds.TabIndex = 0;
            this.listAds.UseCompatibleStateImageBehavior = false;
            this.listAds.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 311;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Content";
            this.columnHeader2.Width = 141;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start time";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "End time";
            // 
            // ManageSchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAds);
            this.Controls.Add(this.cbxSchedules);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSchedulesForm";
            this.Text = "Manage schedules";
            this.Load += new System.EventHandler(this.FormManageSchedules_Load);
            this.groupBoxAds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSchedules;
        private System.Windows.Forms.GroupBox groupBoxAds;
        private System.Windows.Forms.Button buttonRemoveAd;
        private System.Windows.Forms.Button buttonAddAd;
        private System.Windows.Forms.ListView listAds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}