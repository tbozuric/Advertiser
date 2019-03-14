using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ShowEmployeeServicesReportForm : Form, IEmployeeServicesStatisticsView
    {
        private readonly IMainController _controller;
        private readonly IList<Employee> _employees;

        public ShowEmployeeServicesReportForm(IMainController inMainController, IList<Employee> inList)
        {
            _controller = inMainController;
            _employees = inList;

            InitializeComponent();
            Icon = Properties.Resources.Icon;

            UpdateList();

            const string dateFormat = @"MM/dd/yyyy hh:mm";
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = dateFormat;

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = dateFormat;
        }

        private void FormShowEmployeeSummaryReport_Load(object sender, EventArgs e)
        {
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void UpdateList()
        {
            cbxEmployee.Items.Clear();

            foreach (var employee in _employees)
            {
                cbxEmployee.Items.Add(employee);
            }
        }

        public string Oib => ((Employee) cbxEmployee.SelectedItem).Oib;
        public DateTime StartDate => dateTimeStart.Value;
        public DateTime EndDate => dateTimeEnd.Value;
        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex != -1)
            {
                lblRepairedFailuresValue.Text = @"N/A";

                var repairedFailures = _controller.GetEmployeeStatistics(this);
                lblRepairedFailuresValue.Text = repairedFailures.ToString();
            }
        }
    }
}