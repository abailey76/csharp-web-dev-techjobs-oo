using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job01 = new Job();
            Job test_job02 = new Job();
            
            //testing that job object id's are not equal
            Assert.IsFalse(test_job01 == test_job02);

            //testing that job id's are incremented by 1
            Assert.IsTrue(test_job02.Id - test_job01.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product Tester", new Employer("Spacely Sprockets"), new Location("Jupiter"), new PositionType("Quality Assurance"), new CoreCompetency("Tenacity"));
            Assert.AreEqual("Product Tester", test_job3.Name);
            Assert.AreEqual("Spacely Sprockets", test_job3.EmployerName.Value);
            Assert.AreEqual("Jupiter", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality Assurance", test_job3.JobType.Value);
            Assert.AreEqual("Tenacity", test_job3.JobCoreCompetency.Value);
        }

        [TestMethod]

        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("Instructor", new Employer("LaunchCode"), new Location("Saint Louis"), new PositionType("TA"), new CoreCompetency("Patience"));
            Job test_job5 = new Job("Instructor", new Employer("LaunchCode"), new Location("Saint Louis"), new PositionType("TA"), new CoreCompetency("Patience"));
            bool testJobEquality = test_job4.Id.Equals(test_job5);
            Assert.AreEqual(false, testJobEquality);
        }

        [TestMethod]

        public void TestToString()
        {
            Job test_job6 = new Job("Domestic Attendant", new Employer("Jetson Family"), new Location("Outer Space"), new PositionType("Facility Maintenance"), new CoreCompetency("Robot"));

        }
    }
}