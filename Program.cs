using System;
using System.Collections.Generic;
using System.Linq;

namespace NSSExerciseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //List Of Exercises

            Exercise overlyExcited = new Exercise()
            {
                Name = "Overly Excited",
                Language = "JavaScript"
            };
            Exercise solarSystem = new Exercise()
            {
                Name = "Solar System",
                Language = "JavaScript"
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
            List<Exercise> exercises = new List<Exercise>()
            {
                overlyExcited,
                solarSystem,
                listOfDictionaries,
                englishIdioms
            };

            // Creating Cohort objects
            Cohort cohort35 = new Cohort("Cohort 35");
            Cohort cohort36 = new Cohort("Cohort 36");
            Cohort cohort37 = new Cohort("Cohort 37");
            List<Cohort> cohorts = new List<Cohort>()
            {
                cohort35,
                cohort36,
                cohort37
            };

            //List of students

            Student student0 = new Student()
            {
                FirstName = "Shirish",
                LastName = "Shrestha",
                SlackHandle = "Shirish Shrestha",

            };
            Student student1 = new Student()
            {
                FirstName = "Shrijan",
                LastName = "Pradhan",
                SlackHandle = "ShrijanS ",

            };
            Student student2 = new Student()
            {
                FirstName = "Mrinav",
                LastName = "Joshi",
                SlackHandle = "Mrinav.Stha ",

            };

            List<Student> students = new List<Student>()
            {
                student0,
                student1,
                student2
            };

            // Students Adding to Cohort

            cohort35.Students.Add(student0);
            cohort35.Students.Add(student1);
            cohort36.Students.Add(student2);

            // Creating Instructors List

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
            List<Instructor> instructors = new List<Instructor>()
            {
                cSharpInstructor,
                uIUXInstructor,
                pythonInstructor
            };

            // Assigning Instructor to Cohort
            cohort35.Instructors.Add(cSharpInstructor);
            cohort35.Instructors.Add(pythonInstructor);
            cohort36.Instructors.Add(uIUXInstructor);

            //Assigning exercises to students
            cSharpInstructor.assignExercise(student0, overlyExcited);
            cSharpInstructor.assignExercise(student0, solarSystem);
            pythonInstructor.assignExercise(student0, listOfDictionaries);
            uIUXInstructor.assignExercise(student1, overlyExcited);
            uIUXInstructor.assignExercise(student1, solarSystem);

            foreach (Student student in students)
            {
                Console.WriteLine("===================================================");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is working on {exercise.Name}");
                }

            }

            Console.WriteLine("===================================================");
            //List of exercise in Javascript
            var listOfExercises = exercises.Where(e => e.Language == "JavaScript").ToList();
            Console.WriteLine($"List of Javascript exercises--");
            foreach (var exercise in listOfExercises)
            {
                Console.WriteLine(exercise.Name);
            }

            Console.WriteLine("===================================================");

            //List students in cohort
            var listOfStudents = cohorts.Where(c => c.Name == "Cohort 35").SelectMany(c => c.Students).Distinct();
            Console.WriteLine($"Students in cohort-35");
            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("===================================================");
            //List of Instructors in cohort

            var listOfInstructors = cohorts.Where(c => c.Name == "Cohort 35").SelectMany(c => c.Instructors).Distinct();
            Console.WriteLine($"Instructors assigned for cohort-35");
            foreach (var instructor in listOfInstructors)
            {
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
            }

            Console.WriteLine("===================================================");
            //Sort the students by their last name.

            var sortedStudents = students.OrderBy(s => s.LastName);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.LastName);
            }

            Console.WriteLine("===================================================");
            //Display any students that aren't working on any exercises
            var studentWithNoExercises = students.Where(s => s.Exercises.Count() == 0).ToList();
            foreach (var student in studentWithNoExercises)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine("===================================================");
            //Which student is working on the most exercises? 
            var studentWithMoreExercise = students.Select(s => new
            {
                firstName = s.FirstName,
                numberOfExercises = s.Exercises.Count()
            })
                .OrderByDescending(s => s.numberOfExercises)
                .FirstOrDefault();
            Console.WriteLine($"{studentWithMoreExercise.firstName} has {studentWithMoreExercise.numberOfExercises} exercises");

            Console.WriteLine("===================================================");
            //How many students in each cohort?
            var numOfStudents = cohorts.Select(c => new
            {
                cohortName = c.Name,
                numberOfStudentsInCohort = c.Students.Count()
            }).ToList();
            foreach (var student in numOfStudents)
            {
                Console.WriteLine($"{student.cohortName} has {student.numberOfStudentsInCohort} students!");
            }

            var numOfStudents1 = cohorts.GroupBy(c => c.Name)
                                        .OrderByDescending(c => c.Count())
                                        .First();


        }
    }
}