using System;
using System.Collections.Generic;
using System.Linq;

//The learning objective of this exercise is to practice creating instances of custom types that you defined with class, establishing the relationships between them, and practicing basic data structures in C#.

//Once you have defined all of your custom types, go to your Main() method in Program.cs and implement the following logic.

namespace student_exercises
{
    class CohortCensus 
    {
    public Cohort Cohort { get; set; }
    public int Count { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
          //PART 2: After your code where you created all of your instances, add each one to the lists.
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

          List<Exercise> exercises = new List<Exercise>() {
            MyFirstWebpage,
            FlexboxPractice,
            ArrayMethods,
            CSharpOrientation
          };

          //Create 3, or more, cohorts.
          Cohort E1 = new Cohort("Evening Cohort 1");
          Cohort C29 = new Cohort("Day Cohort 29");
          Cohort C30 = new Cohort("Day Cohort 30");

          List<Cohort> cohorts = new List<Cohort>() {
            E1,
            C29,
            C30
          };
         
          //Create 4, or more, students and assign them to one of the cohorts.
          Student mary = new Student("Mary", "Remo", "@MaryRemo", C29);
          C29.StudentList.Add(mary); 

          Student brittany = new Student("Brittany", "Ramos-Janeway", "@BrittanyRJ", C29);
          C29.StudentList.Add(brittany); 

          Student enrique = new Student("Enrique", "Iglesias", "@Enrique", E1);
          E1.StudentList.Add(enrique); 

          Student samuel = new Student("Samuel L.", "Jackson", "@SammyJ", C30);
          C30.StudentList.Add(samuel);

          Student gary = new Student("Gary", "Busey", "@gbusey", E1);

          List<Student> students = new List<Student>() {
            mary,
            brittany,
            enrique,
            samuel,
            gary
          };

          //Create 3, or more, instructors and assign them to one of the cohorts.
          Instructor andy = new Instructor("Andy", "Collins", "@AndyCollins", C29);
          C29.InstructorList.Add(andy); 

          Instructor celine = new Instructor("Celine", "Dion", "@ItsCeline", E1);
          E1.InstructorList.Add(celine); 

          Instructor jisie = new Instructor("Jisie", "David", "@Jisie", C30);
          C30.InstructorList.Add(jisie); 

          List<Instructor> instructors = new List<Instructor>() {
            andy,
            celine,
            jisie
          };

          //List exercises for the JavaScript language by using the Where() LINQ method.
          List<Exercise> JSExercises = (from exercise in exercises
          where exercise.Language == "JavaScript"
          select exercise).ToList();

          Console.WriteLine("JavaScript Exercises:");
          foreach (Exercise exercise in JSExercises) {
            Console.WriteLine(exercise.Name);
          }    

          //List students in a particular cohort by using the Where() LINQ method.
          List<Student> C29Students = (from student in students
          where student.Cohort == C29
          select student).ToList(); 

          Console.WriteLine("Cohort 29 students:");
          foreach (Student s in C29Students) {
            Console.WriteLine(s.FirstName);
          } 

          //List instructors in a particular cohort by using the Where() LINQ method.
          List<Instructor> E1Instructors = (from instructor in instructors
          where instructor.Cohort == E1
          select instructor).ToList();  

          Console.WriteLine("Evening Cohort 1 instructors:");
          foreach (Instructor i in E1Instructors) {
            Console.WriteLine(i.FirstName);
          }   

          //Sort the students by their last name.
          List<Student> StudentsByLastName = (from student in students
          orderby student.LastName
          select student).ToList();

          Console.WriteLine("Students by last name:");
          foreach (Student s in StudentsByLastName) {
            Console.WriteLine(s.LastName);
          }

          //Display any students that aren't working on any exercises.
          //(Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
          mary.ExerciseList.Add(MyFirstWebpage);
          brittany.ExerciseList.Add(CSharpOrientation);
          enrique.ExerciseList.Add(FlexboxPractice);
          samuel.ExerciseList.Add(ArrayMethods);
          
          List<Student> StudentsWithFreeTime = (from student in students
          where student.ExerciseList.Count() == 0
          select student).ToList();

          Console.WriteLine("Students not working on any exercises:");
          foreach (Student s in StudentsWithFreeTime) {
            Console.WriteLine(s.FirstName);
          }

          //Which student is working on the most exercises?
          //Make sure one of your students has more exercises than the others.
          mary.ExerciseList.Add(CSharpOrientation);

          List<Student> studentExerciseList = (from student in students
          orderby student.ExerciseList.Count descending
          select student).ToList();

          Student busiestStudent = studentExerciseList.First();
          Console.WriteLine("Student working on the most exercises:");
          Console.WriteLine(busiestStudent.FirstName);

          //How many students in each cohort?
          //CohortCensus defined at top of file
          List<CohortCensus> CohortCount = (from student in students
          group student.FirstName by student.Cohort into cohortCensus
          select new CohortCensus {
            Cohort = cohortCensus.Key,
            Count = cohortCensus.Count()
            }).ToList();
          }

          //-------------STUDENT EXERCISES 1------------------------------
          //Have each instructor assign 2 exercises to each of the students.
          //do this by assigning to entire cohort; logic defined in Instructor.cs
          /* andy.Assign(C29, MyFirstWebpage);
          andy.Assign(C29, CSharpOrientation);
          celine.Assign(E1, MyFirstWebpage);
          celine.Assign(E1, FlexboxPractice);
          jisie.Assign(C30, FlexboxPractice);
          jisie.Assign(C30, ArrayMethods); */

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
           /* List<Student> AllStudents = new List<Student>() {
             mary, brittany, enrique, samuel
           }; */
            
           //<<CHALLENGE INSTRUCTIONS>> Create a list of exercises. Add all of the exercise instances to it.
           // ^ list already exists in Student.cs and code runs properly without adding another

           //Generate a report that displays which students are working on which exercises.
           /* foreach (Student student in AllStudents) {
             List<string> ExercisesInProgress = new List<string>();

            //ExerciseList was defined in Student.cs, which uses the class 'Exercise'
             foreach (Exercise exercise in student.ExerciseList) {
               ExercisesInProgress.Add(exercise.Name);
             }; */

            //String.Join method: concatenates the elements of a specified array using the specified separator between each element
             //Console.WriteLine($"{student.FirstName} {student.LastName} is working on {String.Join(", ", ExercisesInProgress)}");

             //----OUTPUT------
              /* 
              Mary Remo is working on My First Webpage, Dictionaries and Lists
              Brittany Ramos-Janeway is working on My First Webpage, Dictionaries and Lists
              Enrique Iglesias is working on My First Webpage, Flexbox Practice
              Samuel L. Jackson is working on Flexbox Practice, Array Methods 
              */
    }
}
