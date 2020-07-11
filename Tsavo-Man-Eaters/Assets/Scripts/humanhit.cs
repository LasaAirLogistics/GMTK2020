using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class humanhit : MonoBehaviour
{

  public AudioClip AAAGH1;
  private bool hasEntered;
  public string scoreText;
  public string outOf;
  public int updateScore;

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
      scoreText = textValue[0].text;
      outOf= scoreText.Substring(scoreText.Length - 1);
      updateScore = Convert.ToInt32(scoreText.Substring(scoreText.Length - 3, 1)) + 1;
      textValue[0].text = "Kills: " + updateScore + "/" + outOf;
      if(updateScore == Convert.ToInt32(outOf)){
        textValue[0].text = "Go back to den!";
      }
    }
  }

}
