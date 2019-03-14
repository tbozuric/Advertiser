using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddScheduleForm : Form, IAddScheduleView
    {
        private readonly IMainController _controller;


        public AddScheduleForm(IMainController inController)
        {
            _controller = inController;

            InitializeComponent();
            Icon = Properties.Resources.Icon;


            const string dateTimeFormat = @"MM/dd/yyyy hh:mm";
            dateTimeScheduleStart.Format = DateTimePickerFormat.Custom;
            dateTimeScheduleStart.CustomFormat = dateTimeFormat;

            dateTimeScheduleEnd.Format = DateTimePickerFormat.Custom;
            dateTimeScheduleEnd.CustomFormat = dateTimeFormat;
        }

        private void FormAddSchedule_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.AddSchedule(this);
                Close();
            }
            catch (Exception ex) when (ex is InvalidValueException || ex is DateTimeRuleException ||
                                       ex is ScheduleWithNameAlreadyExistsException)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public string ScheduleName => tbxScheduleName.Text;
        public DateTime ScheduleStartTime => dateTimeScheduleStart.Value;
        public DateTime ScheduleEndTime => dateTimeScheduleEnd.Value;
    }
}