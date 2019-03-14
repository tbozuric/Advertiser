using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ManageSchedulesForm : Form, IManageSchedulesView
    {
        private IMainController _controller;
        private IList<Schedule> _schedules;

        public ManageSchedulesForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormManageSchedules_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddAd_Click(object sender, EventArgs e)
        {
            _controller.ShowAddAdToSchedule(this);
        }

        private void ButtonRemoveAd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listAds.SelectedItems)
            {
                _controller.RemoveAdFromSchedule(this, item.SubItems[0].Text);
            }
        }

        public void UpdateView()
        {
            UpdateAdsList();
        }

        private void UpdateAdsList()
        {
            listAds.Items.Clear();
            var entries = _controller.GetSchedule(this).ScheduleEntries;
            const string dateTimeFormat = @"MM/dd/yyyy hh:mm";

            foreach (var entry in entries)
            {
                var listViewItem = new ListViewItem(entry.Ad.Name);
                listViewItem.SubItems.Add(entry.Ad.AdContent);
                listViewItem.SubItems.Add(entry.StartTime.ToString(dateTimeFormat));
                listViewItem.SubItems.Add(entry.StartTime.ToString(dateTimeFormat));
                listAds.Items.Add(listViewItem);
            }
        }

        private void UpdateList()
        {
            foreach (var schedule in _schedules)
            {
                cbxSchedules.Items.Add(schedule.Name);
            }
        }

        private void Schedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSchedules.SelectedIndex > -1)
            {
                groupBoxAds.Enabled = true;
                UpdateAdsList();
            }
        }

        public string NameOfSchedule => cbxSchedules.SelectedItem.ToString();
        public void ShowModal(IMainController inMainController, IList<Schedule> inList)
        {
            _controller = inMainController;
            _schedules = inList;

            UpdateList();
            ShowDialog();
        }
    }
}