using System;
using System.Collections.Generic;

namespace FitnessApp
{
    internal class Schedule
    {
        public Dictionary<DayOfWeek, Workout> WeeklyWorkouts { get; set; }

        public Schedule()
        {
            WeeklyWorkouts = new Dictionary<DayOfWeek, Workout>();
        }

        public void SetWorkout(DayOfWeek day, Workout workout)
        {
            WeeklyWorkouts[day] = workout;
        }
    }
}

//    What it is: weekly workout plan(e.g.Monday - back, Tuesday - legs)
//Setting a workout for the day

//Derive a plan for the whole week
