using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using static System.Decimal;

namespace PresentationLayer
{
    public partial class AddVideoWallForm : Form, IAddVideoWallView
    {
        private readonly IMainController _controller;

        public AddVideoWallForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormAddVideoWall_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddWall_Click(object sender, EventArgs e)
        {
            try
            {
                //referenca na IAddVideoWallView
                _controller.AddVideoWall(this);
                Close();
            }
            catch (Exception ex) when (ex is AddressNullReferenceException || ex is InvalidValueException ||
                                       ex is VideoWallAtLocationAlreadyExistsException)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        short IAddVideoWallView.Width => ToInt16(numericWidth.Value);
        short IAddVideoWallView.Height => ToInt16(numericWidth.Value);
        string IAddVideoWallView.City => tbxCity.Text;
        string IAddVideoWallView.Street => tbxStreet.Text;
        short IAddVideoWallView.ZipCode => ToInt16(numericZipCode.Value);
        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
    }
}