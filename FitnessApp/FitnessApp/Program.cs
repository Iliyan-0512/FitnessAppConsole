using System;
using System.Collections.Generic;

namespace FitnessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the FitnessApp!");

            Console.Write("Enter gym name: ");
            string gymName = Console.ReadLine();
            Gym gym = new Gym(gymName);

            Console.WriteLine(" Create a Trainer ");
            Trainer trainer = new Trainer();
            Console.Write("Name: ");
            trainer.Name = Console.ReadLine();
            Console.Write("Age: ");
            trainer.Age = int.Parse(Console.ReadLine());
            Console.Write("Gender (Male/Female/PreferNotToSay): ");
            trainer.Gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            gym.AddTrainer(trainer);

            Console.WriteLine(" Create a User ");
            User user = new User();
            Console.Write("Name: ");
            user.Name = Console.ReadLine();
            Console.Write("Age: ");
            user.Age = int.Parse(Console.ReadLine());
            Console.Write("Gender (Male/Female/PreferNotToSay): ");
            user.Gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Height (meters): ");
            user.HeightInMeters = double.Parse(Console.ReadLine());
            Console.Write("Weight (kg): ");
            user.WeightInKg = double.Parse(Console.ReadLine());
            gym.AddUser(user);

            bool running = true;

            while (running)
            {
                Console.WriteLine("FITNESS MENU ");
                Console.WriteLine("1. Calculate BMI");
                Console.WriteLine("2. Assign workout to user");
                Console.WriteLine("3. View weekly workout schedule");
                Console.WriteLine("4. Add weight entry (progress)");
                Console.WriteLine("5. Show progress");
                Console.WriteLine("6. Show gym statistics");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Your BMI is: {user.BMI():F2}");
                        break;

                    case "2":
                        Console.Write("Workout name: ");
                        string workoutName = Console.ReadLine();
                        Workout workout = new Workout { Name = workoutName };

                        Console.Write("How many exercises to add? ");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"Exercise {i + 1} name: ");
                            string exName = Console.ReadLine();
                            Console.Write("Repetitions: ");
                            int reps = int.Parse(Console.ReadLine());
                            Console.Write("Weight (kg): ");
                            double weight = double.Parse(Console.ReadLine());

                            workout.AddExercise(new Exercise(exName, reps, weight));
                        }

                        Console.Write("Day of week (e.g. Monday): ");
                        DayOfWeek day = Enum.Parse<DayOfWeek>(Console.ReadLine(), true);
                        trainer.AssignWorkout(user, workout, day);
                        break;

                    case "3":
                        user.ViewWeeklyProgram();
                        break;

                    case "4":
                        Console.Write("Enter current weight (kg): ");
                        if (double.TryParse(Console.ReadLine(), out double newWeight))
                        {
                            user.ProgressTracker.AddEntry(newWeight);
                        }
                        break;

                    case "5":
                        user.MonitorProgress();
                        break;

                    case "6":
                        gym.PrintStatistics();
                        break;

                    case "7":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
