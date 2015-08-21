namespace School.Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowCreatedWithoutName()
        {
            var student = new Student(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowCreatedWithNull()
        {
            var student = new Student(null);
        }

        [TestMethod]
        public void StudentShouldSaveHisNameCorrectly()
        {
            var studentName = "Ivancho";
            var student = new Student(studentName);
            Assert.AreEqual(studentName, student.Name, "Name of studen must be as innitial set");
        }

        [TestMethod]
        public void StudentUniqueNumberShouldBeInCorrectRange()
        {
            var student = new Student("Goshko");
            Assert.IsTrue(student.UniqueNumber >= 10000 && student.UniqueNumber <= 99999, "Student unique number must be in range 10000-99999");
        }

        [TestMethod]
        public void StudentShouldBeAbbleToSignACourse()
        {
            var student = new Student("Goshko");
            var course = new Course("Goshko's course");
            student.SignCourse(course);
            Assert.IsTrue(student.Courses.Contains(course));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowIfCourseToAddIsNull()
        {
            var student = new Student("Goshko");
            student.SignCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowIfTheCourseTriesToBeAddedMoreThanOnce()
        {
            var student = new Student("Goshko");
            var course = new Course("Goshko's course");
            student.SignCourse(course);
            student.SignCourse(course);
        }

        [TestMethod]
        public void StudentShouldBeAbleToAddAlotOfCourses()
        {
            var student = new Student("Goshko");
            for (int i = 0; i < 250; i++)
            {
                var course = new Course("Name: " + i);
                student.SignCourse(course);
            }
        }

        [TestMethod]
        public void StudentShouldBeAbleToCorrectlyRemoveCourse()
        {
            var student = new Student("Goshko");
            var course = new Course("Goshko's course");
            student.SignCourse(course);
            student.UnsignCourse(course);
            Assert.IsFalse(student.Courses.Contains(course));
        }

        [TestMethod]
        public void StudentShouldBeAbleToCorrectlyRemoveALotOfCourses()
        {
            var student = new Student("Goshko");
            var listOFCourses = new List<Course>();
            for (int i = 0; i < 250; i++)
            {
                var course = new Course("Name: " + i);
                student.SignCourse(course);
                listOFCourses.Add(course);
            }

            foreach (var course in listOFCourses)
            {
                student.UnsignCourse(course);
            }

            Assert.IsTrue(student.Courses.Count == 0, "All courses should be removed");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowWhileRemovingANullCourse()
        {
            var student = new Student("Goshko");
            student.UnsignCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowWhileTryingToRemoveCourseThatHasNotBeenSigned()
        {
            var student = new Student("Goshko");
            var course = new Course("Ivanchov's course");
            student.UnsignCourse(course);
        }
    }
}
