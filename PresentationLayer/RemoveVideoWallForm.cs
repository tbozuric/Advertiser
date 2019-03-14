using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;


namespace PresentationLayer
{
    public partial class RemoveVideoWallForm : Form, IRemoveVideoWallView
    {
        private readonly IMainController _controller;

        public RemoveVideoWallForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }


        private void FormRemoveVideoWall_Load(object sender, EventArgs e)
        {
            var locationsOfVideoWalls = _controller.GetVideoWallsLocations();
            foreach (var location in locationsOfVideoWalls)
            {
                cbxLocation.Items.Add(location);
            }
        }

        private void ButtonRemoveVideoWall_Click(object sender, EventArgs e)
        {
            if (cbxLocation.SelectedIndex != -1)
            {
                _controller.RemoveVideoWall(this);
                Close();
            }
            else
            {
                MessageBox.Show(@"No video wall selected!",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        Address IRemoveVideoWallView.WallLocation => (Address) cbxLocation.SelectedItem;
    }
}