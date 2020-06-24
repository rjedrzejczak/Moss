using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void CreateCounters()
        {
            if (!PerformanceCounterCategory.Exist("Contoso"))
            {
                var counters = new CounterCreationDataCollection();
                var ccdCounter1 = new CounterCreationData
                {
                    
                }
            }
        }
    }
}