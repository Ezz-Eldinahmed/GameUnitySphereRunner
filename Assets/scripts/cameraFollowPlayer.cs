
using UnityEngine;


public class cameraFollowPlayer : MonoBehaviour
{

    public Transform p;
    public Vector3 offset = new Vector3(0.0f, 8.0f, -5.0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = p.position + offset;
        //ass a first person position
    }
}
