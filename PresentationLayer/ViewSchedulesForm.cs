using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ViewSchedulesForm : Form, IShowView<Schedule>
    {
        private IMainController _controller;
        private IList<Schedule> _schedules;

        public ViewSchedulesForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormViewSchedules_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddSchedule_Click(object sender, EventArgs e)
        {
            _controller.ShowAddSchedule();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateList()
        {
            listSchedules.Items.Clear();


            foreach (var schedule in _schedules)
            {
                var listViewItem = new ListViewItem(schedule.Name);
                listViewItem.SubItems.Add(schedule.ScheduleStart.ToString(@"MM/dd/yyyy hh:mm"));
                listViewItem.SubItems.Add(schedule.ScheduleStop.ToString(@"MM/dd/yyyy hh:mm"));

                listSchedules.Items.Add(listViewItem);
            }
        }

        public void ShowModal(IMainController inMainController, IList<Schedule> inList)
        {
            _controller = inMainController;
            _schedules = inList;

            UpdateList();
            ShowDialog();
        }

        public void UpdateView()
        {
            _schedules = _controller.GetAllSchedules();
            UpdateList();
        }
    }
}