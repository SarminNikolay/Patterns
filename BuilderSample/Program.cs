using System;

namespace BuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var collector = new Collector();
            ChairBuilder builder = new StandartChairBuilder();
            Chair myChair = collector.Collect(builder);
            System.Console.WriteLine("Параметры заказа:");
            System.Console.WriteLine(myChair);
        }
    }
}
