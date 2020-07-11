using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanhit : MonoBehaviour
{

  public AudioClip AAAGH1;
  private bool hasEntered;

  void Start ()
   {
       GetComponent<AudioSource> ().playOnAwake = false;
       GetComponent<AudioSource> ().clip = AAAGH1;
   }

  public void OnTriggerEnter2D(Collider2D lion)
  {

    if(lion.gameObject.tag == "Lion" && !hasEntered){
      hasEntered = true;
      GetComponent<AudioSource> ().Play ();
    }
  }

}
