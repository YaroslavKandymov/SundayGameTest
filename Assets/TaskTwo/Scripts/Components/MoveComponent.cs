using SundaygameTest.EventReceivers;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;

namespace SundaygameTest.Components
{
    public class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField] private Vector2EventReceiver _directionReceiver;
        
        public void Move(Vector2 direction)
        {
            _directionReceiver.Call(direction);
        }
    }
}