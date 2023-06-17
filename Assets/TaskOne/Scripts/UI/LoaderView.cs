using System;
using DG.Tweening;
using SundaygameTest.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SundaygameTest.UI
{
    public class LoaderView : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Slider _slider;
        [SerializeField] private float _duration;
        [SerializeField] private float _maxPercents;
        [SerializeField] private Ease _ease;

        public event Action Complete;
        
        private void Start()
        {
            _canvasGroup.Close();
        }

        public void Play()
        {
            _canvasGroup.Open();
            float currentValue = 0f;

            DOTween.To(() => currentValue, x => currentValue = x, _maxPercents, _duration)
                .OnUpdate(() => FillViews(currentValue))
                .SetEase(Ease.Linear)
                .OnComplete(() => Complete?.Invoke());
        }

        private void FillViews(float currentValue)
        {
            int intValue = Mathf.FloorToInt(currentValue);
            _text.text = $"{intValue}%";
            _slider.DOValue(currentValue / _maxPercents, 0);
        }
    }
}