using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {
      //first name, last name, slack handle, cohort, current exercise collection
      public string FirstName {get; set;}
      public string LastName {get; set;}
      public string SlackHandle {get; set;}
      public List<Exercise> ExerciseList {get; set;}
      
      //type is Cohort instead of string, since it is defined in another file
      //doesn't work unless Cohort is a public class in Cohort.cs
      public Cohort Cohort {get; set;}
      public Student(string firstName, string lastName, string slackHandle, Cohort cohort) {
        FirstName = firstName;
        LastName = lastName;
        SlackHandle = slackHandle;
        Cohort = cohort;
        ExerciseList = new List<Exercise>();
      }
    }
}
