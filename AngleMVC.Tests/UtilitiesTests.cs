using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngleWinForms;

namespace AngleMVC.Tests
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void HoursToZeroAngle_12_0()
        {
            Assert.AreEqual(0, Utilities.HoursToZeroAngle(12));
        }

        [TestMethod]
        public void HoursToZeroAngle_9_270()
        {
            Assert.AreEqual(270, Utilities.HoursToZeroAngle(9));
        }

        [TestMethod]
        public void HoursToZeroAngle_23_330()
        {
            Assert.AreEqual(330, Utilities.HoursToZeroAngle(23));
        }

        [TestMethod]
        public void HoursToZeroAngle_1_30()
        {
            Assert.AreEqual(30, Utilities.HoursToZeroAngle(1));
        }

        [TestMethod]
        public void MinutesToZeroAngle_0_0()
        {
            Assert.AreEqual(0, Utilities.MinutesToZeroAngle(0));
        }

        [TestMethod]
        public void MinutesToZeroAngle_30_180()
        {
            Assert.AreEqual(180, Utilities.MinutesToZeroAngle(30));
        }

        [TestMethod]
        public void MinutesToZeroAngle_58_348()
        {
            Assert.AreEqual(348, Utilities.MinutesToZeroAngle(58));
        }       
        
    }
}
