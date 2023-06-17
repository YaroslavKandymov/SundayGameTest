using SundaygameTest.EventReceivers;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;

namespace SundaygameTest.Components
{
    public class JumpComponent : MonoBehaviour, IJumpComponent
    {
        [SerializeField] private EventReceiver _jumpReceiver;
        
        public void Jump()
        {
            _jumpReceiver.Call();
        }
    }
}