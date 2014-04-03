using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour {

    float speed = 3f;
    Vector2 vel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            vel = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        }
        else
        {
            vel.x = vel.y = 0;      
        }

       rigidbody2D.velocity = vel;

	}
}
