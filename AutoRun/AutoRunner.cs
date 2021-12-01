using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using AutoRun.Attributes;

namespace AutoRun
{
    public static class AutoRunner
    {
        public static IEnumerable<Result> Run()
        {
            var assembly = Assembly.GetCallingAssembly();
            var types = assembly
                .GetTypes()
                .Where(x => x.GetCustomAttributes<RunClassAttribute>().Any());
            
            List<Result> results = new ();

            foreach (var type in types)
            {
                foreach (var method in type.GetMethods())
                {
                    if (!method.GetCustomAttributes<RunMethodAttribute>().Any() || !method.IsStatic) 
                        continue;
                    
                    method.Invoke(null, null);
                        
                    var time = DateTime.UtcNow.AddHours(-3);

                    results.Add(new Result(type, method, time));
                }
            }

            return results;
        }
    }
}