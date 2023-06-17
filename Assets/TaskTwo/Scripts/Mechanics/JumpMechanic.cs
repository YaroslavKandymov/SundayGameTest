using SundaygameTest.EventReceivers;
using SundaygameTest.TaskTwo.Scripts.AnimationPlayers;
using UnityEngine;

namespace SundaygameTest
{
    public class JumpMechanic : MonoBehaviour
    {
        [SerializeField] private EventReceiver _jumpReceiver;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private float _force;
        [SerializeField] private HumanoidAnimationPlayer _animationPlayer;
        
        private void OnEnable()
        {
            _jumpReceiver.Event += OnEvent;
        }

        private void OnDisable()
        {
            _jumpReceiver.Event -= OnEvent;
        }

        private void OnEvent()
        {
            _rigidbody.velocity = Vector3.up * _force;
            
            _animationPlayer.PlayJumpAnimation();
        }
    }
}