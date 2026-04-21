using System;
using System.Collections;
using System.Collections.Generic;
using Code.Shared.Models;
using Code.Shared.Types;

namespace Code.Shared.Collections
{
    public class ServiceCollection:IEnumerable<ServiceInjectionModel>
    {
        public List<ServiceInjectionModel> Services { get; } = new();


        public void Add(ServiceCollection serviceCollection)
        {
            Services.AddRange(serviceCollection.Services);
        }

        
        public void Add(Type type, ServiceInjectionType injectionMethod)
        {
            Services.Add(new ServiceInjectionModel
            {
                Type = type,
                InjectionType = injectionMethod
            });
        }

        public void Add<T>(ServiceInjectionType injectionMethod)
        {
            Add(typeof(T), injectionMethod);
        }

        public void AddTransient<T>()
        {
            Add(typeof(T), ServiceInjectionType.Transient);
        }

        public void AddSingleton<T>()
        {
            Add<T>(ServiceInjectionType.Single);
        }

        public void Add(Type type, Type implementationType, ServiceInjectionType injectionMethod)
        {
            Services.Add(new ServiceInjectionModel
            {
                Type = type,
                ImplementationType = implementationType,
                InjectionType = injectionMethod
            });
        }

        public void Add<T, TImpel>(ServiceInjectionType injectionMethod) where TImpel : T
        {
            Add(typeof(T), typeof(TImpel), injectionMethod);
        }

        public void AddTransient<T, TImpel>() where TImpel : T
        {
            Add<T, TImpel>(ServiceInjectionType.Transient);
        }

        public void AddSingleton<T, TImpel>() where TImpel : T
        {
            Add<T, TImpel>(ServiceInjectionType.Single);
        }

        public IEnumerator<ServiceInjectionModel> GetEnumerator()
        {
            return Services.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}