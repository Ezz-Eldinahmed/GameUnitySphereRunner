using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManger : MonoBehaviour
{
    bool gOver = false;

    public GameObject completeLevel;

    public void CompleteLevel()
    {
        completeLevel.SetActive(true);
    }
    
        public void EndGame()
    {
        if (gOver == false)
        {
            gOver = true;
            Debug.Log("Game Over");
            //restart game
            Invoke("Restart", 2f);
        }
    }
    void Restart()
    {
        //SceneManager.LoadScene("SampleScene");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
