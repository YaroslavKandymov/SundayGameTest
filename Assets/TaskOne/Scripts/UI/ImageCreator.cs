using System;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.UI
{
    public class ImageCreator : MonoBehaviour
    {
        [SerializeField] private TextureLoader _textureLoader;
        [SerializeField] private ImageCell _cell;
        [SerializeField] private Transform _parent;
        [SerializeField] private ScrollRect _scrollRect;
        
        public float spawnThreshold = 0.8f;
        
        private int _count;
        private RectTransform contentRectTransform;

        public event Action<ImageCell> Created;
        
        private void OnEnable()
        {
            _textureLoader.TextureLoaded += OnTextureLoaded;
        }

        private void OnDisable()
        {
            _textureLoader.TextureLoaded -= OnTextureLoaded;
        }
        
        private void Start()
        {
            _count = 1;
            contentRectTransform = _scrollRect.content;
        }
        
        private void Update()
        {
            if (contentRectTransform.anchoredPosition.y <= -contentRectTransform.sizeDelta.y * spawnThreshold)
            {
                _textureLoader.LoadImage(_count);
                _count++;
            }
        }
        
        private void OnTextureLoaded(Texture2D texture)
        {
            var cell = Instantiate(_cell, _parent);
            cell.Init(texture);
            
            Created?.Invoke(cell);
        }
    }
}