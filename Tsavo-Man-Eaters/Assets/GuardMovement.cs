using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
  public Rigidbody2D guardBody;
  public float guardSpeed = 2f;
  public Transform[] waypoints;

    // Start is called before the first frame update
    void Start() {}
    void FixedUpdate()
    {
        //PlayerMovement
        guardBody.MoveTowards(transform.position, waypoints[1], guardSpeed * Time.fixedDeltaTime);
    }
}
