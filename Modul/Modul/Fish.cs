namespace Modul;

public class Fish
{
    public string Species { get; set; }
    public double Weight { get; set; }

    public Fish(string species, double weight)
    {
        Species = species;
        Weight = weight;
    }

    public override string ToString()
    {
        return $"{Species} ({Weight} кг)";
    }
}