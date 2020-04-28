
using UnityEngine;

public class collisionPlayer : MonoBehaviour
{
    public movment m;
    
    void OnCollisionEnter(Collision info)
    {
        if(info.collider.tag == "obstacles")
        {
           // m.enabled = false;
            GetComponent<movment>().enabled = false;//same

            FindObjectOfType<gameManger>().EndGame();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
