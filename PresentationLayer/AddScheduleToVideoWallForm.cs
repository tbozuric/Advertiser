using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddScheduleToVideoWallForm : Form, IAddScheduleToVideoWallView
    {
        private readonly IMainController _controller;
        private readonly VideoWall _videoWall;

        public AddScheduleToVideoWallForm(IMainController inController, VideoWall videoWall)
        {
            _controller = inController;
            _videoWall = videoWall;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (cbxSchedule.SelectedIndex > -1)
            {
                _controller.AddScheduleToVideoWall(this, _videoWall);
                Close();
            }
            else
            {
                MessageBox.Show(@"No schedule selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormAddScheduleToVideoWall_Load(object sender, EventArgs e)
        {
            var schedules = _controller.GetAllSchedules();

            foreach (var schedule in schedules)
            {
                if (!_videoWall.Schedules.Contains(schedule))
                {
                    cbxSchedule.Items.Add(schedule);
                }
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public string NameOfSchedule => ((Schedule) cbxSchedule.SelectedItem).Name;
    }
}