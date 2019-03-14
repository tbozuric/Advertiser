using System.Collections.Generic;
using BaseLib.ViewInterfaces;
using DomainModel;

namespace BaseLib
{
    public interface IMainController
    {
        void ShowVideoWalls();
        bool DoesEmployeeRepairSomeWall(IRemoveEmployeeView inForm);
        IList<Employee> GetAllEmployees();
        void ShowAddVideoWall();
        void AddVideoWall(IAddVideoWallView inForm);
        void RemoveVideoWall(IRemoveVideoWallView inForm);
        void ShowRemoveVideoWall();
        IList<string> GetVideoWallsLocations();
        void ShowManageVideoWalls();
        void ShowAds();
        void ShowAddAd();
        void ShowRemoveAd();
        void RemoveAd(IRemoveAdView inForm);
        void ShowSchedules();
        void ShowAddSchedule();
        void AddSchedule(IAddScheduleView inForm);
        void RemoveSchedule(IRemoveScheduleView inForm);
        void ShowRemoveSchedule();
        void ShowManageSchedules();
        void ShowServices();
        void ShowAddService();
        void AddService(IAddServiceView inForm);
        void ShowEmployees();
        void ShowAddEmployee();
        void AddEmployee(IAddEmployeeView inForm);
        void RemoveEmployee(IRemoveEmployeeView inForm);
        void AddAd(IAddAdView inForm);
        void ShowRemoveEmployee();
        void ShowVideoWallStatistics();
        int GetEmployeeStatistics(IEmployeeServicesStatisticsView inForm);
        float GetVideoWallProfitStatistics(IVideoWallStatisticsView inForm);
        int GetVideoWallFailuresStatistics(IVideoWallStatisticsView inForm);
        void ShowEmployeesStatistics();
        IList<Schedule> GetAllSchedules();
        bool DoesSomeWallUseSchedule(IRemoveScheduleView inForm);
        IList<Ad> GetAllAds();
        bool DoesSomeScheduleUseAd(IRemoveAdView removeAd);
        IList<VideoWall> GetAllVideoWalls();
        IList<Schedule> GetVideoWallSchedules(IManageVideoWallsView inForm);
        void RemoveScheduleFromVideoWall(IManageVideoWallsView inForm, string nameOfSchedule);
        void ShowAddScheduleToVideoWall(IManageVideoWallsView inForm);
        void AddScheduleToVideoWall(IAddScheduleToVideoWallView inForm, VideoWall wall);
        void ShowAddEmployeeToVideoWall(IManageVideoWallsView inForm);
        void AddEmployeeToVideoWall(IAddEmployeeToVideoWallView inForm, VideoWall wall);
        void RemoveEmployeeFromVideoWall(IManageVideoWallsView inForm, string oib);
        IList<Employee> GetServicersOfVideoWall(IManageVideoWallsView inForm);
        IList<Employee> GetServicersOfVideoWall(IAddServiceView inForm);
        void AddServiceForVideoWall(IShowServicesForVideoWallView<VideoWall> inForm);
        IList<Service> GetServicesForVideoWall(IShowServicesForVideoWallView<VideoWall> showServicesForVideoWallView);
        void ShowAddAdToSchedule(IManageSchedulesView inForm);
        void AddAdToSchedule(IAddAdToScheduleView inForm, Schedule schedule);
        Schedule GetSchedule(IManageSchedulesView inForm);
        void RemoveAdFromSchedule(IManageSchedulesView inForm, string adName);
        void ShowRentVideoWall();
        void RentVideoWall(IRentVideoWallView inForm);

       
    }
}