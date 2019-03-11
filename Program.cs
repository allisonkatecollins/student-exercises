using System;
using System.Collections.Generic;


//The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

//Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
          //Create 4, or more, exercises.
          Exercise MyFirstWebpage = new Exercise() {
            Name = "My First Webpage", 
            Language = "HTML"
          };

          Exercise FlexboxPractice = new Exercise() {
            Name = "Flexbox Practice", 
            Language = "CSS"
          };

          Exercise ArrayMethods = new Exercise() {
            Name = "Array Methods", 
            Language = "JavaScript"
          };

          Exercise CSharpClasses = new Exercise() {
            Name = "Dictionaries and Lists", 
            Language = "CSharp"
          };

          //Create 3, or more, cohorts.
          Cohort E1 = new Cohort("Evening Cohort 1");
          Cohort C29 = new Cohort("Day Cohort 29");
          Cohort C30 = new Cohort("Day Cohort 30");
         

          //Create 4, or more, students and assign them to one of the cohorts.
          
          //Create 3, or more, instructors and assign them to one of the cohorts.
          //Have each instructor assign 2 exercises to each of the students.
  
        }
    }
}
