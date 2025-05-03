using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    //What it is: a set of exercises that the user performs in one day.
    //Add an exercise
    //Total workout volume(sum of all repetitions × weight)
    internal class Workout
    
        {
          // List of exercises in the workout
            private List<Exercise> exercises;

            // Constructor
            public Workout()
            {
                exercises = new List<Exercise>();
            }

            public void AddExercise(Exercise exercise)
            {
                exercises.Add(exercise);
            }

            // Method for calculating total training volume (sum of sets × reps × weight)
            public double CalculateTotalVolume()
            {
                double totalVolume = 0;

                foreach (var exercise in exercises)
                {
                    totalVolume += exercise.CalculateTrainingVolume();
                }

                return totalVolume;
            }

            public void ShowWorkout()
            {
                Console.WriteLine("Workout of the Day:");

                foreach (var exercise in exercises)
                {
                    exercise.ShowInfo();
                    Console.WriteLine();
                }

                Console.WriteLine($"Total Workout Volume: {CalculateTotalVolume()} kg");
            }
        }
}
