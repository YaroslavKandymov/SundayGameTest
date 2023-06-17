using SundaygameTest.EventReceivers;
using SundaygameTest.TaskTwo.Scripts.AnimationPlayers;
using UnityEngine;

namespace SundaygameTest
{
    public class ShootMechanic : MonoBehaviour
    {
        [SerializeField] private EventReceiver _shootReceiver;
        [SerializeField] private HumanoidAnimationPlayer _animationPlayer;
        
        private void OnEnable()
        {
            _shootReceiver.Event += OnEvent;
        }

        private void OnDisable()
        {
            _shootReceiver.Event -= OnEvent;
        }

        private void OnEvent()
        {
            _animationPlayer.PlayShootAnimation();
        }
    }
}