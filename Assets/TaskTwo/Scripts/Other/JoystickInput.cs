using System;
using System.Collections;
using UnityEngine;

namespace SundaygameTest.Other
{
    public class JoystickInput : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;
        
        private Coroutine _coroutine;

        public event Action<Vector2> Moved;

        private void Start()
        {
            HandleJoystick();
        }

        private void HandleJoystick()
        {
            if(_coroutine != null)
                return;

            _coroutine = StartCoroutine(HandleJoystickCoroutine());
        }

        private void Stop()
        {
            if(_coroutine == null)
                return;
            
            StopCoroutine(_coroutine);
            _coroutine = null;
        }

        private IEnumerator HandleJoystickCoroutine()
        {
            while (true)
            {
                var horizontal = _joystick.Horizontal;
                var vertical = _joystick.Vertical;
                
                var direction = new Vector2(horizontal, vertical);

                Moved?.Invoke(direction);

                yield return null;
            }
        }
    }
}