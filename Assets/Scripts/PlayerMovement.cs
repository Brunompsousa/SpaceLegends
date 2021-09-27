using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 2f;
    public Vector3 MoveDirection;
    public Vector2 JumpForce;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {

        MoveDirection.x = Input.GetAxisRaw("Horizontal");

        transform.position += MoveDirection * Speed * Time.fixedDeltaTime;

        if (Input.GetButtonDown("Jump") && isGrounded)
            jump();
    }


    void jump()
    {
        GetComponent<Rigidbody2D>().AddForce(JumpForce,ForceMode2D.Force);
    }

    private void OnTriggerEnter2D()
    {
        isGrounded = true;
    }

    private void OnTriggerStay2D()
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D()
    {
        isGrounded = false;
    }

}
