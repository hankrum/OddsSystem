using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddsSystem.Data.Model;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using OddsSystem.Services.Data.Contracts;
using Moq;
using OddsSystem.Controllers;

namespace OddsSystem.Test.SportEventControllerTests
{
    [TestClass]
    public class Get_Should
    {
        [TestMethod]
        public void Return_Correct_Result_When_Invoked()
        {
            //Arrange
            var testDate = new DateTime(2019, 1, 1);
            var sportEventsCollection = new SportEvent[]
            {
                new SportEvent
                {
                    EventName = "Test1"
                },
                new SportEvent
                {
                    EventName = "Test2"
                }
            };
            var expectedResult = new JsonResult(sportEventsCollection);
            var sportEventServiceMock = new Mock<ISportEventService>();
            sportEventServiceMock.Setup(s => s.All()).Returns(sportEventsCollection);
            var sut = new SportEventController(sportEventServiceMock.Object);
            //Act
            var result = sut.Get() as JsonResult;
            //Assert
            Assert.AreEqual(expectedResult.Value, result.Value);
        }
    }
}
