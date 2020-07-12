using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lairToNextLevel : MonoBehaviour
{
  public string scoreText;
  public bool finished;

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D lair)
    {
      GameObject canvas = GameObject.Find("Canvas");
      Text[] textValue = canvas.GetComponentsInChildren<Text>();
      scoreText = textValue[0].text;
      if(scoreText == "Go back to den!"){
        finished = true;
      }
      if(lair.gameObject.tag == "Lair" && finished){
            SceneManager.LoadScene("Day2");
    }
  }
}
