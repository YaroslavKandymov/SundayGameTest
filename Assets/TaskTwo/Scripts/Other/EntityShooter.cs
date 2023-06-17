using SundaygameTest.TaskTwo.Scripts.Entities;
using SundaygameTest.TaskTwo.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.Other
{
    public class EntityShooter : MonoBehaviour
    {
        [SerializeField] private UnityEntity _entity;
        [SerializeField] private Button _button;

        private IShootComponent _shootComponent;
        
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
            _shootComponent = _entity.Get<IShootComponent>();
        }

        private void OnButtonClicked()
        {
            _shootComponent.Shoot();
        }
    }
}