using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<string> Specialities { get; set; }

        public Instructor()
        {
            Specialities = new List<string>();
        }
        public void assignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }

    }
}