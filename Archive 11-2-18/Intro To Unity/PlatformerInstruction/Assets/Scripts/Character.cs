using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public List<Vector3> teleportLocations = new List<Vector3>();
    float jump = 4;
    float speed = 2;
    bool canJump = true;
    Vector3 velocity = new Vector3(0,0,0);
    Rigidbody2D rbody;

    void Awake()
    {
        GameManager.Instance.Player = this;
    }

    void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	void Update (){
        velocity = rbody.velocity;
		if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            velocity += Vector3.up * jump;
            canJump = false;
        }
        if (Input.GetKey(KeyCode.A))
            velocity -= Vector3.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            velocity += Vector3.right * speed * Time.deltaTime;
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f), 0);
    }

    public void OnClickTeleportButton()
    {
        transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
            canJump = true;
    }
}
