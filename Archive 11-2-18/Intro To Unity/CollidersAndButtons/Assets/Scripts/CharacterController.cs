using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Vector2 velocity = new Vector2(0,0);
    Rigidbody2D rbody;

    float jumpPower = 4;
    float speed = 4;

	// Use this for initialization
	void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = rbody.velocity;
        if (Input.GetKeyDown(KeyCode.W))
            velocity += Vector2.up * jumpPower;
        if (Input.GetKey(KeyCode.A))
            velocity -= Vector2.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.D))
            velocity += Vector2.right * Time.deltaTime * speed;

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            velocity = new Vector2(velocity.x / 1.1f, velocity.y);

        rbody.velocity = new Vector2(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f));
    }
}
