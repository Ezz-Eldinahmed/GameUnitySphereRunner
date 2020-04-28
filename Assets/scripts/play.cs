using UnityEngine.SceneManagement;

using UnityEngine;

public class play : MonoBehaviour
{
    public void playing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exit()
    {
        Application.Quit();
    }
}