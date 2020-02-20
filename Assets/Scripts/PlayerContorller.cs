using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{

    public float speed;

    Rigidbody rb;

    // Start is called before the first frame update
    // therefore, usually it is used in order to initialize variables.
    void Start()
    {
        // get rigidbody component that this object takes.
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // check <-, -> arrow key.
        float vertical = Input.GetAxis("Vertical");     // check up, down arraow key.

        // store a vector value inputed by arrow keys.
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        // force movement to Rigidbody.
        rb.AddForce(movement * speed);
    }
}
