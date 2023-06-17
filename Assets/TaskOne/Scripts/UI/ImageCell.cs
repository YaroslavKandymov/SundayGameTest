using System;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.UI
{
    public class ImageCell : MonoBehaviour
    {
        [SerializeField] private RawImage _rawImage;
        [SerializeField] private Button _button;

        public event Action<ImageCell> Clicked;

        public Texture Texture => _rawImage.texture;

        public void Init(Texture2D texture)
        {
            _rawImage.texture = texture;
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Clicked?.Invoke(this);
        }
    }
}