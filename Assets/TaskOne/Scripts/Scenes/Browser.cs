using System;
using SundaygameTest.Scenes;
using SundaygameTest.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.TaskOne.Scripts.Scenes
{
    public class Browser : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private Button _closeButton;
        [SerializeField] private string _nextScene;

        private void OnEnable()
        {
            _closeButton.onClick.AddListener(OnCloseButtonClicked);
        }

        private void OnDisable()
        {
            _closeButton.onClick.RemoveListener(OnCloseButtonClicked);
        }

        private void Start()
        {
            _image.sprite = TargetTextureContainer.Sprite;
        }
        
        private void OnCloseButtonClicked()
        {
            var sceneLoader = new SceneLoader();
            
            sceneLoader.LoadScene(_nextScene);
        }
    }
}