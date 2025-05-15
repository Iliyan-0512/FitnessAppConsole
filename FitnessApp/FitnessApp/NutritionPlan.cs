using System.Collections.Generic;
using System.Linq;

namespace FitnessApp
{
    // List of meals the client follows
    internal class NutritionPlan
    {
        public List<Meal> Meals { get; set; }

        public NutritionPlan()
        {
            Meals = new List<Meal>();
        }

        // Total calories for the day
        public int TotalCalories()
        {
            return Meals.Sum(m => m.CalculateCalories());
        }
    }
}
