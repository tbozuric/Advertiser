using System.Collections.Generic;
using System.Linq;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using DomainModel.Repositories;

namespace Controller
{
    public class AdController
    {
        public void AddNewAd(IAddAdView inForm, IRepository<Ad> adRepository)
        {
            var name = inForm.AdName;
            var adContent = inForm.Content;

            var ad = new Ad(name,  adContent);
            adRepository.Add(ad);
        }

        public IList<Ad> GetAllAds(IRepository<Ad> repository)
        {
            return repository.All().ToList();
        }

        public void ShowAddAd(IAddAdView inForm)
        {
            inForm.ShowViewModal();
        }


        public void RemoveAd(IRemoveAdView inForm, IRepository<Ad> repository)
        {
            var nameOfAd = inForm.NameOfAd;
            repository.Delete(repository.FindBy(x => x.Name == nameOfAd));
        }

        public void ShowRemoveAd(IRemoveAdView inForm)
        {
            inForm.ShowViewModal();
        }

        public void ShowAds(IShowView<Ad> inForm, IRepository<Ad> adRepository,
            IMainController controller)
        {
            IList<Ad> ads = adRepository.All().ToList();
            inForm.ShowModal(controller, ads);
        }
    }
}