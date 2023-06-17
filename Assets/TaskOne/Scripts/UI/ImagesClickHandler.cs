using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.UI
{
    public class ImagesClickHandler : MonoBehaviour
    {
        [SerializeField] private ImageCreator _creator;

        private readonly List<ImageCell> _imageCells = new();

        public event Action Clicked;

        private void OnEnable()
        {
            _creator.Created += OnImageCreated;
        }

        private void OnDisable()
        {
            _creator.Created -= OnImageCreated;
        }

        private void OnDestroy()
        {
            foreach (var cell in _imageCells)
            {
                cell.Clicked -= OnCellClicked;
            }
        }

        private void OnImageCreated(ImageCell cell)
        {
            _imageCells.Add(cell);

            cell.Clicked += OnCellClicked;
        }

        private void OnCellClicked(ImageCell cell)
        {
            var sprite = Sprite.Create((Texture2D) cell.Texture,
                new Rect(0.0f, 0.0f, cell.Texture.width, cell.Texture.height), new Vector2(0.5f, 0.5f), 100.0f);
            
            TargetTextureContainer.Sprite = sprite;

            Clicked?.Invoke();
        }
    }
}