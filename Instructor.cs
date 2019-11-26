using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Instructor : NSSMember
    {
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