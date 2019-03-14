using System;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class VideoWallTests
    {
        [TestMethod]
        [ExpectedException(typeof(AddressNullReferenceException))]
        public void Location_Null_Throw()
        {
            var videoWall = new VideoWall(120, 180, null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException))]
        public void Bad_Width_Throw()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var videoWall = new VideoWall(-120, 180, address);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException))]
        public void Bad_Height_Throw()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var videoWall = new VideoWall(120, -180, address);
        }

        [TestMethod]
        public void Add_Servicer()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var employee = new Employee("12345678901", "Mirko", "Medvedov");
            var videoWall = new VideoWall(120, 180, address);
            videoWall.Servicers.Add(employee);
            Assert.AreEqual(videoWall.Servicers.Count, 1);
            Assert.AreEqual(videoWall.Servicers[0].Name, "Mirko");
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidPersonDataException))]
        public void Add_Servicer_With_Wrong_Data_Throw()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var employee = new Employee("aaaa", "Mirko", "Medvedov");
            var videoWall = new VideoWall(120, 180, address);
            videoWall.Servicers.Add(employee);
        }

        [TestMethod]
        public void Add_Schedule()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var day = DateTime.Now;
            var startTime = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var endTime = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);
            var schedule = new Schedule(@"oglasi", startTime, endTime);

            var videoWall = new VideoWall(120, 180, address);
            videoWall.Schedules.Add(schedule);

            Assert.AreEqual(videoWall.Schedules.Count, 1);
            Assert.AreEqual(videoWall.Schedules[0].Name, "oglasi");
        }
    }
}