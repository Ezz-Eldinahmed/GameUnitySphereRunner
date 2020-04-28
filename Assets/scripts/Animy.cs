using UnityEngine.SceneManagement;
using UnityEngine;

public class Animy : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
