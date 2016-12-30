using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }

    public Rigidbody rb;
    public float rotationSpeed = 100;
    public float jumpHeight = 8;
    private bool isFalling = false;

    // Update is called once per frame
    void Update () {

        //handling ball rotation next 3
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime; //makes it multiply by how long you press the button regardless of framerate
        rb.AddRelativeTorque(Vector3.back * rotation);

        if (Input.GetKeyDown(KeyCode.W) &&  isFalling == false) //if w is pressed, note a good implementation
        {
            //next 3 lines is to give velocity to the y axis simulating a jump
            Vector3 v3 = rb.velocity;
            v3.y = jumpHeight;
            rb.velocity = v3;            
        }
        isFalling = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        isFalling = false;
    }

}
