using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "software engineer";
        job1._company = "Microsoft";
        job1._startDate = 2020;
        job1._endDate = 2023;


        Job job2 = new Job();
        job2._jobTitle = "web developer";
        job2._company = "Apple";
        job2._startDate = 2018;
        job2._endDate = 2020;

        Resume myResume = new Resume();
        myResume._namePerson = "Andrew Olson";
        myResume._newJob.Add(job1);
        myResume._newJob.Add(job2);

        myResume.Display();
    }
}