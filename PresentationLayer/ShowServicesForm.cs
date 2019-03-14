using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ShowServicesForm : Form, IShowServicesForVideoWallView<VideoWall>
    {
        private IMainController _controller;
        private IList<VideoWall> _videoWalls;
        private IList<Service> _services;

        public ShowServicesForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex != -1)
            {
                _controller.AddServiceForVideoWall(this);
            }
            else
            {
                MessageBox.Show(@"No video wall selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VideoWall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex != -1)
            {
                _services = _controller.GetServicesForVideoWall(this);
                UpdateList();
            }
            else
            {
                MessageBox.Show(@"No video wall selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormShowServices_Load(object sender, EventArgs e)
        {
        }

        private void UpdateList()
        {
            listServices.Items.Clear();
            foreach (var service in _services)
            {
                var listViewItem = new ListViewItem(service.ServiceStart.ToString(@"MM/dd/yyyy hh:mm"));
                listViewItem.SubItems.Add(service.ServiceEnd.ToString(@"MM/dd/yyyy hh:mm"));
                listViewItem.SubItems.Add(service.ServicedBy.ToString());
                listViewItem.SubItems.Add(service.FailureType.ToString());

                listServices.Items.Add(listViewItem);
            }
        }

        public void ShowModal(IMainController inMainController, IList<VideoWall> inList)
        {
            _controller = inMainController;
            _videoWalls = inList;

            UpdateWallsList();
            ShowDialog();
        }

        private void UpdateWallsList()
        {
            cbxVideoWall.Items.Clear();
            foreach (var videoWall in _videoWalls)
            {
                cbxVideoWall.Items.Add(videoWall.Location);
            }
        }

        public void UpdateView()
        {
            _services = _controller.GetServicesForVideoWall(this);
            UpdateList();
        }

        Address IShowServicesForVideoWallView<VideoWall>.Location => (Address) cbxVideoWall.SelectedItem;
    }
}