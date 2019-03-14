using System;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;

namespace PresentationLayer
{
    public partial class RemoveAdForm : Form, IRemoveAdView
    {
        private readonly IMainController _controller;

        public RemoveAdForm(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormRemoveAd_Load(object sender, EventArgs e)
        {
            var ads = _controller.GetAllAds();
            foreach (var ad in ads)
            {
                cbxAd.Items.Add(ad.Name + ":  " + ad.AdContent);
            }
        }

        private void ButtonRemoveAd_Click(object sender, EventArgs e)
        {
            if (cbxAd.SelectedIndex != -1)
            {
                var someScheduleUsesAd = _controller.DoesSomeScheduleUseAd(this);
                if (someScheduleUsesAd)
                {
                    var dialogResult = MessageBox.Show(@"Ad assigned to a schedule. Really remove?", @"Attention",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _controller.RemoveAd(this);
                        Close();
                    }
                }
                else
                {
                    _controller.RemoveAd(this);
                }

                Close();
            }
            else
            {
                MessageBox.Show(@"No ad selected!", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool ShowViewModal() => ShowDialog() == DialogResult.OK;
        public string NameOfAd => cbxAd.SelectedItem.ToString();
    }
}