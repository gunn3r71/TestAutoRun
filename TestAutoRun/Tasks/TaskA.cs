using AutoRun.Attributes;
using System;

namespace TestAutoRun.Tasks
{
    [RunClass]
    public class TaskA
    {
        [RunMethod]
        public static void Execute() => Console.WriteLine("A.Execute()");
    }
}