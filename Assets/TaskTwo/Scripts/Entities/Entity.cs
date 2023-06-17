using System;
using System.Collections.Generic;
using SundaygameTest.TaskTwo.Scripts.Interfaces;

namespace SundaygameTest.TaskTwo.Scripts.Entities
{
    public class Entity : IEntity
    {
        protected readonly List<object> _elements;

        public Entity()
        {
            _elements = new List<object>();
        }

        public Entity(IEnumerable<object> elements)
        {
            _elements = new List<object>(elements);
        }

        public Entity(params object[] elements)
        {
            _elements = new List<object>(elements);
        }

        public T Get<T>()
        {
            for (int i = 0, count = _elements.Count; i < count; i++)
            {
                if (_elements[i] is T result)
                {
                    return result;
                }
            }

            throw new Exception($"Element of type {typeof(T).Name} is not found!");
        }

        public T[] GetAll<T>()
        {
            var result = new List<T>();
            for (int i = 0, count = _elements.Count; i < count; i++)
            {
                if (_elements[i] is T element)
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }

        public object[] GetAll()
        {
            return _elements.ToArray();
        }

        public void Add(object element)
        {
            _elements.Add(element);
        }

        public void Remove(object element)
        {
            _elements.Remove(element);
        }

        public bool TryGet<T>(out T element)
        {
            for (int i = 0, count = _elements.Count; i < count; i++)
            {
                if (_elements[i] is T result)
                {
                    element = result;
                    return true;
                }
            }

            element = default;
            return false;
        }
    }
}