namespace PresentationLayer
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVideoWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVideoWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVideoWallsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentVideoWallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSchedulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmpoloyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWallSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeesSummaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.adToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVideoWallsToolStripMenuItem,
            this.addVideoWallToolStripMenuItem,
            this.removeVideoWallToolStripMenuItem,
            this.manageVideoWallsToolStripMenuItem,
            this.rentVideoWallToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.aToolStripMenuItem.Text = "Video walls";
            // 
            // viewVideoWallsToolStripMenuItem
            // 
            this.viewVideoWallsToolStripMenuItem.Name = "viewVideoWallsToolStripMenuItem";
            this.viewVideoWallsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.viewVideoWallsToolStripMenuItem.Text = "View video walls";
            this.viewVideoWallsToolStripMenuItem.Click += new System.EventHandler(this.ViewVideoWallsToolStripMenuItem_Click);
            // 
            // addVideoWallToolStripMenuItem
            // 
            this.addVideoWallToolStripMenuItem.Name = "addVideoWallToolStripMenuItem";
            this.addVideoWallToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addVideoWallToolStripMenuItem.Text = "Add video wall";
            this.addVideoWallToolStripMenuItem.Click += new System.EventHandler(this.AddVideoWallToolStripMenuItem_Click);
            // 
            // removeVideoWallToolStripMenuItem
            // 
            this.removeVideoWallToolStripMenuItem.Name = "removeVideoWallToolStripMenuItem";
            this.removeVideoWallToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.removeVideoWallToolStripMenuItem.Text = "Remove video wall";
            this.removeVideoWallToolStripMenuItem.Click += new System.EventHandler(this.RemoveVideoWallToolStripMenuItem_Click);
            // 
            // manageVideoWallsToolStripMenuItem
            // 
            this.manageVideoWallsToolStripMenuItem.Name = "manageVideoWallsToolStripMenuItem";
            this.manageVideoWallsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.manageVideoWallsToolStripMenuItem.Text = "Manage video walls";
            this.manageVideoWallsToolStripMenuItem.Click += new System.EventHandler(this.ManageVideoWallsToolStripMenuItem_Click);
            // 
            // rentVideoWallToolStripMenuItem
            // 
            this.rentVideoWallToolStripMenuItem.Name = "rentVideoWallToolStripMenuItem";
            this.rentVideoWallToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.rentVideoWallToolStripMenuItem.Text = "Rent video wall";
            this.rentVideoWallToolStripMenuItem.Click += new System.EventHandler(this.RentVideoWallToolStripMenuItem_Click);
            // 
            // adToolStripMenuItem
            // 
            this.adToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAdsToolStripMenuItem,
            this.addAdToolStripMenuItem,
            this.removeAdToolStripMenuItem});
            this.adToolStripMenuItem.Name = "adToolStripMenuItem";
            this.adToolStripMenuItem.Size = new System.Drawing.Size(47, 29);
            this.adToolStripMenuItem.Text = "Ad";
            // 
            // viewAdsToolStripMenuItem
            // 
            this.viewAdsToolStripMenuItem.Name = "viewAdsToolStripMenuItem";
            this.viewAdsToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.viewAdsToolStripMenuItem.Text = "View ads";
            this.viewAdsToolStripMenuItem.Click += new System.EventHandler(this.ViewAdsToolStripMenuItem_Click);
            // 
            // addAdToolStripMenuItem
            // 
            this.addAdToolStripMenuItem.Name = "addAdToolStripMenuItem";
            this.addAdToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.addAdToolStripMenuItem.Text = "Add ad";
            this.addAdToolStripMenuItem.Click += new System.EventHandler(this.AddAdToolStripMenuItem_Click);
            // 
            // removeAdToolStripMenuItem
            // 
            this.removeAdToolStripMenuItem.Name = "removeAdToolStripMenuItem";
            this.removeAdToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.removeAdToolStripMenuItem.Text = "Remove ad";
            this.removeAdToolStripMenuItem.Click += new System.EventHandler(this.RemoveAdToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSchedulesToolStripMenuItem,
            this.addScheduleToolStripMenuItem,
            this.removeScheduleToolStripMenuItem,
            this.manageSchedulesToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // viewSchedulesToolStripMenuItem
            // 
            this.viewSchedulesToolStripMenuItem.Name = "viewSchedulesToolStripMenuItem";
            this.viewSchedulesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.viewSchedulesToolStripMenuItem.Text = "View schedules";
            this.viewSchedulesToolStripMenuItem.Click += new System.EventHandler(this.ViewSchedulesStripMenuItem_Click);
            // 
            // addScheduleToolStripMenuItem
            // 
            this.addScheduleToolStripMenuItem.Name = "addScheduleToolStripMenuItem";
            this.addScheduleToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.addScheduleToolStripMenuItem.Text = "Add schedule";
            this.addScheduleToolStripMenuItem.Click += new System.EventHandler(this.AddScheduleStripMenuItem_Click);
            // 
            // removeScheduleToolStripMenuItem
            // 
            this.removeScheduleToolStripMenuItem.Name = "removeScheduleToolStripMenuItem";
            this.removeScheduleToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.removeScheduleToolStripMenuItem.Text = "Remove schedule";
            this.removeScheduleToolStripMenuItem.Click += new System.EventHandler(this.RemoveScheduleStripMenuItem_Click);
            // 
            // manageSchedulesToolStripMenuItem
            // 
            this.manageSchedulesToolStripMenuItem.Name = "manageSchedulesToolStripMenuItem";
            this.manageSchedulesToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.manageSchedulesToolStripMenuItem.Text = "Manage schedules";
            this.manageSchedulesToolStripMenuItem.Click += new System.EventHandler(this.ManageSchedulesStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewServicesToolStripMenuItem,
            this.addServiceToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // viewServicesToolStripMenuItem
            // 
            this.viewServicesToolStripMenuItem.Name = "viewServicesToolStripMenuItem";
            this.viewServicesToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.viewServicesToolStripMenuItem.Text = "View services";
            this.viewServicesToolStripMenuItem.Click += new System.EventHandler(this.ViewServicesStripMenuItem_Click);
            // 
            // addServiceToolStripMenuItem
            // 
            this.addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            this.addServiceToolStripMenuItem.Size = new System.Drawing.Size(199, 30);
            this.addServiceToolStripMenuItem.Text = "Add service";
            this.addServiceToolStripMenuItem.Click += new System.EventHandler(this.AddServiceStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.addEmployeeToolStripMenuItem,
            this.removeEmpoloyeeToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.viewEmployeesToolStripMenuItem.Text = "View employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.ViewEmployeesStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.addEmployeeToolStripMenuItem.Text = "Add employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeStripMenuItem_Click);
            // 
            // removeEmpoloyeeToolStripMenuItem
            // 
            this.removeEmpoloyeeToolStripMenuItem.Name = "removeEmpoloyeeToolStripMenuItem";
            this.removeEmpoloyeeToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.removeEmpoloyeeToolStripMenuItem.Text = "Remove empoloyee";
            this.removeEmpoloyeeToolStripMenuItem.Click += new System.EventHandler(this.RemoveEmployeeStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWallSummaryToolStripMenuItem,
            this.showEmployeesSummaryReportToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // showWallSummaryToolStripMenuItem
            // 
            this.showWallSummaryToolStripMenuItem.Name = "showWallSummaryToolStripMenuItem";
            this.showWallSummaryToolStripMenuItem.Size = new System.Drawing.Size(351, 30);
            this.showWallSummaryToolStripMenuItem.Text = "Show video wall report";
            this.showWallSummaryToolStripMenuItem.Click += new System.EventHandler(this.ShowWallSummaryStripMenuItem_Click);
            // 
            // showEmployeesSummaryReportToolStripMenuItem
            // 
            this.showEmployeesSummaryReportToolStripMenuItem.Name = "showEmployeesSummaryReportToolStripMenuItem";
            this.showEmployeesSummaryReportToolStripMenuItem.Size = new System.Drawing.Size(351, 30);
            this.showEmployeesSummaryReportToolStripMenuItem.Text = "Show employees services report";
            this.showEmployeesSummaryReportToolStripMenuItem.Click += new System.EventHandler(this.ShowEmployeesSummaryStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "Reklamator";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVideoWallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoWallToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeVideoWallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVideoWallsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmpoloyeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentVideoWallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSchedulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWallSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeesSummaryReportToolStripMenuItem;
    }
}

