using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    public float VerticalSpeed = 0.5f;
    public float JumpForce = 10f;
    private Rigidbody2D rigidBody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x - VerticalSpeed, rigidBody.velocity.y);
            //transform.position -= new Vector3(VerticalSpeed + Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x + VerticalSpeed, rigidBody.velocity.y);
            //transform.position += new Vector3(VerticalSpeed + Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, JumpForce);
        }
    }
}
