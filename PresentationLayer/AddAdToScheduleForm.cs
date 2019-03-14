using System;
using System.Linq;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddAdToScheduleForm : Form, IAddAdToScheduleView
    {
        private readonly IMainController _controller;
        private readonly Schedule _schedule;

        public AddAdToScheduleForm(IMainController inController, Schedule schedule)
        {
            _controller = inController;
            _schedule = schedule;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

            const string dateTimeFormat = @"MM/dd/yyyy hh:mm";
            dateTimeStartBroadcast.Format = DateTimePickerFormat.Custom;
            dateTimeStartBroadcast.CustomFormat = dateTimeFormat;

            dateTimeEndBroadcast.Format = DateTimePickerFormat.Custom;
            dateTimeEndBroadcast.CustomFormat = dateTimeFormat;

            dateTimeStartBroadcast.MinDate = schedule.ScheduleStart;
            //dateTimeStartBroadcast.MaxDate = schedule.ScheduleStop;
            dateTimeEndBroadcast.MaxDate = schedule.ScheduleStop;
            //dateTimeEndBroadcast.MinDate = schedule.ScheduleStart;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (cbxAd.SelectedIndex > -1)
            {
                try
                {
                    _controller.AddAdToSchedule(this, _schedule);
                    Close();
                }
                catch (DateTimeRuleException ex)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"No ad selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddAdToSchedule_Load(object sender, EventArgs e)
        {
            var ads = _controller.GetAllAds();

            foreach (var ad in ads)
            {
                if (_schedule.ScheduleEntries.Count(x => x.Ad.Name.Equals(ad.Name)) == 0)
                {
                    cbxAd.Items.Add(ad);
                }
            }
        }

        public Ad Ad => (Ad) cbxAd.SelectedItem;
        public DateTime StartBroadcast => dateTimeStartBroadcast.Value;
        public DateTime EndBroadcast => dateTimeEndBroadcast.Value;
        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
    }
}