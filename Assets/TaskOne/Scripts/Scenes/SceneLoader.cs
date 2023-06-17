using UnityEngine.SceneManagement;

namespace SundaygameTest.Scenes
{
    public class SceneLoader
    {
        public void LoadScene(string name)
        {
            SceneManager.LoadScene(name);
        }
    }
}