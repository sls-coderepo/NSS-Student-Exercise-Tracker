using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Student : NSSMember
    {
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Student()
        {
            Exercises = new List<Exercise>();
        }

    }
}