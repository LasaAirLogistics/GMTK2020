using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
  public Rigidbody2D[] rb;
  public float guardSpeed = 2f;
  public Rigidbody2D[] waypoints;
  Vector2 movement;

    // Start is called before the first frame update
    void Start() {}
    void FixedUpdate()
    {
        //PlayerMovement
        rb.MovePosition(waypoints[1].position * moveSpeed * Time.fixedDeltaTime);
    }
}
