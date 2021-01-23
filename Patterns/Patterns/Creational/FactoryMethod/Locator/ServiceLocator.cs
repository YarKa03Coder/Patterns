using System;
using System.Collections.Generic;
using Patterns.Creational.FactoryMethod.Services;

namespace Patterns.Creational.FactoryMethod.Locator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly IDictionary<object, object> _dictionary;

        public ServiceLocator()
        {
            _dictionary = new Dictionary<object, object>
            {
                {typeof(ServiceA), new ServiceA()},
                {typeof(ServiceB), new ServiceB()},
                {typeof(ServiceC), new ServiceC()},
                {typeof(ServiceD), new ServiceD()}
            };
        }
        
        public T GetService<T>()
        {
            try
            {
                return (T) _dictionary[typeof(T)];
            }
            catch (Exception)
            {
                throw new ApplicationException("The requested service is not registered!");
            }
        }
    }
}