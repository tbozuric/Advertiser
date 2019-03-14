using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using DomainModel.Repositories;

namespace Controller
{
    public class VideoWallController
    {
        public void AddNewVideoWall(IAddVideoWallView inForm, IRepository<VideoWall> videoWallRepository)
        {
            var adr = new Address(inForm.City, inForm.Street, inForm.ZipCode);
            var wall = new VideoWall(inForm.Width, inForm.Height, adr);
            videoWallRepository.Add(wall);
        }

        public void ShowAddVideoWall(IAddVideoWallView inForm)
        {
            inForm.ShowViewModal();
        }

        public bool DoesEmployeeRepairWall(IRemoveEmployeeView inForm, IRepository<VideoWall> repository)
        {
            var oib = inForm.EmployeeData.Oib;
            var use = repository.FindBy(x => x.Servicers.Count(servicer => servicer.Oib == oib) != 0);
            return use != null;
        }

        public bool DoesSomeWallUsesSchedule(IRemoveScheduleView inForm, IRepository<VideoWall> repository)
        {
            var scheduleName = inForm.NameOfSchedule.Trim();
            var use = repository.FindBy(x => x.Schedules.Count(schedule => schedule.Name.Equals(scheduleName)) != 0);
            return use != null;
        }


        public void RemoveVideoWall(IRemoveVideoWallView inForm, IRepository<VideoWall> repository)
        {
            var location = inForm.WallLocation;
            var city = location.City;
            var street = location.Street;
            var zipCode = location.ZipCode;
            var address = new Address(city, street, zipCode);

            repository.Delete(repository.FindBy(LocationExpression(address)));
        }

        public void ShowRemoveVideoWall(IRemoveVideoWallView inForm)
        {
            inForm.ShowViewModal();
        }

        public IList<string> GetVideoWallLocations(IRepository<VideoWall> repository)
        {
            var walls = repository.All();
            var locations = new List<string>();
            foreach (var wall in walls)
            {
                locations.Add(wall.Location.ToString());
            }

            return locations;
        }

        public IList<VideoWall> GetAllVideoWalls(IRepository<VideoWall> repository)
        {
            return repository.All().ToList();
        }

        public void ViewVideoWalls(IShowView<VideoWall> inForm, IRepository<VideoWall> videoWallRepository,
            IMainController controller)
        {
            IList<VideoWall> videoWalls = videoWallRepository.All().ToList();
            inForm.ShowModal(controller, videoWalls);
        }

        public void ManageVideoWalls(IManageVideoWallsView view, IRepository<VideoWall> repository,
            IMainController controller)
        {
            view.ShowModal(controller, repository.All().ToList());
        }


        public IList<Schedule> GetVideoWallSchedules(IManageVideoWallsView inForm,
            IRepository<VideoWall> videoWallRepository)
        {
            var location = inForm.Location;
            var videoWall = videoWallRepository.FindBy(LocationExpression(location));
            return videoWall.Schedules;
        }

        public void RemoveScheduleFromVideoWall(IManageVideoWallsView inForm,
            IRepository<VideoWall> videoWallRepository,
            string nameOfSchedule)
        {
            var location = inForm.Location;
            var videoWall = videoWallRepository.FindBy(LocationExpression(location));
            var schedule = videoWall.Schedules.FirstOrDefault(x => x.Name.Equals(nameOfSchedule));
            videoWall.Schedules.RemoveAt(videoWall.Schedules.IndexOf(schedule));
            videoWallRepository.Update(videoWall);
        }

        public IList<Employee> GetServicersOfVideoWall(IManageVideoWallsView inForm,
            IRepository<VideoWall> videoWallRepository)
        {
            var location = inForm.Location;
            return GetServicers(videoWallRepository, location);
        }

        public IList<Employee> GetServicersOfVideoWall(IAddServiceView inForm,
            IRepository<VideoWall> videoWallRepository)
        {
            var location = inForm.VideoWallLocation;
            return GetServicers(videoWallRepository, location);
        }

        private static IList<Employee> GetServicers(IRepository<VideoWall> videoWallRepository, Address location)
        {
            var walls = videoWallRepository.All().Where(LocationExpression(location));
            IList<Employee> employees = new List<Employee>();
            foreach (var wall in walls)
            {
                foreach (var servicer in wall.Servicers)
                {
                    employees.Add(servicer);
                }
            }

            return employees;
        }


        public VideoWall GetVideoWallByLocation(Address location, IRepository<VideoWall> repository)
        {
            return repository.FindBy(LocationExpression(location));
        }

        public void AddScheduleToVideoWall(IAddScheduleToVideoWallView inForm, VideoWall wall,
            IRepository<VideoWall> videoWallRepository, IRepository<Schedule> scheduleRepository)
        {
            var scheduleName = inForm.NameOfSchedule;
            var schedule = scheduleRepository.FindBy(x => x.Name == scheduleName);
            wall.Status = VideoWallStatus.USED;
            wall.Schedules.Add(schedule);
            videoWallRepository.Update(wall);
        }

        public void AddEmployeeToVideoWall(IAddEmployeeToVideoWallView inForm, VideoWall wall,
            IRepository<VideoWall> videoWallRepository, IRepository<Employee> employeeRepository)
        {
            var oib = inForm.Oib;
            var employee = employeeRepository.FindBy(x => x.Oib == oib);
            wall.Servicers.Add(employee);
            videoWallRepository.Update(wall);
        }

        public void RemoveEmployeeFromVideoWall(IManageVideoWallsView inForm, string oib,
            IRepository<VideoWall> repository)
        {
            var address = inForm.Location;
            var wall = repository.FindBy(LocationExpression(address));
            wall.Servicers.RemoveAt(wall.Servicers.IndexOf(wall.Servicers.FirstOrDefault(x => x.Oib.Equals(oib))));
            repository.Update(wall);
        }

        public void ShowStatistics(IVideoWallStatisticsView view)
        {
            view.ShowViewModal();
        }

        public void RentVideoWall(IRentVideoWallView inForm, IRepository<VideoWall> repository,
            IRepository<RentWall> rentalRepository)
        {
            var address = inForm.Location;
            var wall = repository.FindBy(LocationExpression(address));
            var oib = inForm.Oib;
            var name = inForm.Name;
            var surname = inForm.Surname;
            var startDate = inForm.StartDate;
            var endDate = inForm.EndDate;
            var price = inForm.Price;
            wall.Status = VideoWallStatus.RENTED;

            repository.Update(wall);

            var renter = new Person(oib, name, surname);
            var rent = new RentWall(wall, renter, startDate, endDate, price);
            rentalRepository.Add(rent);
        }


        public void ShowRentVideoWall(IRentVideoWallView view)
        {
            view.ShowViewModal();
        }

        public float GetVideoWallProfit(IVideoWallStatisticsView inForm, IRepository<RentWall> rentalRepository)
        {
            var address = inForm.Location;
            var startDate = inForm.StartDate;
            var endDate = inForm.EndDate;

            return rentalRepository.All().Where(x => x.VideoWall.Location.Equals(address) &&
                                                     DateTime.Compare(startDate, x.StartRentTime) <= 0
                                                     && DateTime.Compare(endDate, x.EndRentTime) >= 0)
                .Sum(x => x.Price);
        }


        private static Expression<Func<VideoWall, bool>> LocationExpression(Address address)
        {
            return x => x.Location.City == address.City &&
                        x.Location.Street == address.Street &&
                        x.Location.ZipCode == address.ZipCode;
        }
    }
}