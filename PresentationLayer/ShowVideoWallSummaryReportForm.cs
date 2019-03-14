using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ShowVideoWallSummaryReportForm : Form, IVideoWallStatisticsView
    {
        private readonly IMainController _controller;
        private readonly IList<VideoWall> _videoWalls;

        public ShowVideoWallSummaryReportForm(IMainController inController, IList<VideoWall> walls
        )
        {
            _controller = inController;
            _videoWalls = walls;
            InitializeComponent();
            Icon = Properties.Resources.Icon;


            UpdateList();

            const string dateTimeFormat = @"MM/dd/yyyy hh:mm";
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = dateTimeFormat;

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = dateTimeFormat;
        }

        private void UpdateList()
        {
            cbxVideoWall.Items.Clear();

            foreach (var videoWall in _videoWalls)
            {
                cbxVideoWall.Items.Add(videoWall.Location);
            }
        }

        private void FormShowVideoWallSummaryReport_Load(object sender, EventArgs e)
        {
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VideoWall_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;

        Address IVideoWallStatisticsView.Location => (Address) cbxVideoWall.SelectedItem;
        public DateTime StartDate => dateTimeStart.Value;
        public DateTime EndDate => dateTimeEnd.Value;

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex != -1)
            {
                lblProfit.Text = @"N/A";
                lblNumberOfFailures.Text = @"N/A";
                var profit = _controller.GetVideoWallProfitStatistics(this);
                var numberOfFailures = _controller.GetVideoWallFailuresStatistics(this);

                lblProfit.Text = profit.ToString(CultureInfo.InvariantCulture);
                lblNumberOfFailures.Text = numberOfFailures.ToString();
            }
        }
    }
}