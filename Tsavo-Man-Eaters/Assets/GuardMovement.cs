using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
  public Rigidbody2D guardBody;
  public float guardSpeed = 2f;
  public Transform[] waypoints; //array of waypoints (MUST BE IN ORDER)

    // Start is called before the first frame update
    void Start(){
      //avoid trying to pathfind between one way point
      if(!(waypoints.Length > 1))
      {
        Debug.LogError("No path given, exiting.", gameObject);
      }
    }

    void FixedUpdate()
    {
        //PlayerMovement
        transform.position = Vector2.MoveTowards(transform.position, waypoints[1].position, guardSpeed * Time.fixedDeltaTime);
    }
}
