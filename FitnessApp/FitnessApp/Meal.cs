namespace FitnessApp
{
    // Represents one meal from the nutrition plan
    internal class Meal
    {
        public string Name { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }

        // Calories: (protein + carbs) * 4 + fat * 9
        public int CalculateCalories()
        {
            return (Protein + Carbs) * 4 + Fat * 9;
        }
    }
}
