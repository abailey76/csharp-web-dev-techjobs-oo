using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {

            return obj is Job job &&
                   Id == job.Id;

        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override int GetHashCode()
        {

            return HashCode.Combine(Id);

        }

        public override string ToString()
        {
            if (Name == null && EmployerName == null && EmployerLocation == null && JobType == null && JobCoreCompetency == null)

            {
                return "OOPS! This job does not seem to exist.";

            }
            if (Name == null || Name == "")
            {

                Name = "Data not available";

            }
            if (EmployerName.Value == null || EmployerName.Value == "")
            {

                EmployerName.Value = "Data not available";

            }
            if (EmployerLocation.Value == null || EmployerLocation.Value == "")
            {

                EmployerLocation.Value = "Data not available";

            }
            if (JobType.Value == null || JobType.Value == "")
            {

                JobType.Value = "Data not available";

            }
            if (JobCoreCompetency.Value == null || JobCoreCompetency.Value == "")
            {

                JobCoreCompetency.Value = "Data not available";

            }

            return $"\nID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Employer: {EmployerName.Value}\n" +
                   $"Location: {EmployerLocation.Value}\n" +
                   $"Position Type: {JobType.Value}\n" +
                   $"Core Competency: {JobCoreCompetency.Value}\n";

        }
    }
}
