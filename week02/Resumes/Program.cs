using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Creating the first object "Job1" for the Job class
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Yuukay's Software Solutions";
        job1._startYear = 2026;
        job1._endYear = 2062;
        

        //Creating the second object "Job 2" for the Job class
        Job job2 = new Job();
        job2._jobTitle = "Administrative Secretary";
        job2._company = "Heritage Kidney and Medical Care";
        job2._startYear = 2023;
        job2._endYear = 2026;
        


        // Creating a new object for the Resume class 
        Resume myResume = new Resume();
        myResume._name = "Ukpai Umedike";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();  

    }
}