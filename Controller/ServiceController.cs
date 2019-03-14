using System;
using System.Collections.Generic;
using System.Linq;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using DomainModel.Repositories;

namespace Controller
{
    public class ServiceController
    {
        public int GetNumberOfRepairedFailuresByEmployee(IEmployeeServicesStatisticsView inForm,
            IRepository<Service> serviceRepository)
        {
            var startDate = inForm.StartDate;
            var endDate = inForm.EndDate;
            var oib = inForm.Oib;

            return serviceRepository.All().Count(x => x.ServicedBy.Oib.Equals(oib) &&
                                                      DateTime.Compare(startDate, x.ServiceStart) <= 0
                                                      && DateTime.Compare(endDate, x.ServiceEnd) >= 0);
        }

        public void ShowEmployeeServicesReport(IEmployeeServicesStatisticsView inForm)
        {
            inForm.ShowViewModal();
        }

        public int GetNumberOfFailuresOnVideoWall(IVideoWallStatisticsView inForm, IRepository<Service> repository)
        {
            var location = inForm.Location;
            var startDate = inForm.StartDate;
            var endDate = inForm.EndDate;

            return repository.All().Count(x => x.VideoWall.Location.Equals(location) &&
                                               DateTime.Compare(startDate, x.ServiceStart) <= 0
                                               && DateTime.Compare(endDate, x.ServiceEnd) >= 0);
        }

        public void ShowAddService(IAddServiceView inForm)
        {
            inForm.ShowViewModal();
        }


        public void AddNewService(IAddServiceView inForm, IRepository<Service> serviceRepository,
            IRepository<VideoWall> videoWallRepository)
        {
            var employee = inForm.Employee;
            var location = inForm.VideoWallLocation;
            var videoWall = videoWallRepository.FindBy(x => x.Location.City == location.City &&
                                                            x.Location.Street == location.Street &&
                                                            x.Location.ZipCode == location.ZipCode);

            var service = new Service(employee, inForm.ServiceStartTime,
                inForm.ServiceEndTime, inForm.FailureType, videoWall);

            serviceRepository.Add(service);
        }

        public IList<Service> GetServicesForVideoWall(
            IShowServicesForVideoWallView<VideoWall> showServicesForVideoWallView,
            IRepository<Service> serviceRepository)
        {
            var location = showServicesForVideoWallView.Location;
            return serviceRepository.All().Where(x => x.VideoWall.Location.City == location.City &&
                                                      x.VideoWall.Location.Street == location.Street &&
                                                      x.VideoWall.Location.ZipCode == location.ZipCode).ToList();
        }

        public void ShowServicesView(IShowServicesForVideoWallView<VideoWall> view, IMainController mainController,
            IList<VideoWall> videoWalls)
        {
            view.ShowModal(mainController, videoWalls);
        }
    }
}