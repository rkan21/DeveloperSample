using System;

namespace DeveloperSample.Container
{
    public class Container
    {
        public void Bind(Type interfaceType, Type implementationType)
        {
            if (!interfaceType.IsAssignableFrom(implementationType))
            {
                throw new ArgumentException($"The type {implementationType.FullName} must implement the interface {interfaceType.FullName}");
            }
        }
        public T Get<T>()
        {
            return (T)Activator.CreateInstance(typeof(T));
        }
    }
}