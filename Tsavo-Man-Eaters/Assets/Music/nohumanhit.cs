using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nohumanhit : MonoBehaviour
{

  public AudioClip trombone;
  private bool hasEntered;

  void Start ()
   {
       GetComponent<AudioSource> ().playOnAwake = false;
       GetComponent<AudioSource> ().clip = trombone;
   }

  public void OnTriggerEnter2D(Collider2D lion)
  {

    if(lion.gameObject.tag == "Lion" && !hasEntered){
      hasEntered = true;
      GetComponent<AudioSource> ().Play ();
    }
  }

}
