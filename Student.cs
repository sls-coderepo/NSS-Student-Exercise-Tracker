using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Student()
        {
            Exercises = new List<Exercise>();
        }

    }
}