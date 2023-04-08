using UnityEngine.SceneManagement;
using UnityEngine;

public class sceneinit : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }
}
