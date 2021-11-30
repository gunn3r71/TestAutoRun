using System;
using AutoRun.Attributes;

namespace TestAutoRun.Tasks
{
    [RunClass]
    public class TaskB
    {
        [RunMethod]
        public static void Start() => Console.WriteLine("B.Start()");
    }
}