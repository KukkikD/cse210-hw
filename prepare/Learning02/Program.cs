using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create Job instances
        Job job1 = new Job();
        job1._jobTitle = "Marketing Co-ordinator";
        job1._company = "UDIS";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // Create a Resume instance
        Resume myResume = new Resume();
        myResume._name = "Amornrat Dizon";

        // Add jobs to the Resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume details
        myResume.Display();
    }
}