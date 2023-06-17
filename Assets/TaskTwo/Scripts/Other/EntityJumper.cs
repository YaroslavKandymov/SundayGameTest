using SundaygameTest.TaskTwo.Scripts.Entities;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.Other
{
    public class EntityJumper : MonoBehaviour
    {
        [SerializeField] private UnityEntity _entity;
        [SerializeField] private Button _button;

        private IJumpComponent _jumpComponent;
        
        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void Start()
        {
            _jumpComponent = _entity.Get<IJumpComponent>();
        }

        private void OnButtonClicked()
        {
            _jumpComponent.Jump();
        }
    }
}