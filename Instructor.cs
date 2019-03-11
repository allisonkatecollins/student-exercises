using System;
using System.Collections.Generic;
namespace student_exercises
{
    public class Instructor
    {
      //first name, last name, slack handle, cohort 
      public string FirstName {get; set;}
      public string LastName {get; set;}
      public string SlackHandle {get; set;}

      //same method of cohort assignment as in Student.cs
      public Cohort Cohort {get; set;}

      public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort) {
        FirstName = firstName;
        LastName = lastName;
        SlackHandle = slackHandle;
        Cohort = cohort;
      }

      //method to assign exercise to a student
      public void Assign(Cohort cohort, Exercise exercise) {
        //assign to every student in the cohort
        foreach (Student student in cohort.StudentList) {
          student.ExerciseList.Add(exercise);
          Console.WriteLine($"{FirstName} assigned {exercise.Name} to {student.FirstName}");
        }
      }
    }
}
