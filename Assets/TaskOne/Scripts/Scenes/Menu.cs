using System;
using SundaygameTest.Extensions;
using SundaygameTest.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.Scenes
{
    public class Menu : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _buttonWindow;
        [SerializeField] private LoaderView _loaderView;
        [SerializeField] private Button _loadButton;
        [SerializeField] private string _nextSceneName;

        private void OnEnable()
        {
            _loadButton.onClick.AddListener(OnLoadButtonClicked);
            _loaderView.Complete += OnLoaderComplete;
        }

        private void OnDisable()
        {
            _loadButton.onClick.RemoveListener(OnLoadButtonClicked);
            _loaderView.Complete -= OnLoaderComplete;
        }

        private void Start()
        {
            _buttonWindow.Open();
        }

        private void OnLoadButtonClicked()
        {
            _buttonWindow.Close();
            _loaderView.Play();
        }
        
        private void OnLoaderComplete()
        {
            var sceneLoader = new SceneLoader();
            sceneLoader.LoadScene(_nextSceneName);
        }
    }
}