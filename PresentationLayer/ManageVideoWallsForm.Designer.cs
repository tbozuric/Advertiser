namespace PresentationLayer
{
    partial class ManageVideoWallsForm
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
            this.cbxVideoWall = new System.Windows.Forms.ComboBox();
            this.groupBoxSchedules = new System.Windows.Forms.GroupBox();
            this.listSchedules = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveSchedule = new System.Windows.Forms.Button();
            this.buttonAddSchedule = new System.Windows.Forms.Button();
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.listEmployees = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxSchedules.SuspendLayout();
            this.groupBoxEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video wall";
            // 
            // cbxVideoWall
            // 
            this.cbxVideoWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVideoWall.FormattingEnabled = true;
            this.cbxVideoWall.Location = new System.Drawing.Point(109, 6);
            this.cbxVideoWall.Name = "cbxVideoWall";
            this.cbxVideoWall.Size = new System.Drawing.Size(1116, 28);
            this.cbxVideoWall.TabIndex = 1;
            this.cbxVideoWall.SelectedIndexChanged += new System.EventHandler(this.CbxVideoWall_SelectedIndexChanged);
            // 
            // groupBoxSchedules
            // 
            this.groupBoxSchedules.Controls.Add(this.listSchedules);
            this.groupBoxSchedules.Controls.Add(this.buttonRemoveSchedule);
            this.groupBoxSchedules.Controls.Add(this.buttonAddSchedule);
            this.groupBoxSchedules.Enabled = false;
            this.groupBoxSchedules.Location = new System.Drawing.Point(27, 68);
            this.groupBoxSchedules.Name = "groupBoxSchedules";
            this.groupBoxSchedules.Size = new System.Drawing.Size(616, 383);
            this.groupBoxSchedules.TabIndex = 2;
            this.groupBoxSchedules.TabStop = false;
            this.groupBoxSchedules.Text = "Schedules";
            // 
            // listSchedules
            // 
            this.listSchedules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6});
            this.listSchedules.Location = new System.Drawing.Point(17, 37);
            this.listSchedules.Name = "listSchedules";
            this.listSchedules.Size = new System.Drawing.Size(581, 289);
            this.listSchedules.TabIndex = 2;
            this.listSchedules.UseCompatibleStateImageBehavior = false;
            this.listSchedules.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Start time";
            this.columnHeader5.Width = 225;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "End time";
            this.columnHeader6.Width = 132;
            // 
            // buttonRemoveSchedule
            // 
            this.buttonRemoveSchedule.Location = new System.Drawing.Point(291, 332);
            this.buttonRemoveSchedule.Name = "buttonRemoveSchedule";
            this.buttonRemoveSchedule.Size = new System.Drawing.Size(95, 32);
            this.buttonRemoveSchedule.TabIndex = 1;
            this.buttonRemoveSchedule.Text = "Remove";
            this.buttonRemoveSchedule.UseVisualStyleBackColor = true;
            this.buttonRemoveSchedule.Click += new System.EventHandler(this.ButtonRemoveSchedule_Click);
            // 
            // buttonAddSchedule
            // 
            this.buttonAddSchedule.Location = new System.Drawing.Point(193, 332);
            this.buttonAddSchedule.Name = "buttonAddSchedule";
            this.buttonAddSchedule.Size = new System.Drawing.Size(79, 32);
            this.buttonAddSchedule.TabIndex = 0;
            this.buttonAddSchedule.Text = "Add";
            this.buttonAddSchedule.UseVisualStyleBackColor = true;
            this.buttonAddSchedule.Click += new System.EventHandler(this.ButtonAddSchedule_Click);
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Controls.Add(this.listEmployees);
            this.groupBoxEmployees.Controls.Add(this.buttonRemoveEmployee);
            this.groupBoxEmployees.Controls.Add(this.buttonAddEmployee);
            this.groupBoxEmployees.Enabled = false;
            this.groupBoxEmployees.Location = new System.Drawing.Point(665, 68);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(566, 383);
            this.groupBoxEmployees.TabIndex = 3;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Employees";
            // 
            // listEmployees
            // 
            this.listEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listEmployees.Location = new System.Drawing.Point(6, 37);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(554, 289);
            this.listEmployees.TabIndex = 3;
            this.listEmployees.UseCompatibleStateImageBehavior = false;
            this.listEmployees.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "OIB";
            this.columnHeader2.Width = 209;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 184;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Surname";
            this.columnHeader4.Width = 133;
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(303, 332);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(101, 32);
            this.buttonRemoveEmployee.TabIndex = 2;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.ButtonRemoveEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(199, 332);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(82, 32);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // ManageVideoWallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.groupBoxSchedules);
            this.Controls.Add(this.cbxVideoWall);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageVideoWallsForm";
            this.Text = "Manage video walls";
            this.Load += new System.EventHandler(this.FormManageVideoWalls_Load);
            this.groupBoxSchedules.ResumeLayout(false);
            this.groupBoxEmployees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVideoWall;
        private System.Windows.Forms.GroupBox groupBoxSchedules;
        private System.Windows.Forms.ListView listSchedules;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonRemoveSchedule;
        private System.Windows.Forms.Button buttonAddSchedule;
        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.ListView listEmployees;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button2;
    }
}