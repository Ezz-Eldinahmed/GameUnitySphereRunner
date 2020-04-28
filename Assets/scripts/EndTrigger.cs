using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter()
    {
        FindObjectOfType<gameManger>().CompleteLevel();
    }
}
