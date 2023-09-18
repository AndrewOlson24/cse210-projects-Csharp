using System;
using System.ComponentModel.DataAnnotations;

public class Resume
{
    public string _namePerson;
    public List<Job> _newJob = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name:{_namePerson}");
        Console.WriteLine($"Job:");

        foreach (Job job in _newJob)
        {
            job.Display();
        }
    }



}