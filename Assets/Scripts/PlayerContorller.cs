using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerContorller : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    Rigidbody rb;
    int count;

    // Start is called before the first frame update
    // therefore, usually it is used in order to initialize variables.
    void Start()
    {
        // get rigidbody component that this object takes.
        rb = GetComponent<Rigidbody>();

        count = 0;
        SetCountText();
        winText.text = "";
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

    // when collision, Trigger Collider
    void OnTriggerEnter(Collider other)
    {
        // if a collided Collider  have a tag called "Item",
        if (other.tag == "Item")
        {
            // then, this collider changes a state to inactive.
            other.gameObject.SetActive(false);

            ++count;
            SetCountText();

            if(count >= 7)
            {
                winText.text = "You Win!";
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Count : " + count.ToString();
    }
}
