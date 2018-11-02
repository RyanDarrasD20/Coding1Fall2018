using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    Vector3 goalPosition = new Vector3();
    Vector3 velocity = new Vector3();

    float cameraMoveSpeedX = 3f;
    float cameraMoveSpeedY = 1.5f;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(player.transform.position.x, 
            player.transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        goalPosition = new Vector3(player.transform.position.x + player.GetComponent<Rigidbody2D>().velocity.x, 
            player.transform.position.y + player.GetComponent<Rigidbody2D>().velocity.y, transform.position.z);
        velocity = goalPosition - transform.position;

        if (velocity.magnitude > .025f)
        {
            transform.position += new Vector3(velocity.x * cameraMoveSpeedX * Time.deltaTime, 
                velocity.y * cameraMoveSpeedY * Time.deltaTime, 0);
        }
    }
}
