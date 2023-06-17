using System;
using SundaygameTest.EventReceivers;
using SundaygameTest.Other;
using SundaygameTest.TaskTwo.Scripts.AnimationPlayers;
using UnityEngine;

namespace SundaygameTest
{
    public class MoveMechanic : MonoBehaviour
    {
        [SerializeField] private Vector2EventReceiver _directionReceiver;
        [SerializeField] private float _speed;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private HumanoidAnimationPlayer _animationPlayer;

        private SurfaceSlider _surfaceSlider;

        private void Awake()
        {
            _surfaceSlider = new SurfaceSlider();
        }

        private void OnEnable()
        {
            _directionReceiver.Event += OnEvent;
        }

        private void OnDisable()
        {
            _directionReceiver.Event -= OnEvent;
        }
        
        private void OnEvent(Vector2 direction)
        {
            Move(new Vector3(direction.x, 0, direction.y));
        }

        private void Move(Vector3 direction)
        {
            if (Math.Abs(direction.x) > Mathf.Epsilon || Math.Abs(direction.y) > Mathf.Epsilon)
            {
                Vector3 directionAlongSurface = _surfaceSlider.Project(direction.normalized);
                Vector3 offset = directionAlongSurface * (_speed * Time.deltaTime);

                var nextPosition = _rigidbody.position + offset;

                _rigidbody.MovePosition(nextPosition);
            
                _animationPlayer.PlayRunAnimation();   
            }
            else
            {
                _animationPlayer.PlayIdleAnimation();   
            }
        }
    }
}
