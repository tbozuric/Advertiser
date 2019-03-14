using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class AddAdForm : Form, IAddAdView
    {
        private readonly IMainController _controller;

        public AddAdForm(IMainController controller)
        {
            _controller = controller;
            InitializeComponent();
            Icon = Properties.Resources.Icon;
        }

        private void FormViewAds_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddAd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAdContent.TextLength == 0 || textBoxAdName.TextLength == 0)
                {
                    MessageBox.Show(@"Ad name and content must not be empty!", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else { 
                _controller.AddAd(this);
                Close();
                }
            }
            catch (Exception ex) when (ex is InvalidValueException || ex is AdWithNameAlreadyExistsException)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public string AdName => textBoxAdName.Text;
        public string Content => textBoxAdContent.Text;
    }
}