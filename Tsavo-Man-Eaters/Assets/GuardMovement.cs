using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
  public Rigidbody2D guardBody; //which riged body we are puppetering
  public float guardSpeed = 4f; //speed the guard moves at
  public float closeEnoughBuffer = 0.1f; //distance away from waypoint we conse
  public Transform[] waypoints; //array of waypoints (MUST BE IN ORDER)

  private int curPoint = 0;
  private float closeEnoughDist = 0f;

  // Start is called before the first frame update
  void Start(){
    //avoid trying to pathfind between one way point
    if(waypoints.Length <= 1){Debug.LogError("No path given, exiting.", gameObject);}

    //first movement, make sure we start on the first waypoint
    transform.position = waypoints[0].position;
  }

  void FixedUpdate()
  {
    if(waypoints.Length <= 1){Debug.LogError("No path given, exiting.", gameObject);} //make sure path is valid
    else{
      //GuardMovement
      transform.position = Vector2.MoveTowards(transform.position, waypoints[curPoint].position, guardSpeed * Time.fixedDeltaTime);
      Vector2 turnTo = waypoints[curPoint].position - transform.position;
      transform.right = turnTo * 10 * Time.fixedDeltaTime;

      //automatically set closeEnoughDist and add user given closeEnoughBuffer
      //THIS MUST BE DONE AFTER THE FIRST MOVE ORDER AS THIS IS WHAT SCREWS UP THE DISTANCE CALCULATION!!!!!
      if(closeEnoughDist == 0f){
        closeEnoughDist = (transform.position - waypoints[curPoint].position).magnitude + closeEnoughBuffer; //get the distance we are to first waypoint
        Debug.Log("Set Buffer:" + closeEnoughDist, gameObject);
      }

      //check if we finished last move
      if((transform.position - waypoints[curPoint].position).magnitude <= closeEnoughDist){
        curPoint = curPoint + 1; //start move to the next point in array
        if(curPoint >= waypoints.Length){ //if we need to loop to the beginning to that
          curPoint = 0;
        }
      }
    }
  }
}
