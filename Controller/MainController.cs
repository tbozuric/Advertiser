using System.Collections.Generic;
using BaseLib;
using BaseLib.ViewInterfaces;
using DataAccessLayer.Repositories;
using DomainModel;
using PresentationLayer;

namespace Controller
{
    public class MainController : IMainController
    {
        private readonly VideoWallRepository _videoWallRepository = VideoWallRepository.GetInstance();
        private readonly EmployeeRepository _employeeRepository = EmployeeRepository.GetInstance();
        private readonly AdRepository _adRepository = AdRepository.GetInstance();
        private readonly ScheduleRepository _scheduleRepository = ScheduleRepository.GetInstance();
        private readonly ServiceRepository _serviceRepository = ServiceRepository.GetInstance();
        private readonly RentalRepository _rentalRepository = RentalRepository.GetInstance();

        private readonly VideoWallController _videoWallController = new VideoWallController();
        private readonly EmployeeController _employeeController = new EmployeeController();
        private readonly ScheduleController _scheduleController = new ScheduleController();
        private readonly AdController _adController = new AdController();
        private readonly ServiceController _serviceController = new ServiceController();

        public void ShowVideoWalls()
        {
            IShowView<VideoWall> showVideoWalls = new ViewVideoWallsForm();
            _videoWallRepository.Attach(showVideoWalls);
            _videoWallController.ViewVideoWalls(showVideoWalls, _videoWallRepository, this);
            _videoWallRepository.Delete(showVideoWalls);
        }

        public bool DoesEmployeeRepairSomeWall(IRemoveEmployeeView inForm)
        {
            return _videoWallController.DoesEmployeeRepairWall(inForm, _videoWallRepository);
        }

        public IList<Employee> GetAllEmployees()
        {
            return _employeeController.GetAllEmployees(_employeeRepository);
        }

        public void ShowAddVideoWall()
        {
            IAddVideoWallView inForm = new AddVideoWallForm(this);
            _videoWallController.ShowAddVideoWall(inForm);
        }

        public void AddVideoWall(IAddVideoWallView inForm)
        {
            _videoWallController.AddNewVideoWall(inForm, _videoWallRepository);
        }

        public void RemoveVideoWall(IRemoveVideoWallView inForm)
        {
            _videoWallController.RemoveVideoWall(inForm, _videoWallRepository);
        }

        public void ShowRemoveVideoWall()
        {
            IRemoveVideoWallView inForm = new RemoveVideoWallForm(this);
            _videoWallController.ShowRemoveVideoWall(inForm);
        }

        public IList<string> GetVideoWallsLocations()
        {
            return _videoWallController.GetVideoWallLocations(_videoWallRepository);
        }

        public void ShowManageVideoWalls()
        {
            IManageVideoWallsView view = new ManageVideoWallsForm();
            _employeeRepository.Attach(view);
            _videoWallRepository.Attach(view);

            _videoWallController.ManageVideoWalls(view, _videoWallRepository, this);

            _employeeRepository.Delete(view);
            _videoWallRepository.Delete(view);
        }

        public void ShowAds()
        {
            IShowView<Ad> showAdsView = new ViewAdsForm();
            _adRepository.Attach(showAdsView);
            _adController.ShowAds(showAdsView, _adRepository, this);
            _employeeRepository.Delete(showAdsView);
        }

        public void ShowAddAd()
        {
            IAddAdView view = new AddAdForm(this);
            _adController.ShowAddAd(view);
        }

        public void ShowRemoveAd()
        {
            IRemoveAdView view = new RemoveAdForm(this);
            _adController.ShowRemoveAd(view);
        }

        public void RemoveAd(IRemoveAdView inForm)
        {
            _adController.RemoveAd(inForm, _adRepository);
        }

        public void ShowSchedules()
        {
            IShowView<Schedule> showScheduleView = new ViewSchedulesForm();
            _scheduleRepository.Attach(showScheduleView);
            _scheduleController.ViewSchedules(showScheduleView, _scheduleRepository, this);
            _employeeRepository.Delete(showScheduleView);
        }

        public void ShowAddSchedule()
        {
            IAddScheduleView inForm = new AddScheduleForm(this);
            _scheduleController.ShowAddSchedule(inForm);
        }

        public void AddSchedule(IAddScheduleView inForm)
        {
            _scheduleController.AddNewSchedule(inForm, _scheduleRepository);
        }

        public void RemoveSchedule(IRemoveScheduleView inForm)
        {
            _scheduleController.RemoveSchedule(inForm, _scheduleRepository);
        }

        public void ShowRemoveSchedule()
        {
            IRemoveScheduleView removeView = new RemoveScheduleForm(this);
            _scheduleController.ShowRemoveSchedule(removeView);
        }

        public void ShowManageSchedules()
        {
            IManageSchedulesView view = new ManageSchedulesForm();
            _scheduleRepository.Attach(view);
            _adRepository.Attach(view);
            _scheduleController.ManageSchedules(view, this, _scheduleRepository);

            _scheduleRepository.Delete(view);
            _adRepository.Delete(view);
        }

        public void ShowServices()
        {
            IShowServicesForVideoWallView<VideoWall> view = new ShowServicesForm();
            _serviceRepository.Attach(view);
            _serviceController.ShowServicesView(view, this,
                _videoWallController.GetAllVideoWalls(_videoWallRepository));
            _serviceRepository.Delete(view);
        }

        public void ShowAddService()
        {
            IAddServiceView inForm = new AddServiceForm(this);
            _serviceController.ShowAddService(inForm);
        }

        public void AddService(IAddServiceView inForm)
        {
            _serviceController.AddNewService(inForm, _serviceRepository, _videoWallRepository);
        }


        public void ShowEmployees()
        {
            IShowView<Employee> showEmployeesView = new ViewEmployeesForm();
            _employeeRepository.Attach(showEmployeesView);
            _employeeController.ViewEmployees(showEmployeesView, _employeeRepository, this);
            _employeeRepository.Delete(showEmployeesView);
        }

        public void ShowAddEmployee()
        {
            IAddEmployeeView inForm = new AddEmployeeForm(this);
            _employeeController.ShowAddEmployee(inForm);
        }

        public void AddEmployee(IAddEmployeeView inForm)
        {
            _employeeController.AddNewEmployee(inForm, _employeeRepository);
        }

        public void RemoveEmployee(IRemoveEmployeeView inForm)
        {
            _employeeController.RemoveEmployee(inForm, _employeeRepository);
        }

        public void AddAd(IAddAdView inForm)
        {
            _adController.AddNewAd(inForm, _adRepository);
        }

        public void ShowRemoveEmployee()
        {
            IRemoveEmployeeView inForm = new RemoveEmployeeForm(this);
            _employeeController.ShowRemoveEmployee(inForm);
        }

        public void ShowVideoWallStatistics()
        {
            IVideoWallStatisticsView view =
                new ShowVideoWallSummaryReportForm(this, _videoWallController.GetAllVideoWalls(_videoWallRepository));
            _videoWallController.ShowStatistics(view);
        }

        public int GetEmployeeStatistics(IEmployeeServicesStatisticsView inForm)
        {
            return _serviceController.GetNumberOfRepairedFailuresByEmployee(inForm, _serviceRepository);
        }

        public float GetVideoWallProfitStatistics(IVideoWallStatisticsView inForm)
        {
            return _videoWallController.GetVideoWallProfit(inForm, _rentalRepository);
        }

        public int GetVideoWallFailuresStatistics(IVideoWallStatisticsView inForm)
        {
            return _serviceController.GetNumberOfFailuresOnVideoWall(inForm, _serviceRepository);
        }

        public void ShowEmployeesStatistics()
        {
            IEmployeeServicesStatisticsView view = new ShowEmployeeServicesReportForm(this,
                _employeeController.GetAllEmployees(_employeeRepository));
            _serviceController.ShowEmployeeServicesReport(view);
        }

        public IList<Schedule> GetAllSchedules()
        {
            return _scheduleController.GetAllSchedules(_scheduleRepository);
        }

        public bool DoesSomeWallUseSchedule(IRemoveScheduleView inForm)
        {
            return _videoWallController.DoesSomeWallUsesSchedule(inForm, _videoWallRepository);
        }

        public IList<Ad> GetAllAds()
        {
            return _adController.GetAllAds(_adRepository);
        }

        public bool DoesSomeScheduleUseAd(IRemoveAdView removeAd)
        {
            return _scheduleController.DoesSomeScheduleUseAd(removeAd, _scheduleRepository);
        }

        public IList<VideoWall> GetAllVideoWalls()
        {
            return _videoWallController.GetAllVideoWalls(_videoWallRepository);
        }

        public IList<Schedule> GetVideoWallSchedules(IManageVideoWallsView inForm)
        {
            return _videoWallController.GetVideoWallSchedules(inForm, _videoWallRepository);
        }

        public void RemoveScheduleFromVideoWall(IManageVideoWallsView inForm, string nameOfSchedule)
        {
            _videoWallController.RemoveScheduleFromVideoWall(inForm, _videoWallRepository, nameOfSchedule);
        }

        public void ShowAddScheduleToVideoWall(IManageVideoWallsView inForm)
        {
            var videoWall = _videoWallController.GetVideoWallByLocation(inForm.Location, _videoWallRepository);
            IAddScheduleToVideoWallView view = new AddScheduleToVideoWallForm(this, videoWall);
            _scheduleController.ShowAddScheduleToVideoWall(view);
        }

        public void AddScheduleToVideoWall(IAddScheduleToVideoWallView inForm, VideoWall wall)
        {
            _videoWallController.AddScheduleToVideoWall(inForm, wall, _videoWallRepository, _scheduleRepository);
        }

        public void ShowAddEmployeeToVideoWall(IManageVideoWallsView inForm)
        {
            var videoWall = _videoWallController.GetVideoWallByLocation(inForm.Location, _videoWallRepository);
            IAddEmployeeToVideoWallView view = new AddEmployeeToVideoWallForm(this, videoWall);
            _employeeController.ShowAddEmployeeToVideoWall(view);
        }

        public void AddEmployeeToVideoWall(IAddEmployeeToVideoWallView inForm, VideoWall wall)
        {
            _videoWallController.AddEmployeeToVideoWall(inForm, wall, _videoWallRepository, _employeeRepository);
        }

        public void RemoveEmployeeFromVideoWall(IManageVideoWallsView inForm, string oib)
        {
            _videoWallController.RemoveEmployeeFromVideoWall(inForm, oib, _videoWallRepository);
        }

        public IList<Employee> GetServicersOfVideoWall(IManageVideoWallsView inForm)
        {
            return _videoWallController.GetServicersOfVideoWall(inForm, _videoWallRepository);
        }

        public IList<Employee> GetServicersOfVideoWall(IAddServiceView inForm)
        {
            return _videoWallController.GetServicersOfVideoWall(inForm, _videoWallRepository);
        }

        public void AddServiceForVideoWall(IShowServicesForVideoWallView<VideoWall> inForm)
        {
            IAddServiceView addServiceView = new AddServiceForm(this);
            var videoWall = _videoWallController.GetVideoWallByLocation(inForm.Location, _videoWallRepository);
            addServiceView.SnoozeVideoWall(videoWall);
            _serviceController.ShowAddService(addServiceView);
        }

        public IList<Service> GetServicesForVideoWall(
            IShowServicesForVideoWallView<VideoWall> showServicesForVideoWallView)
        {
            return _serviceController.GetServicesForVideoWall(showServicesForVideoWallView, _serviceRepository);
        }

        public void ShowAddAdToSchedule(IManageSchedulesView inForm)
        {
            var schedule = _scheduleController.GetScheduleByName(inForm, _scheduleRepository);
            IAddAdToScheduleView view = new AddAdToScheduleForm(this, schedule);
            _scheduleController.ShowAddAdToVideoWall(view);
        }

        public void AddAdToSchedule(IAddAdToScheduleView inForm, Schedule schedule)
        {
            _scheduleController.AddAdToSchedule(inForm, schedule, _scheduleRepository);
        }

        public Schedule GetSchedule(IManageSchedulesView inForm)
        {
            return _scheduleController.GetScheduleByName(inForm, _scheduleRepository);
        }

        public void RemoveAdFromSchedule(IManageSchedulesView inForm, string adName)
        {
            _scheduleController.RemoveAdFromSchedule(inForm, adName, _scheduleRepository);
        }

        public void ShowRentVideoWall()
        {
            IRentVideoWallView view = new RentVideoWallViewForm(this);
            _videoWallController.ShowRentVideoWall(view);
        }

        public void RentVideoWall(IRentVideoWallView inForm)
        {
            _videoWallController.RentVideoWall(inForm, _videoWallRepository, _rentalRepository);
        }
    }
}