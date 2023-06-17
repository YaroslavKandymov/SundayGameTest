using SundaygameTest.EventReceivers;
using UnityEngine;

namespace SundaygameTest
{
    public class StepsParticlePlayer : MonoBehaviour
    {
        [SerializeField] private EventReceiver _leftStepReceiver;
        [SerializeField] private EventReceiver _rightStepReceiver;
        [SerializeField] private ParticleSystem _leftStepParticle;
        [SerializeField] private ParticleSystem _rightStepParticle;

        private void OnEnable()
        {
            _leftStepReceiver.Event += OnLeftStep;
            _rightStepReceiver.Event += OnRightStep;
        }

        private void OnDisable()
        {
            _leftStepReceiver.Event -= OnLeftStep;
            _rightStepReceiver.Event -= OnRightStep;
        }

        private void OnLeftStep()
        {
            _leftStepParticle.Play(true);
        }
        
        private void OnRightStep()
        {
            _rightStepParticle.Play(true);
        }
    }
}