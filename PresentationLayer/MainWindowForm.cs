using System;
using System.Windows.Forms;
using BaseLib;

namespace PresentationLayer
{
    public partial class MainWindowForm : Form
    {
        private readonly IMainController _controller;

        public MainWindowForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }


        private void ViewVideoWallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowVideoWalls();
        }

        private void AddVideoWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAddVideoWall();
        }

        private void ManageVideoWallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowManageVideoWalls();
        }

        private void RemoveVideoWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowRemoveVideoWall();
        }

        private void RentVideoWallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowRentVideoWall();
        }

        private void ViewAdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAds();
        }

        private void AddAdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAddAd();
        }

        private void RemoveAdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowRemoveAd();
        }

        private void ViewSchedulesStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowSchedules();
        }

        private void AddScheduleStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAddSchedule();
        }

        private void RemoveScheduleStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowRemoveSchedule();
        }

        private void ManageSchedulesStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowManageSchedules();
        }

        private void ViewServicesStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowServices();
        }

        private void AddServiceStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAddService();
        }

        private void ViewEmployeesStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowEmployees();
        }

        private void AddEmployeeStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowAddEmployee();
        }

        private void RemoveEmployeeStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowRemoveEmployee();
        }

        private void ShowWallSummaryStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowVideoWallStatistics();
        }

        private void ShowEmployeesSummaryStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowEmployeesStatistics();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
        }
    }
}