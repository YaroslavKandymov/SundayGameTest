using SundaygameTest.EventReceivers;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;

namespace SundaygameTest.Components
{
    public class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField] private EventReceiver _shootReceiver;
        
        public void Shoot()
        {
            _shootReceiver.Call();
        }
    }
}