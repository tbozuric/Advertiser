using System;
using DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void Add_Service()
        {
            var address = new Address("Zagreb", "Primorska ulica", 10451);
            var employee = new Employee("12345678901", "Mirko", "Medvedov");
            var videoWall = new VideoWall(120, 180, address);

            var day = DateTime.Now;
            var startTime = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var endTime = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);


            var service = new Service(employee, startTime, endTime, FailureType.ELECTRICAL, videoWall);

            Assert.AreEqual(service.FailureType, FailureType.ELECTRICAL);
            Assert.AreEqual(service.ServiceEnd, endTime);
            Assert.AreEqual(service.ServiceStart, startTime);
            Assert.AreEqual(service.VideoWall.Location, videoWall.Location);
            Assert.AreEqual(service.VideoWall.Status, videoWall.Status);
            Assert.AreEqual(service.ServicedBy, employee);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidValueException))]
        public void Service_Without_VideoWall_Throw()
        {
            var employee = new Employee("12345678901", "Mirko", "Medvedov");
            var day = DateTime.Now;
            var startTime = new DateTime(day.Year, day.Month, day.Day, 8, 0, 0);
            var endTime = new DateTime(day.Year, day.Month, day.Day, 16, 0, 0);
            var service = new Service(employee, startTime, endTime, FailureType.ELECTRICAL, null);
        }
    }
}