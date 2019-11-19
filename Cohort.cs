using System;
using System.Collections.Generic;

namespace NSSExerciseTracker
{
    class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Instructor> Instructors { get; set; }

        public Cohort(string cohortName)
        {
            Name = cohortName;
            Students = new List<Student>();
            Instructors = new List<Instructor>();

        }
        public Cohort()
        {
            Students = new List<Student>();
            Instructors = new List<Instructor>();

        }

    }
}