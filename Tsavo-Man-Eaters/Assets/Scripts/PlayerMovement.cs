using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
      //input
        Time.timeScale = 1.0f;
        if (moveSpeed == 5f)
        {
          moveSpeed = Random.value * 10;
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        //PlayerMovement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        moveSpeed = Random.value * 10;
    }
}
