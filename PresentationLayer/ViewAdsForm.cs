using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace PresentationLayer
{
    public partial class ViewAdsForm : Form, IShowView<Ad>
    {
        private IMainController _controller;
        private IList<Ad> _ads;

        public ViewAdsForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;

        }

        private void FormViewAds_Load(object sender, EventArgs e)
        {
        }

        private void ButtonAddAd_Click(object sender, EventArgs e)
        {
            _controller.ShowAddAd();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        public void ShowModal(IMainController inMainController, IList<Ad> ads)
        {
            _controller = inMainController;
            _ads = ads;

            UpdateList();
            ShowDialog();
        }

        public void UpdateView()
        {
            _ads = _controller.GetAllAds();
            UpdateList();
        }

        private void UpdateList()
        {
            listAds.Items.Clear();

            foreach (var ad in _ads)
            {
                var listViewItem = new ListViewItem(ad.Name);
                listViewItem.SubItems.Add(ad.AdContent);

                listAds.Items.Add(listViewItem);
            }
        }
    }
}