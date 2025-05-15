using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessApp
{
    // What is it: the gym itself, where all the users and trainers are located
    internal class Gym
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<Trainer> Trainers { get; set; }

        public static int TotalGyms = 0;

        public Gym(string name)
        {
            Name = name;
            Users = new List<User>();
            Trainers = new List<Trainer>();
            TotalGyms++;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            Console.WriteLine($"User {user.Name} added to gym {Name}.");
        }

        public void AddTrainer(Trainer trainer)
        {
            Trainers.Add(trainer);
            Console.WriteLine($"Trainer {trainer.Name} added to gym {Name}.");
        }

        public void RemoveUser(User user)
        {
            Users.Remove(user);
            Console.WriteLine($"User {user.Name} removed from gym {Name}.");
        }

        public void RemoveTrainer(Trainer trainer)
        {
            Trainers.Remove(trainer);
            Console.WriteLine($"Trainer {trainer.Name} removed from gym {Name}.");
        }

        public void PrintStatistics()
        {
            Console.WriteLine($"Gym: {Name}");
            Console.WriteLine($"Total users: {Users.Count}");
            Console.WriteLine($"Total trainers: {Trainers.Count}");
        }
    }
}
