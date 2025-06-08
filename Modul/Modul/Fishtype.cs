namespace Modul;

public class FishType
{
    public string Name { get; set; }
    public double MinWeight { get; set; }
    public double MaxWeight { get; set; }

    public FishType(string name, double minWeight, double maxWeight)
    {
        Name = name;
        MinWeight = minWeight;
        MaxWeight = maxWeight;
    }

    public double GetRandomWeight(Random random)
    {
        return Math.Round(random.NextDouble() * (MaxWeight - MinWeight) + MinWeight, 2);
    }
}