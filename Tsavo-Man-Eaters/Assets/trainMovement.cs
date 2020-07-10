using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainMovement : MonoBehaviour
{
  private void Update()
  {
    transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
  }
  private void OnTriggerEnter2D(Collider2D other){
    Debug.Log("HIT");
  }
}
