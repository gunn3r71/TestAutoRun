using System;
using AutoRun;

namespace TestAutoRun
{
    public class Program
    {
        static void Main()
        {
            var results = AutoRunner.Run();

            foreach (var result in results)
                Console.WriteLine(result);
        }
    }
}
