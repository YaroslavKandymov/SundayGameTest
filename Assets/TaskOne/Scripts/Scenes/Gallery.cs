using SundaygameTest.Scenes;
using SundaygameTest.UI;
using UnityEngine;

namespace SundaygameTest.TaskOne.Scripts.Scenes
{
    public class Gallery : MonoBehaviour
    {
        [SerializeField] private ImagesClickHandler _imagesClickHandler;
        [SerializeField] private string _nextSceneName;
        
        private void OnEnable()
        {
            _imagesClickHandler.Clicked += OnClicked;
        }

        private void OnDisable()
        {
            _imagesClickHandler.Clicked -= OnClicked;
        }

        private void OnClicked()
        {
            var sceneLoader = new SceneLoader();
            sceneLoader.LoadScene(_nextSceneName);
        }
    }
}