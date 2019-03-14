using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddEmployeeToVideoWallForm : Form, IAddEmployeeToVideoWallView
    {
        private readonly IMainController _controller;
        private readonly VideoWall _videoWall;

        public AddEmployeeToVideoWallForm(IMainController inController, VideoWall videoWall)
        {
            _controller = inController;
            _videoWall = videoWall;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex > -1)
            {
                _controller.AddEmployeeToVideoWall(this, _videoWall);
                Close();
            }
            else
            {
                MessageBox.Show(@"No employee selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddEmployeeToVideoWall_Load(object sender, EventArgs e)
        {
            var employees = _controller.GetAllEmployees();

            foreach (var employee in employees)
            {
                if (!_videoWall.Servicers.Contains(employee))
                {
                    cbxEmployee.Items.Add(employee);
                }
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;

        public string Oib => ((Employee) cbxEmployee.SelectedItem).Oib;
    }
}