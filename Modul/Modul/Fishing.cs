namespace Modul;

public class Fishing : IBite
{
    private Fisher fisher1;
    private Fisher fisher2;
    private int durationMinutes;
    private int averageBiteInterval;
    private Random random = new Random();

    private FishType[] fishTypes = {
        new FishType("Окунь", 0.2, 1.5),
        new FishType("Щука", 1.0, 4.5),
        new FishType("Сом", 2.0, 6.0),
        new FishType("Короп", 1.0, 3.5),
        new FishType("Лящ", 0.5, 2.0)
    };

    public Fishing(Fisher f1, Fisher f2, int hours, int interval)
    {
        fisher1 = f1;
        fisher2 = f2;
        durationMinutes = hours * 60;
        averageBiteInterval = interval;
    }

    public void StartFishing()
    {
        int elapsedTime = 0;
        int biteCount = 0;

        while (elapsedTime < durationMinutes)
        {
            int randomInterval = random.Next(averageBiteInterval - 5, averageBiteInterval + 6);
            elapsedTime += randomInterval;

            if (elapsedTime > durationMinutes) break;

            biteCount++;

            bool firstFisherPulls = random.Next(2) == 0;
            Fisher whoCatches = firstFisherPulls ? fisher1 : fisher2;

            FishType selectedType = fishTypes[random.Next(fishTypes.Length)];
            double weight = selectedType.GetRandomWeight(random);
            Fish fish = new Fish(selectedType.Name, weight);

            whoCatches.CatchFish(fish);
        }

        Console.WriteLine($"\nВсього клювань: {biteCount}");
        Console.WriteLine($"{fisher1.Name} спіймав {fisher1.FishCount} риб.");
        Console.WriteLine($"{fisher2.Name} спіймав {fisher2.FishCount} риб.");

        Console.Write("\nПоказати деталі улову? (так/ні): ");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "так")
        {
            ShowCatch(fisher1);
            ShowCatch(fisher2);
        }
    }

    private void ShowCatch(Fisher fisher)
    {
        Console.WriteLine($"\nУлов {fisher.Name}:");
        for (int i = 0; i < fisher.FishCount; i++)
        {
            Console.WriteLine($"- {fisher.Catch[i]}");
        }
    }
}