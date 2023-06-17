using System;
using UnityEngine;

namespace SundaygameTest.EventReceivers
{
    public class StepsEventReceiver : MonoBehaviour
    {
        [SerializeField] private EventReceiver _leftStep;
        [SerializeField] private EventReceiver _rightStep;
        
        public void LeftStepCall()
        {
           _leftStep.Call();
        }
        
        public void RightStepCall()
        {
           _rightStep.Call();
        }
    }
}