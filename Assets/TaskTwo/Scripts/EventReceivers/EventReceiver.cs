using System;
using UnityEngine;

namespace SundaygameTest.EventReceivers
{
    public class EventReceiver : MonoBehaviour
    {
        public event Action Event;
        
        public void Call()
        {
            Event?.Invoke();
        }
    }
}