using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySquare : MonoBehaviour
{

    float speed = 2f;

    float rotateSpeed = 200f;

    Vector3 velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity = MovementTurning();
        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;
        BoundsChecking();
        ChangeColor();
    }

    Vector2 MovementTurning()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, (transform.eulerAngles.z + rotateSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 0, (transform.eulerAngles.z - rotateSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += (Vector3)LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= (Vector3)LookAtDirection(transform.eulerAngles.z);
        }

        return velocity;
    }

    Vector2 MovementWASD()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            velocity += Vector3.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity += Vector3.down;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right;
        }
        return velocity;
    }

    public void BoundsChecking()
    {
        Vector3 pos = transform.position;
        if (pos.x > 1.75f)
        {
            pos.x = 1.75f;
        }
        else if (pos.x < -1.75f)
        {
            pos.x = -1.75f;
        }

        if (pos.y > 1)
        {
            pos.y = 1;
        }
        else if (pos.y < -1)
        {
            pos.y = -1;
        }

        transform.position = pos;
    }

    public Vector2 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector2(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad));
    }

    float timer = 0;
    float timeToReach = .25f;
    void ChangeColor()
    {
        timer += Time.deltaTime;
        if (timer > timeToReach)
        {
            timer = 0;
            GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
