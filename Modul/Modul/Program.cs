using System;
namespace Modul
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть ім'я першого рибалки: ");
            string name1 = Console.ReadLine();
            Console.Write("Введіть ім'я другого рибалки: ");
            string name2 = Console.ReadLine();

            Console.Write("Скільки годин тривала риболовля? ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Введіть середній інтервал між клюваннями (в хвилинах): ");
            int interval = int.Parse(Console.ReadLine());

            int maxFish = (hours * 60) / Math.Max(1, interval - 5);
            var fisher1 = new Fisher(name1, maxFish);
            var fisher2 = new Fisher(name2, maxFish);

            var fishing = new Fishing(fisher1, fisher2, hours, interval);
            fishing.StartFishing();

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}