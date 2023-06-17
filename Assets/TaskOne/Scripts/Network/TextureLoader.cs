using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace SundaygameTest
{
    public class TextureLoader : MonoBehaviour
    {
        [SerializeField] private string _url = "http://data.ikppbb.com/test-task-unity-data/pics/";

        public event Action<Texture2D> TextureLoaded;

        public void LoadImage(int number)
        {
            StartCoroutine(LoadImageCoroutine(number));
        }

        private IEnumerator LoadImageCoroutine(int number)
        {
            string imageUrl = $"{_url}{number}.jpg";

            UnityWebRequest request = UnityWebRequestTexture.GetTexture(imageUrl);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture = DownloadHandlerTexture.GetContent(request);
                TextureLoaded?.Invoke(texture);
            }
            else
            {
                Debug.LogError("End");
            }
        }
    }
}