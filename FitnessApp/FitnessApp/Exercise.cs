internal class Exercise
{
    public string Name { get; set; }
    public int Repetitions { get; set; }
    public double WeightKg { get; set; }

    public Exercise(string name, int reps, double weight)
    {
        Name = name;
        Repetitions = reps;
        WeightKg = weight;
    }
}