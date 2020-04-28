using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform scorse;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float f = scorse.position.z + 892.55f;
        txt.text=f.ToString("0");
    }
}
