using Microsoft.VisualStudio.TestTools.UnitTesting;
using OddsSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace OddsSystem.Test.SportEventControllerTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void Throw_ArgumentNullException_When_SportEventService_Is_Null()
        {
            Assert.ThrowsException<ArgumentNullException>(
                () => new SportEventController(null)
                );
        }
    }
}
