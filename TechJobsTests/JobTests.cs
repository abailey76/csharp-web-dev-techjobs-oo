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
            Job test_job3 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product Tester", test_job3.Name);
            Assert.AreEqual("ACME", test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
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
            {
                
                string outputExpected = 
                $"\nID: {test_job6.Id}\n" +
                $"Name: {test_job6.Name}\n" +
                $"Employer: {test_job6.EmployerName.Value}\n" +
                $"Location: {test_job6.EmployerLocation.Value}\n" +
                $"Position Type: {test_job6.JobType.Value}\n" +
                $"Core Competency: {test_job6.JobCoreCompetency.Value}\n";
                Assert.AreEqual(outputExpected, test_job6.ToString());
                Assert.IsTrue(outputExpected.StartsWith("\n"));
                Assert.IsTrue(outputExpected.EndsWith("\n"));
            }
        }
    }
}
