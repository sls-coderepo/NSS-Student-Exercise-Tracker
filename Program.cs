using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //List Of Exercises
            List<Exercise> exercises = new List<Exercise>();

            Exercise planetAndSpace = new Exercise()
            {
                Name = "Planet and Spaceships",
                Language = "C#"
            };
            Exercise randomNumbers = new Exercise()
            {
                Name = "Random Numbers",
                Language = "Java"
            };
            Exercise listOfDictionaries = new Exercise()
            {
                Name = "List of Dictionaries about Words",
                Language = "Python"
            };
            Exercise englishIdioms = new Exercise()
            {
                Name = "English Idioms",
                Language = "Ruby on Rails"
            };

            exercises.Add(planetAndSpace);
            exercises.Add(randomNumbers);
            exercises.Add(listOfDictionaries);
            exercises.Add(englishIdioms);

            // Creating Cohort objects
            Cohort cohort35 = new Cohort("Cohort 35");
            Cohort cohort36 = new Cohort("Cohort 36");
            Cohort cohort37 = new Cohort("Cohort 37");

            //List of students
            List<Student> students = new List<Student>();

            Student student0 = new Student()
            {
                FirstName = "Shirish",
                LastName = "Shrestha",
                SlackHandle = "Shirish Shrestha",

            };
            Student student1 = new Student()
            {
                FirstName = "Shrijan",
                LastName = "Shrestha",
                SlackHandle = "ShrijanS ",

            };
            Student student2 = new Student()
            {
                FirstName = "Mrinav",
                LastName = "Shrestha",
                SlackHandle = "Mrinav.Stha ",

            };
            students.Add(student0);
            students.Add(student1);
            students.Add(student2);

            // Students Adding to Cohort

            cohort35.Students.Add(student0);
            cohort35.Students.Add(student1);
            cohort36.Students.Add(student2);

            // Creating Instructors List
            List<Instructor> instructors = new List<Instructor>();

            Instructor cSharpInstructor = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "Adam"
            };
            Instructor uIUXInstructor = new Instructor()
            {
                FirstName = "Brenda",
                LastName = "Long",
                SlackHandle = "Brenda"
            };
            Instructor pythonInstructor = new Instructor()
            {
                FirstName = "Mo",
                LastName = "Mo",
                SlackHandle = "Mo"
            };
            instructors.Add(cSharpInstructor);
            instructors.Add(uIUXInstructor);
            instructors.Add(pythonInstructor);

            // Assigning Instructor to Cohort
            cohort35.Instructors.Add(cSharpInstructor);
            cohort36.Instructors.Add(uIUXInstructor);

            //Assigning exercises to students
            cSharpInstructor.assignExercise(student0, planetAndSpace);
            cSharpInstructor.assignExercise(student0, randomNumbers);
            uIUXInstructor.assignExercise(student1, planetAndSpace);
            uIUXInstructor.assignExercise(student1, randomNumbers);

            foreach (Student student in students)
            {
                Console.WriteLine("===================================================");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}");
                }

            }

        }
    }
}