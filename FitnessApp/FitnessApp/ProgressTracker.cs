using System;
using System.Collections.Generic;
using System.Linq;

namespace FitnessApp
{
    
    internal class ProgressTracker
    {
       
        public List<double> WeightHistory { get; private set; }

        public ProgressTracker()
        {
            WeightHistory = new List<double>();
        }

        
        public void AddEntry(double weight)
        {
            if (weight <= 0)
            {
                Console.WriteLine(" Weight must be a positive number.");
                return;
            }

            WeightHistory.Add(weight);
            Console.WriteLine($" Added {weight} kg to progress tracker.");
        }

       
        public double GetWeightDifference()
        {
            if (WeightHistory.Count < 2)
            {
                Console.WriteLine(" Not enough data to calculate difference.");
                return 0;
            }

            return WeightHistory.Last() - WeightHistory.First();
        }

       
        public void PrintProgress()
        {
            if (WeightHistory.Count == 0)
            {
                Console.WriteLine(" No weight entries available.");
                return;
            }

            Console.WriteLine(" Progress entries:");
            foreach (var w in WeightHistory)
            {
                Console.WriteLine($"- {w} kg");
            }

            Console.WriteLine($" Total change: {GetWeightDifference()} kg");
        }
    }
}
