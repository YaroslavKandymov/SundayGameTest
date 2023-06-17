using System;
using SundaygameTest.TaskTwo.Scripts.Entities;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;

namespace SundaygameTest.Other
{
    public class EntityMover : MonoBehaviour
    {
        [SerializeField] private JoystickInput _joystickInput;
        [SerializeField] private UnityEntity _entity;

        private IMoveComponent _moveComponent;
        
        private void OnEnable()
        {
            _joystickInput.Moved += OnMoved;
        }

        private void OnDisable()
        {
            _joystickInput.Moved -= OnMoved;
        }

        private void Start()
        {
            _moveComponent = _entity.Get<IMoveComponent>();
        }
        
        private void OnMoved(Vector2 value)
        {
            _moveComponent.Move(value);
        }
    }
}