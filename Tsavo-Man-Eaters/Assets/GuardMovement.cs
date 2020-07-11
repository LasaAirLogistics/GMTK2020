using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
  public Rigidbody2D guardBody;
  public float guardSpeed = 2f;
  public Transform[] waypoints; //array of waypoints (MUST BE IN ORDER)
  private int curPoint = 0;

    // Start is called before the first frame update
    void Start(){
      //avoid trying to pathfind between one way point
      if(waypoints.Length <= 1)
      {
        Debug.LogError("No path given, exiting.", gameObject);
      }

      //GuardMovement
      transform.position = waypoints[0].position;
    }

    void FixedUpdate()
    {
      //GuardMovement
      transform.position = Vector2.MoveTowards(transform.position, waypoints[curPoint].position, guardSpeed * Time.fixedDeltaTime);

        if(Vector3.Distance(waypoints[curPoint].position, transform.position) < .7){ //check if we finished last move
          curPoint = curPoint + 1;
          if(curPoint >= waypoints.Length){
            curPoint = 0;
          }
        }
    }
}
