using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddServiceForm : Form, IAddServiceView
    {
        private readonly IMainController _controller;

        public AddServiceForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;


            const string dateTimeFormat = @"MM/dd/yyyy hh:mm";
            dateTimeServiceStart.Format = DateTimePickerFormat.Custom;
            dateTimeServiceStart.CustomFormat = dateTimeFormat;

            dateTimeServiceEnd.Format = DateTimePickerFormat.Custom;
            dateTimeServiceEnd.CustomFormat = dateTimeFormat;
        }

        private void FormAddService_Load(object sender, EventArgs e)
        {
            var videoWalls = _controller.GetAllVideoWalls();
            foreach (var videoWall in videoWalls)
            {
                cbxVideoWall.Items.Add(videoWall.Location);
            }

            cbxFailureType.Items.Add(FailureType.ELECTRICAL);
            cbxFailureType.Items.Add(FailureType.MECHANICAL);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddService_Click(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex != -1 && cbxVideoWall.SelectedIndex != -1 &&
                cbxFailureType.SelectedIndex != -1)
            {
                try
                {
                    _controller.AddService(this);
                    Close();
                }
                catch (Exception ex) when (ex is DateTimeRuleException || ex is InvalidValueException)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Video wall, employee and failure type must be selected.", @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CbxVideoWall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex <= -1) return;
            cbxEmployee.Items.Clear();

            var servicers = _controller.GetServicersOfVideoWall(this);

            foreach (var servicer in servicers)
            {
                cbxEmployee.Items.Add(servicer);
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public DateTime ServiceStartTime => dateTimeServiceStart.Value;
        public DateTime ServiceEndTime => dateTimeServiceEnd.Value;
        public Address VideoWallLocation => (Address) cbxVideoWall.SelectedItem;

        public void SnoozeVideoWall(VideoWall videoWall)
        {
            cbxVideoWall.Items.Clear();
            cbxVideoWall.Items.Add(videoWall.Location);
            cbxVideoWall.SelectedIndex = 0;
            cbxVideoWall.Enabled = false;
        }

        public Employee Employee => (Employee) cbxEmployee.SelectedItem;
        public FailureType FailureType => (FailureType) cbxFailureType.SelectedItem;
    }
}