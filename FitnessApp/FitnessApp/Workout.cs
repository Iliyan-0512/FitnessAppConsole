using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessApp
{
    // A set of exercises the user performs in one day
    internal class Workout
    {
        public string Name { get; set; }
        public List<Exercise> Exercises { get; set; }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }

        // Add an exercise
        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        // Total volume: sum of all (reps × weight)
        public double TotalVolume()
        {
            return Exercises.Sum(e => e.Repetitions * e.WeightKg);
        }
    }

    
}
