using System;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidValueException))]
        public void Name_Null_Throw()
        {
            var day = DateTime.Now;
            var schedule = new Schedule(null, day, day);
        }

        [TestMethod]
        [ExpectedException(typeof(DateTimeRuleException))]
        public void Smaller_End_Time_Than_Start_Time_Should_Throw()
        {
            var day = DateTime.Now;
            var startTime = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);
            var endTime = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var schedule = new Schedule(@"oglasi", startTime, endTime);
        }


        [TestMethod]
        public void Add_Entry()
        {
            var day = DateTime.Now;
            var startTimeSchedule = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var endTimeSchedule = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);
            var schedule = new Schedule(@"oglasi", startTimeSchedule, endTimeSchedule);

            var startTimeAd = new DateTime(day.Year, day.Month, day.Day, 8, 15, 0);
            var endTimeAd = new DateTime(day.Year, day.Month, day.Day, 8, 45, 0);


            var entry = new ScheduleEntry(new Ad("ProSport pice", "Podize performanse"), startTimeAd, endTimeAd);
            schedule.ScheduleEntries.Add(entry);
            Assert.IsTrue(schedule.ScheduleEntries.Count == 1);
        }

        [TestMethod]
        [ExpectedException(typeof(DateTimeRuleException))]
        public void Add_Bad_Entry()
        {
            var day = DateTime.Now;
            var startTimeSchedule = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var endTimeSchedule = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);

            var schedule = new Schedule(@"oglasi", startTimeSchedule, endTimeSchedule);
            var startTimeAd = new DateTime(day.Year, day.Month, day.Day, 17, 15, 0);
            var endTimeAd = new DateTime(day.Year, day.Month, day.Day, 8, 45, 0);
            var entry = new ScheduleEntry(new Ad("ProSporte", "Performanse"), startTimeAd, endTimeAd);

            schedule.ScheduleEntries.Add(entry);
        }
    }
}