using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainMovement : MonoBehaviour
{
  private void Update()
  {
    transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
  }
  private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == "Lion"){
      Debug.Log("HIT");
      Time.timeScale = 0;
    }
  }
}