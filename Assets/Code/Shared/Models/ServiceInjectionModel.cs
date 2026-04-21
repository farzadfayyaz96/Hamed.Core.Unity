using System;
using Code.Shared.Types;

namespace Code.Shared.Models
{
    public class ServiceInjectionModel
    {

        public Type Type { get; set; }
        
        public Type ImplementationType { get; set; }
        
        public ServiceInjectionType InjectionType { get; set; }
    }
}