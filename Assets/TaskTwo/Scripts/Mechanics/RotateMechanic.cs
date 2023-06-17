using System;
using SundaygameTest.EventReceivers;
using UnityEngine;

namespace SundaygameTest
{
    public class RotateMechanic : MonoBehaviour
    {
        private const float Epsilon = 0.01f;
        
        [SerializeField] private Vector2EventReceiver _directionReceiver;
        [SerializeField] private Transform _transform;
        
        private bool _flipRotation = true;
        
        private void OnEnable()
        {
            _directionReceiver.Event += OnEvent;
        }

        private void OnDisable()
        {
            _directionReceiver.Event -= OnEvent;
        }

        private void OnEvent(Vector2 value)
        {
            Rotate(value.x, value.y);
        }

        private void Rotate(float horizontal, float vertical)
        {
            float angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
            angle = _flipRotation ? -angle : angle;

            if (Math.Abs(vertical) > Epsilon && Math.Abs(horizontal) > Epsilon)
            {
                _transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
            }
        }
    }
}