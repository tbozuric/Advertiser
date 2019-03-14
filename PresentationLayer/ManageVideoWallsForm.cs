using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ManageVideoWallsForm : Form, IManageVideoWallsView
    {
        private IMainController _controller;
        private IList<VideoWall> _videoWalls;

        public ManageVideoWallsForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormManageVideoWalls_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddSchedule_Click(object sender, EventArgs e)
        {
            _controller.ShowAddScheduleToVideoWall(this);
        }

        private void ButtonRemoveSchedule_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listSchedules.SelectedItems)
            {
                _controller.RemoveScheduleFromVideoWall(this, item.SubItems[0].Text);
            }
        }

        private void UpdateList()
        {
            foreach (var videoWall in _videoWalls)
            {
                cbxVideoWall.Items.Add(videoWall.Location);
            }
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            _controller.ShowAddEmployeeToVideoWall(this);
        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listEmployees.SelectedItems)
            {
                _controller.RemoveEmployeeFromVideoWall(this, item.SubItems[0].Text);
            }
        }

        private void CbxVideoWall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex != -1)
            {
                groupBoxEmployees.Enabled = true;
                groupBoxSchedules.Enabled = true;

                UpdateEmployeesListView();
                UpdateSchedulesListView();
            }
        }

        private void UpdateSchedulesListView()
        {
            listSchedules.Items.Clear();
            var schedules = _controller.GetVideoWallSchedules(this);

            foreach (var schedule in schedules)
            {
                var listViewItem = new ListViewItem(schedule.Name);

                listViewItem.SubItems.Add(schedule.ScheduleStart.ToString(@"MM/dd/yyyy hh:mm"));
                listViewItem.SubItems.Add(schedule.ScheduleStop.ToString(@"MM/dd/yyyy hh:mm"));
                listSchedules.Items.Add(listViewItem);
            }
        }

        private void UpdateEmployeesListView()
        {
            listEmployees.Items.Clear();

            var servicers = _controller.GetServicersOfVideoWall(this);

            foreach (var employee in servicers)
            {
                var listViewItem = new ListViewItem(employee.Oib);
                listViewItem.SubItems.Add(employee.Name);
                listViewItem.SubItems.Add(employee.Surname);
                listEmployees.Items.Add(listViewItem);
            }
        }

        public void UpdateView()
        {
            UpdateEmployeesListView();
            UpdateSchedulesListView();
        }


        Address IManageVideoWallsView.Location => (Address) cbxVideoWall.SelectedItem;

        public void ShowModal(IMainController inMainController, IList<VideoWall> inList)
        {
            _controller = inMainController;
            _videoWalls = inList;

            UpdateList();
            ShowDialog();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}