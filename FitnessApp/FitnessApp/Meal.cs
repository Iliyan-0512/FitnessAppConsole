using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FitnessApp
{
    
    //What it is: one meal from the regimen - e.g. "Breakfast "Calculation of calories: (protein + carbs) × 4 + fat × 9
    internal class Meal
        {
            // Meal name (for example: "Breakfast", "Lunch")
            public string Name { get; set; }

            // Grams of protein
            public double Protein { get; set; }

            public double Carbs { get; set; }

            public double Fat { get; set; }

            public Meal(string name, double protein, double carbs, double fat)
            {
                Name = name;
                Protein = protein;
                Carbs = carbs;
                Fat = fat;
            }

            public double CalculateCalories()
            {
                return (Protein + Carbs) * 4 + Fat * 9;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Meal: {Name}");
                Console.WriteLine($"Protein: {Protein}g, Carbs: {Carbs}g, Fat: {Fat}g");
                Console.WriteLine($"Total Calories: {CalculateCalories()} kcal");
            }
        }
    }
