using System;

// Code for Job class
// Responsibility of Job is to hold and dicplay personal employment information.
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Constructor invoked by the new keyword followed
    // the class name and parenthesis
    public Job()
    {

    }

    // Method for dsplaying person's full name 
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}