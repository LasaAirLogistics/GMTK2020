﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    Score.scoreValue += 1;//update kill text

    if(lion.gameObject.tag == "Lion" && !hasEntered){
      hasEntered = true;
      GetComponent<AudioSource> ().Play ();
      GameObject canvas = GameObject.Find("Canvas");
      Text[] textValue = canvas.GetComponentsInChildren<Text>();
      textValue[0].text = "hey";
    }
  }

}
