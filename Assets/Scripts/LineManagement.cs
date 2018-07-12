using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManagement : MonoBehaviour {

    private KeyCode left = KeyCode.A;
    private KeyCode right = KeyCode.D;
    private float lineSpeed = 70f;

    void Update()
    {
        Vector3 vel = gameObject.GetComponent<Rigidbody2D>().velocity;
        if (Input.GetKeyDown(right))
        {
            vel.x = lineSpeed;
        }
        else if (Input.GetKeyDown(left))
        {
            vel.x = -lineSpeed;
        }
        else if(Input.GetKeyUp(right) || Input.GetKeyUp(left))
        {
            vel.x = 0;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
    }
}
