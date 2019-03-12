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

          Exercise CSharpOrientation = new Exercise() {
            Name = "Dictionaries and Lists", 
            Language = "CSharp"
          };

          //Create 3, or more, cohorts.
          Cohort E1 = new Cohort("Evening Cohort 1");
          Cohort C29 = new Cohort("Day Cohort 29");
          Cohort C30 = new Cohort("Day Cohort 30");
         

          //Create 4, or more, students and assign them to one of the cohorts.
          Student mary = new Student("Mary", "Remo", "@MaryRemo", C29);
          C29.StudentList.Add(mary); 

          Student brittany = new Student("Brittany", "Ramos-Janeway", "@BrittanyRJ", C29);
          C29.StudentList.Add(brittany); 

          Student enrique = new Student("Enrique", "Iglesias", "@Enrique", E1);
          E1.StudentList.Add(enrique); 

          Student samuel = new Student("Samuel L.", "Jackson", "@SammyJ", C30);
          C30.StudentList.Add(samuel);

          //Create 3, or more, instructors and assign them to one of the cohorts.
          Instructor andy = new Instructor("Andy", "Collins", "@AndyCollins", C29);
          C29.InstructorList.Add(andy); 

          Instructor celine = new Instructor("Celine", "Dion", "@ItsCeline", E1);
          E1.InstructorList.Add(celine); 

          Instructor jisie = new Instructor("Jisie", "David", "@Jisie", C30);
          C30.InstructorList.Add(jisie); 

          //Have each instructor assign 2 exercises to each of the students.
          //do this by assigning to entire cohort; logic defined in Instructor.cs
          andy.Assign(C29, MyFirstWebpage);
          andy.Assign(C29, CSharpOrientation);
          celine.Assign(E1, MyFirstWebpage);
          celine.Assign(E1, FlexboxPractice);
          jisie.Assign(C30, FlexboxPractice);
          jisie.Assign(C30, ArrayMethods);

          /* -------OUTPUT--------
              Andy assigned My First Webpage to Mary
              Andy assigned My First Webpage to Brittany
              Andy assigned Dictionaries and Lists to Mary
              Andy assigned Dictionaries and Lists to Brittany
              Celine assigned My First Webpage to Enrique
              Celine assigned Flexbox Practice to Enrique
              Jisie assigned Flexbox Practice to Samuel L.
              Jisie assigned Array Methods to Samuel L.
           */

           //Create a list of students. Add all of the student instances to it.
           //different from StudentList in that StudentList is relative to each cohort
           List<Student> AllStudents = new List<Student>() {
             mary, brittany, enrique, samuel
           };
            
           //<<CHALLENGE INSTRUCTIONS>> Create a list of exercises. Add all of the exercise instances to it.
           // ^ list already exists in Student.cs and code runs properly without adding another

           //Generate a report that displays which students are working on which exercises.
           foreach (Student student in AllStudents) {
             List<string> ExercisesInProgress = new List<string>();

            //ExerciseList was defined in Student.cs, which uses the class 'Exercise'
             foreach (Exercise exercise in student.ExerciseList) {
               ExercisesInProgress.Add(exercise.Name);
             };

            //String.Join method: concatenates the elements of a specified array using the specified separator between each element
             Console.WriteLine($"{student.FirstName} {student.LastName} is working on {String.Join(", ", ExercisesInProgress)}");
           }
        }
    }
}
