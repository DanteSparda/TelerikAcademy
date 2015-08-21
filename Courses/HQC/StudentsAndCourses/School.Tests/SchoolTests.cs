namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SchoolShouldThrowWhenUniqueStudentNumberIsUnder10000()
        {
            School.UniqueNumber = 9999;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SchoolShouldThrowWhenUniqueStudentNumberIsOver99999()
        {
            School.UniqueNumber = 100000;
        }

        [TestMethod]
        public void SchoolShouldSetCorrectUniqueStudentNumberAndReturnIt()
        {
            School.UniqueNumber = 12343;
            Assert.AreEqual(12343, School.UniqueNumber, "Unique number should be set correctly if valid");
        } 
    }
}
