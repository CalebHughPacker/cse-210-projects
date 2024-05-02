using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 1999;
        job1._endYear = 2006;

        Job job2 = new Job();
        job2._jobTitle = "Front-End Developer/Back-End Developer/Project Lead/Custodial Staff";
        job2._company = "Joe's Tech Startup";
        job2._startYear = 2006;
        job2._endYear = 2007;

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Jimmy Johnson";

        resume.Display();
    }
}