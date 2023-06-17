using System;
using UnityEngine;

namespace SundaygameTest.EventReceivers
{
    public class FloatEventReceiver : MonoBehaviour
    {
        public event Action<float> Event;
        
        public void Call(float value)
        {
            Event?.Invoke(value);
        }
    }
}