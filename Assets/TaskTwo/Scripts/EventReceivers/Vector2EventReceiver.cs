using System;
using UnityEngine;

namespace SundaygameTest.EventReceivers
{
    public class Vector2EventReceiver : MonoBehaviour
    {
        public event Action<Vector2> Event;
        
        public void Call(Vector2 value)
        {
            Event?.Invoke(value);
        }
    }
}