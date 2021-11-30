using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoRun
{
    public class Result
    {
        public Result(Type classType, 
            MethodInfo method,
            DateTime time)
        {
            ClassType = classType;
            Method = method;
            Time = time;
        }

        public Type ClassType { get; private set; }
        public MethodInfo Method  { get; private set; }
        public DateTime Time { get; private set; }

        public override string ToString()
        {
            return $"Class: {ClassType.Name}\n" +
                   $"Method: {Method.Name}\n" +
                   $"Time: {Time:hh:mm:ss}";

        }
    }
}
