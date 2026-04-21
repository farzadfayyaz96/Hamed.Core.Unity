using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Code.Shared.Helpers
{
    public static class TypeHelper
    {
        
        public static List<T> FindObjects<T>() where T : class
        {
            var interfaceType = typeof(T);
            var implementations = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t)
                            && !t.IsInterface
                            && !t.IsAbstract);

            var instances = implementations
                .Select(t => (T)Activator.CreateInstance(t))
                .ToList();
            
            return instances;
        }
        
        
        
    }
}