using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // when game start, store offset of camera's position based on the player.
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
