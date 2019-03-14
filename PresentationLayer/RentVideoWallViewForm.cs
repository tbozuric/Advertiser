using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using static System.Decimal;

namespace PresentationLayer
{
    public partial class RentVideoWallViewForm : Form, IRentVideoWallView
    {
        private readonly IMainController _controller;

        public RentVideoWallViewForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;
        }

        private void VideoWall_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormRentVideoWall_Load(object sender, EventArgs e)
        {
            var videoWalls = _controller.GetAllVideoWalls();

            foreach (var videoWall in videoWalls)
            {
                if (videoWall.Status == VideoWallStatus.FREE)
                {
                    cbxVideoWall.Items.Add(videoWall.Location);
                }
            }
        }

        private void ButtonRent_Click(object sender, EventArgs e)
        {
            if (cbxVideoWall.SelectedIndex != -1)
            {
                try
                {
                    _controller.RentVideoWall(this);
                    Close();
                }
                catch (Exception ex) when (ex is DateTimeRuleException ||
                                           ex is InvalidPriceException ||
                                           ex is InvalidPersonDataException)
                {
                    MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"No video wall selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        Address IRentVideoWallView.Location => (Address) cbxVideoWall.SelectedItem;
        public string Oib => textBoxOib.Text;
        string IRentVideoWallView.Name => textBoxName.Text;
        public string Surname => textBoxSurname.Text;
        public DateTime StartDate => dateTimeStartRental.Value;
        public DateTime EndDate => dateEndDateRental.Value;
        public float Price => ToSingle(numericPrice.Value);
    }
}