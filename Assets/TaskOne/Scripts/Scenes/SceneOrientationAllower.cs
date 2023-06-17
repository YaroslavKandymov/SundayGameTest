using UnityEngine;

namespace SundaygameTest
{
    public class SceneOrientationAllower : MonoBehaviour
    {
        [SerializeField] private bool _value;

        private void Awake()
        {
            Screen.autorotateToPortrait = _value;
            Screen.autorotateToPortraitUpsideDown = _value;
            Screen.autorotateToLandscapeLeft = _value;
            Screen.autorotateToLandscapeRight = _value;
        }
    }
}