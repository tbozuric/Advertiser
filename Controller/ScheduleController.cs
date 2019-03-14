using System.Collections.Generic;
using System.Linq;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using DomainModel.Repositories;

namespace Controller
{
    public class ScheduleController
    {
        public void AddNewSchedule(IAddScheduleView inForm, IRepository<Schedule> scheduleRepository)
        {
            var name = inForm.ScheduleName;
            var startDate = inForm.ScheduleStartTime;
            var endDate = inForm.ScheduleEndTime;

            var schedule = new Schedule(name, startDate, endDate);

            scheduleRepository.Add(schedule);
        }

        public IList<Schedule> GetAllSchedules(IRepository<Schedule> repository)
        {
            return repository.All().ToList();
        }

        public void ShowAddSchedule(IAddScheduleView inForm)
        {
            inForm.ShowViewModal();
        }


        public void RemoveSchedule(IRemoveScheduleView inForm, IRepository<Schedule> repository)
        {
            var nameOfSchedule = inForm.NameOfSchedule;
            repository.Delete(repository.FindBy(x => x.Name == nameOfSchedule));
        }

        public void ShowRemoveSchedule(IRemoveScheduleView inForm)
        {
            inForm.ShowViewModal();
        }

        public bool DoesSomeScheduleUseAd(IRemoveAdView inForm, IRepository<Schedule> repository)
        {
            var adName = inForm.NameOfAd.Trim();
            var use = repository.FindBy(x => x.ScheduleEntries.Count(entry => entry.Ad.Name.Equals(adName)) != 0);
            return use != null;
        }

        public void ViewSchedules(IShowView<Schedule> inForm, IRepository<Schedule> scheduleRepository,
            IMainController controller)
        {
            IList<Schedule> employees = scheduleRepository.All().ToList();
            inForm.ShowModal(controller, employees);
        }


        public void ShowAddScheduleToVideoWall(IAddScheduleToVideoWallView inForm)
        {
            inForm.ShowViewModal();
        }

        public void ShowAddAdToVideoWall(IAddAdToScheduleView inForm)
        {
            inForm.ShowViewModal();
        }

        public Schedule GetScheduleByName(IManageSchedulesView inForm, IRepository<Schedule> scheduleRepository)
        {
            var name = inForm.NameOfSchedule;
            return scheduleRepository.FindBy(x => x.Name == name);
        }

        public void AddAdToSchedule(IAddAdToScheduleView inForm, Schedule schedule,
            IRepository<Schedule> scheduleRepository)
        {
            var ad = inForm.Ad;
            var scheduleEntry = new ScheduleEntry(ad, inForm.StartBroadcast, inForm.EndBroadcast);
            schedule.ScheduleEntries.Add(scheduleEntry);
            scheduleRepository.Update(schedule);
        }

        public IList<ScheduleEntry> GetScheduleEntries(IManageSchedulesView inForm, IRepository<Schedule> scheduleRepository)
        {
            var name = inForm.NameOfSchedule;
            var schedule = scheduleRepository.FindBy(x => x.Name == name);
            return schedule.ScheduleEntries;
        }


        public void RemoveAdFromSchedule(IManageSchedulesView inForm, string nameOfAd,
            IRepository<Schedule> scheduleRepository)
        {
            var name = inForm.NameOfSchedule;
            var schedule = scheduleRepository.FindBy(x => x.Name == name);
            schedule.ScheduleEntries.RemoveAt(schedule.ScheduleEntries
                .IndexOf(schedule.ScheduleEntries.FirstOrDefault(x => x.Ad.Name == nameOfAd)));
            scheduleRepository.Update(schedule);
        }

        public void ManageSchedules(IManageSchedulesView view, IMainController controller,
            IRepository<Schedule> repository)
        {
            view.ShowModal(controller, repository.All().ToList());
        }
    }
}