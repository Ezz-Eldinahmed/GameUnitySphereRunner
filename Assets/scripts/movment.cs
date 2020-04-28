using UnityEngine;

public class movment : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce = 50f;
    public float PlayerForce = 60f;

    // Start is called before the first frame update
    //void Start()
    //{
    //Debug.Log("Hello");
    //rb.useGravity = false;
    //rb.AddForce(0,200,500);
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    rb.AddForce(0, 0, 200*Time.deltaTime);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        //add a forward force
        //rb.AddForce(0, 0, ForwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("d")) {
        //add a forward force
        rb.AddForce(PlayerForce * Time.deltaTime, 0,  0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            //add a forward force
            rb.AddForce(-PlayerForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            //add a forward force
            rb.AddForce( 0, 0, PlayerForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            //add a forward force
            rb.AddForce(0, 0, -PlayerForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManger>().EndGame();
        }
    }
}
