using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ViewVideoWallsForm : Form, IShowView<VideoWall>
    {
        private IMainController _controller;
        private IList<VideoWall> _videoWalls;

        public ViewVideoWallsForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormViewVideoWalls_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddVideoWall_Click(object sender, EventArgs e)
        {
            _controller.ShowAddVideoWall();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateList()
        {
            listVideoWalls.Items.Clear();

            foreach (var videoWall in _videoWalls)
            {
                var listViewItem = new ListViewItem(videoWall.Location.ToString());
                listViewItem.SubItems.Add(videoWall.Width.ToString());
                listViewItem.SubItems.Add(videoWall.Height.ToString());
                listViewItem.SubItems.Add(videoWall.Status.ToString());

                listVideoWalls.Items.Add(listViewItem);
            }
        }

        public void ShowModal(IMainController inMainController, IList<VideoWall> videoWalls)
        {
            _controller = inMainController;
            _videoWalls = videoWalls;

            UpdateList();
            ShowDialog();
        }

        public void UpdateView()
        {
            _videoWalls = _controller.GetAllVideoWalls();
            UpdateList();
        }
    }
}