using System;

namespace FitnessApp
{
    // Who is he: a person who uses the gym - trains, has a diet, monitors his progress.
    internal class User : Person
    {
        public Schedule Schedule { get; set; } = new Schedule();
        public ProgressTracker ProgressTracker { get; set; } = new ProgressTracker();

        public double HeightInMeters { get; set; }
        public double WeightInKg { get; set; }

        // BMI calculation
        public double BMI()
        {
            if (HeightInMeters <= 0)
                return 0;

            return WeightInKg / (HeightInMeters * HeightInMeters);
        }

        // View weekly program
        public void ViewWeeklyProgram()
        {
            if (Schedule == null || Schedule.WeeklyWorkouts.Count == 0)
            {
                Console.WriteLine("No workouts scheduled.");
                return;
            }

            Console.WriteLine("Weekly Workout Schedule:");
            foreach (var entry in Schedule.WeeklyWorkouts)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value.Name}");
            }
        }

        // Monitor progress
        public void MonitorProgress()
        {
            if (ProgressTracker == null || ProgressTracker.WeightHistory.Count == 0)
            {
                Console.WriteLine("No progress recorded.");
                return;
            }

            Console.WriteLine("Progress:");
            foreach (var weight in ProgressTracker.WeightHistory)
            {
                Console.WriteLine($"- {weight} kg");
            }

            Console.WriteLine($"Weight change: {ProgressTracker.GetWeightDifference()} kg");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"User: {Name}, Age: {Age}");
        }
    }
}
