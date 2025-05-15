using System;
using System.Collections.Generic;

namespace FitnessApp
{
    // A gym employee who assigns workouts to users
    internal class Trainer : Person
    {
        public List<User> Clients { get; set; } = new List<User>();

        // Assign workout to a user
        public void AssignWorkout(User user, Workout workout, DayOfWeek day)
        {
            user.Schedule.SetWorkout(day, workout);
            Console.WriteLine($"Assigned {workout.Name} to {user.Name} on {day}.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Trainer: {Name}, Age: {Age}, Clients: {Clients.Count}");
        }
    }
}
