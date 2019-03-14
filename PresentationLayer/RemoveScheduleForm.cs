using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;

namespace PresentationLayer
{
    public partial class RemoveScheduleForm : Form, IRemoveScheduleView
    {
        private readonly IMainController _controller;

        public RemoveScheduleForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormRemoveSchedule_Load(object sender, EventArgs e)
        {
            var schedules = _controller.GetAllSchedules();
            foreach (var schedule in schedules)
            {
                cbxSchedule.Items.Add(schedule);
            }
        }

        private void ButtonRemoveSchedule_Click(object sender, EventArgs e)
        {
            if (cbxSchedule.SelectedIndex != -1)
            {
                var someWallUsesSchedule = _controller.DoesSomeWallUseSchedule(this);
                if (someWallUsesSchedule)
                {
                    var dialogResult = MessageBox.Show(@"Video wall uses this schedule. Really remove?",
                        @"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _controller.RemoveSchedule(this);
                        Close();
                    }
                }
                else
                {
                    _controller.RemoveSchedule(this);
                }

                Close();
            }
            else
            {
                MessageBox.Show(@"No schedule selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public string NameOfSchedule => cbxSchedule.SelectedItem.ToString();
    }
}