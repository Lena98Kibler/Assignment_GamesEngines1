using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighControler : MonoBehaviour
{

    //controlling speeds
    public float forwardSpeed = 25f;
    public float strafeSpeed = 7.5f;
    public float hoverSpeed = 5f;

    //storing input
    private float activeForwardSpeed;
    private float activeStrafeSpeed;
    private float activeHoverSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //getting input
        activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        activeHoverSpeed = Input.GetAxisRaw("Hover") * hoverSpeed;

        //apply input to movement
        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafeSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);

    }
}
