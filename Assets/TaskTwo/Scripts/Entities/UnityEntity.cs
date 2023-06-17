using System;
using System.Collections.Generic;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;

namespace SundaygameTest.TaskTwo.Scripts.Entities
{
    public class UnityEntity : MonoBehaviour, IEntity, ISerializationCallbackReceiver
    {
        [SerializeField] private List<MonoBehaviour> _elements = new ();

        private Entity _entity;

        public T Get<T>()
        {
            try
            {
                return _entity.Get<T>();
            }
            catch (Exception exception)
            {
                Debug.LogError(exception.Message, this);
                
                throw;
            }
        }

        public T[] GetAll<T>()
        {
            return _entity.GetAll<T>();
        }

        public object[] GetAll()
        {
            return _entity.GetAll();
        }

        public void Add(object element)
        {
            _entity.Add(element);
        }

        public void Remove(object element)
        {
            _entity.Remove(element);
        }

        public bool TryGet<T>(out T element)
        {
            return _entity.TryGet(out element);
        }
        
        public virtual void OnAfterDeserialize()
        {
            _entity = new Entity(_elements);
        }

        public virtual void OnBeforeSerialize()
        {
        }
    }
}