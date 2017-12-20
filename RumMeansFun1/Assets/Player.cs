using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    public float movementSpeed = 10f;

    float axisY = 0f;
    float axisX = 0f;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        axisY = Input.GetAxis("Vertical") * movementSpeed;
        axisX = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.y = axisY;
        velocity.x = axisX;
        rb.velocity = velocity;
    }
}
