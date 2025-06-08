namespace Modul;

public class Fisher
{
    public string Name { get; set; }
    public int FishCount { get; set; } = 0;
    public Fish[] Catch { get; set; }

    public Fisher(string name, int maxFish)
    {
        Name = name;
        Catch = new Fish[maxFish];
    }

    public void CatchFish(Fish fish)
    {
        if (FishCount < Catch.Length)
        {
            Catch[FishCount++] = fish;
        }
    }
}