using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trainmovement2 : MonoBehaviour
{
  private void Update ()
  {
    transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
  }
  private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == "Lion"){
      Debug.Log("HIT");
      SceneManager.LoadScene("GameOver");
            Time.timeScale = 0;
    }
    if(other.gameObject.tag == "trainreset"){
      transform.position = new Vector3((float)2.97, (float)-10.09, 0);
      Debug.Log("HIT End");
    }
  }
}
