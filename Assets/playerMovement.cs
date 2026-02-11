using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()//fixed update is better for physics changes (void update should be used otherwise)
    {
         //delta time multiplied 2000 by a
                                                      //fraction to make the speed of the cube constant with different frame rates
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -1*forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(-1* sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
